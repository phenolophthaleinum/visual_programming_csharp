using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace library
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.loadFile);
            this.FormClosing += new FormClosingEventHandler(this.saveFile);
            this.dataGridName.DataSource = Placeholder.readers;
            this.dataGridBooks.DataSource = Placeholder.books;
        }

        private void loadFile(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serial));
                using (var reader = XmlReader.Create("database.xml"))
                {
                    Serial data = (Serial)xmlSerializer.Deserialize(reader);
                    Placeholder.readers = data.serialReaders;
                    Placeholder.books = data.serialBooks;
                }
            }
            catch (FileNotFoundException)
            {
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Błąd wczytywania pliku database.xml.";
                return;
            }
            this.dataGridName.DataSource = Placeholder.readers;
            this.dataGridBooks.DataSource = Placeholder.books;
            this.refreshGrids();
        }

        private void saveFile(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serial));
            Serial request = new Serial(Placeholder.readers, Placeholder.books);
            try
            {
                using (var string_writer = new StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create("database.xml"))
                    {
                        xmlSerializer.Serialize(writer, request);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void refreshGrids()
        {
            this.dataGridBooks.Refresh();
            this.dataGridName.Refresh();
        }

        private void lendButton_Click(object sender, EventArgs e)
        {
            if(this.dataGridName.SelectedRows.Count != 1)
            {
                this.statusLabel.Image = Placeholder.b_warn;
                this.statusLabel.Text = "Proszę zaznaczyć pełen rekord czytelnika.";
                return;
            }

            Reader current_reader = (Reader)this.dataGridName.CurrentRow.DataBoundItem;

            if(this.dataGridBooks.SelectedRows.Count + current_reader.Liczba_ksiazek == 0)
            {
                this.statusLabel.Image = Placeholder.b_warn;
                this.statusLabel.Text = "Proszę zaznaczyć pełne rekordy książek do wypożyczenia.";
                return;
            }
            else if(this.dataGridBooks.SelectedRows.Count + current_reader.Liczba_ksiazek > 3)
            {
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Czytelnik nie może wypożyczyć więcej niż 3 książki.";
                return;
            }

            List<Book> selectedbooks = new List<Book>();

            foreach (DataGridViewRow row in this.dataGridBooks.SelectedRows)
            {
                Book current_book = (Book)row.DataBoundItem;
                selectedbooks.Add(current_book);
                if(current_book.Dostepny == false)
                {
                    this.statusLabel.Image = Placeholder.b_error;
                    this.statusLabel.Text = "Czytelnik nie może wypożyczyć już wypożyczonej książki.";
                    return;
                }
                else
                {
                    current_book.IDC_Wypozyczajacego = current_reader.IDC;
                    current_book.Dostepny = false;
                    current_reader.Liczba_ksiazek += 1;
                }
            }
            this.statusLabel.Image = Placeholder.b_info;
            this.statusLabel.Text = string.Format("Czytelnik {0} wypożyczył ",
                current_reader.IDC);
            selectedbooks.ForEach(item => this.statusLabel.Text += string.Format("{0}, ", item));
            this.refreshGrids();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridBooks.SelectedRows.Count != 1)
            {
                this.statusLabel.Image = Placeholder.b_warn;
                this.statusLabel.Text = "Proszę zaznaczyć pełen rekord książki.";
                return;
            }

            foreach (DataGridViewRow row in this.dataGridBooks.SelectedRows)
            {
                Book current_book = (Book)row.DataBoundItem;
                if(current_book.Dostepny == true)
                {
                    this.statusLabel.Image = Placeholder.b_error;
                    this.statusLabel.Text = "Czytelnik nie może zwrócić niewypożyczonej książki.";
                }
                else
                {
                    Reader current_reader = Placeholder.readers.FirstOrDefault(obj =>
                    (obj.IDC == current_book.IDC_Wypozyczajacego));
                    current_book.IDC_Wypozyczajacego = null;
                    current_book.Dostepny = true;
                    current_reader.Liczba_ksiazek -= 1;

                    this.statusLabel.Image = Placeholder.b_info;
                    this.statusLabel.Text = string.Format("Czytelnik {0} zwrócił książkę {1}.",
                        current_reader.IDC, current_book.IDK);
                }
            }
            this.refreshGrids();
        }

        private void booksListButton_Click(object sender, EventArgs e)
        {
            Reader current_reader = Placeholder.readers.FirstOrDefault(obj =>
                (obj.IDC == this.readerBox.Text));
            if (string.IsNullOrWhiteSpace(this.readerBox.Text))
            {
                this.statusLabel.Image = Placeholder.b_warn;
                this.statusLabel.Text = "Proszę uzupełnić pole z ID czytelnika.";
            }
            else if(current_reader == null)
            {
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Brak podanego ID czytelnika w bazie.";
            }
            else
            {
                Placeholder.passed_idc = current_reader.IDC;
                BooksInfo bookInfo_window = new BooksInfo();
                bookInfo_window.Show();
                this.statusLabel.Image = Placeholder.b_info;
                this.statusLabel.Text = "Gotowy";
            }
        }

        private void readerListButton_Click(object sender, EventArgs e)
        {
            Book current_book = Placeholder.books.FirstOrDefault(obj =>
                (obj.IDK == this.bookBox.Text));
            if (string.IsNullOrWhiteSpace(this.bookBox.Text))
            {
                this.statusLabel.Image = Placeholder.b_warn;
                this.statusLabel.Text = "Proszę uzupełnić pole z ID książki.";
            }
            else if (current_book == null)
            {
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Brak podanego ID książki w bazie.";
            }
            else
            {
                Placeholder.passed_idk = current_book.Dostepny;
                Placeholder.passed_idc = current_book.IDC_Wypozyczajacego;
                ReadersInfo readersInfo_window = new ReadersInfo();
                readersInfo_window.Show();
                this.statusLabel.Image = Placeholder.b_info;
                this.statusLabel.Text = "Gotowy";
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loadFile(sender, e);
            }
            catch(Exception)
            {
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Błąd wczytywania pliku database.xml.";
            }
            finally
            {
                this.statusLabel.Image = Placeholder.b_info;
                this.statusLabel.Text = "Wczytano plik database.xml.";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFile(sender, e);
            }
            catch(Exception)
            {
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Błąd zapisywania pliku database.xml.";
            }
            finally
            {
                this.statusLabel.Image = Placeholder.b_info;
                this.statusLabel.Text = "Zapisano plik database.xml.";
            }
        }
    }
}
