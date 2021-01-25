using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace library
{
    public partial class MainWindow : Form
    {
        //DataTable reader_table = Placeholder.reader_dataset.Tables[0];
        //DataTable book_table = Placeholder.book_dataset.Tables[0];
        private BindingSource binding_reader = new BindingSource();
        private BindingSource binding_book = new BindingSource();
        public List<Reader> reader_list = new List<Reader>();
        public List<Book> book_list = new List<Book>();
        public DataTable reader_table = new DataTable();
        public DataTable book_table = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.loadDatabase);
            //this.FormClosing += new FormClosingEventHandler(this.saveDatabase);
            this.dataGridName.DataSource = Placeholder.readers;
            this.dataGridBooks.DataSource = Placeholder.books;
            this.DoubleBuffered = true;
            //using (var db = new LibraryContext())
            //{
            //var x = db.Books.ToList();
            //Book newbook = new Book("Kupa", 10, 0, true);
            //db.Books.Add(newbook);
            //db.SaveChanges();
            //var y = db.Books.ToList();
            //}
            // binding_reader.DataSource = Placeholder.reader_datatable;
            // binding_book.DataSource = Placeholder.book_datatable;
            // this.dataGridName.DataSource = binding_reader;
            // this.dataGridBooks.DataSource = binding_book;
            string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }

        private void loadDatabase(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(
                global::library.Properties.Settings.Default.LibraryDatabaseConnectionString);
            try
            {
                connection.Open();
                SqlDataAdapter reader_adapter = new SqlDataAdapter("select * from Reader", connection);
                Placeholder.reader_datatable = new DataTable();
                reader_adapter.Fill(Placeholder.reader_datatable);
                //Console.WriteLine(Placeholder.reader_datatable.Tables.ToString());
                //this.dataGridName.DataSource = Placeholder.reader_dataset;
                //this.dataGridName.DataMember = "Reader";

                SqlDataAdapter book_adapter = new SqlDataAdapter("select * from Book", connection);
                Placeholder.book_datatable = new DataTable();
                book_adapter.Fill(Placeholder.book_datatable);
                Console.WriteLine(Placeholder.book_datatable.Rows.Count);
                //Console.WriteLine(Placeholder.book_dataset.Tables.ToString());
                //this.dataGridBooks.DataSource = Placeholder.book_dataset;
                // this.dataGridBooks.DataMember = "Book";
                foreach(DataRow row in Placeholder.reader_datatable.Rows)
                {
                    var name = row["Nazwisko"].ToString();
                    var IDC = Convert.ToInt32(row["IDC"]);
                    var book_count = Convert.ToInt32(row["Liczba_ksiazek"]);
                    Placeholder.readers.Add(new Reader(name, IDC, book_count));
                }

                foreach (DataRow row in Placeholder.book_datatable.Rows)
                {
                    var name = row["Nazwa"].ToString();
                    var IDK = Convert.ToInt32(row["IDK"]);
                    var loaner = Convert.ToInt32(row["IDC_Wypozyczajacego"]);
                    var flag = Convert.ToBoolean(row["Dostepny"]);
                    Placeholder.books.Add(new Book(name, IDK, loaner, flag));
                }

                //for testing purposes
                //Placeholder.readers = ((BindingList<Reader>)(from DataRow dr in Placeholder.reader_datatable.Rows
                //                                             select new Reader()
                //                                             {
                //                                                 Nazwisko = dr["Nazwisko"].ToString(),
                //                                                 IDC = dr["IDC"].ToString(),
                //                                                 Liczba_ksiazek = Convert.ToInt32(dr["Liczba_ksiazek"])
                //                                             }));
                //Placeholder.readers.Count();
                //this.reader_list = Placeholder.readers.ToList();
                //Console.WriteLine(this.reader_list.Count());
                //this.reader_table = ToDataTable(this.reader_list);
                //foreach(DataColumn col in this.reader_table.Columns)
                //{
                //    Console.WriteLine(col.ColumnName);
                //}
                //Console.WriteLine(this.reader_table.TableName);
                //foreach(DataRow row in this.reader_table.Rows)
                //{
                //    foreach(var item in row.ItemArray)
                //    Console.WriteLine(item);
                //}

            }
            catch 
            {

            }
        }

        //private void saveDatabase(object sender, EventArgs e)
        //{
        //    this.reader_list = Placeholder.readers.ToList();
        //    this.book_list = Placeholder.books.ToList();
        //    this.reader_table = ToDataTable(this.reader_list);
        //    this.book_table = ToDataTable(this.book_list);

        //    foreach (DataRow row in this.reader_table.Rows)
        //    {
        //        foreach (var item in row.ItemArray)
        //            Console.WriteLine(item);
        //    }

        //    SqlConnection connection = new SqlConnection(
        //        global::library.Properties.Settings.Default.LibraryDatabaseConnectionString);

        //    connection.Open();
        //    using(SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.ConnectionString))
        //    {
        //        bulkCopy.ColumnMappings.Add("Nazwisko", "Nazwisko");
        //        bulkCopy.ColumnMappings.Add("IDC", "IDC");
        //        bulkCopy.ColumnMappings.Add("Liczba_ksiazek", "Liczba_ksiazek");
        //        /*foreach(DataColumn c in this.reader_table.Columns)
        //        {
        //            bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);
        //        }*/
        //        bulkCopy.DestinationTableName = "dbo.Reader";
        //        try
        //        {
        //            bulkCopy.WriteToServer(this.reader_table);
        //        }
        //        catch(Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }

        //    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.ConnectionString))
        //    {
        //        //foreach (DataColumn c in this.book_table.Columns)
        //        //{
        //        //    bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);
        //        //}
        //        bulkCopy.DestinationTableName = "dbo.Book";
        //        try
        //        {
        //            bulkCopy.WriteToServer(this.book_table);
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }

        //}

        //converter from list to datatable
        //public static DataTable ToDataTable<T>(List<T> items)
        //{
        //    DataTable dataTable = new DataTable(typeof(T).Name);

        //    //Get all the properties
        //    PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        //    foreach (PropertyInfo prop in Props)
        //    {
        //        //Defining type of data column gives proper data table 
        //        var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
        //        //Setting column names as Property names
        //        dataTable.Columns.Add(prop.Name, type);
        //    }
        //    foreach (T item in items)
        //    {
        //        var values = new object[Props.Length];
        //        for (int i = 0; i < Props.Length; i++)
        //        {
        //            //inserting property values to datatable rows
        //            values[i] = Props[i].GetValue(item, null);
        //        }
        //        dataTable.Rows.Add(values);
        //    }
        //    //put a breakpoint here and check datatable
        //    return dataTable;
        //}

        //private void loadFile(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serial));
        //        using (var reader = XmlReader.Create("database.xml"))
        //        {
        //            Serial data = (Serial)xmlSerializer.Deserialize(reader);
        //            Placeholder.readers = data.serialReaders;
        //            Placeholder.books = data.serialBooks;
        //        }
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        this.statusLabel.Image = Placeholder.b_error;
        //        this.statusLabel.Text = "Błąd wczytywania pliku database.xml.";
        //        return;
        //    }
        //    this.dataGridName.DataSource = Placeholder.readers;
        //    this.dataGridBooks.DataSource = Placeholder.books;
        //    this.refreshGrids();
        //}

        //private void saveFile(object sender, EventArgs e)
        //{
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serial));
        //    Serial request = new Serial(Placeholder.readers, Placeholder.books);
        //    try
        //    {
        //        using (var string_writer = new StringWriter())
        //        {
        //            using (XmlWriter writer = XmlWriter.Create("database.xml"))
        //            {
        //                xmlSerializer.Serialize(writer, request);
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return;
        //    }
        //}

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

           // Console.WriteLine(Placeholder.reader_dataset.Tables);
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

                    using(SqlConnection connection = new SqlConnection(global::library.Properties.Settings.Default.LibraryDatabaseConnectionString))
                    {
                        using(SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "UPDATE Book SET IDC_Wypozyczajacego = @var1, Dostepny = @var2 WHERE IDK = @var3";
                            command.Parameters.AddWithValue("@var1", current_book.IDC_Wypozyczajacego);
                            command.Parameters.AddWithValue("@var2", current_book.Dostepny);
                            command.Parameters.AddWithValue("@var3", current_book.IDK);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "UPDATE Reader SET Liczba_ksiazek = @var1 WHERE IDC = @var2";
                            command.Parameters.AddWithValue("@var1", current_reader.Liczba_ksiazek);
                            command.Parameters.AddWithValue("@var2", current_reader.IDC);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                }
            }
            this.statusLabel.Image = Placeholder.b_info;
            this.statusLabel.Text = string.Format("Czytelnik {0} wypożyczył ",
                current_reader.IDC);
            selectedbooks.ForEach(item => this.statusLabel.Text += string.Format("{0}, ", item.Nazwa));
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
                    current_book.IDC_Wypozyczajacego = 0;
                    current_book.Dostepny = true;
                    current_reader.Liczba_ksiazek -= 1;

                    using (SqlConnection connection = new SqlConnection(global::library.Properties.Settings.Default.LibraryDatabaseConnectionString))
                    {
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "UPDATE Book SET IDC_Wypozyczajacego = @var1, Dostepny = @var2 WHERE IDK = @var3";
                            command.Parameters.AddWithValue("@var1", current_book.IDC_Wypozyczajacego);
                            command.Parameters.AddWithValue("@var2", current_book.Dostepny);
                            command.Parameters.AddWithValue("@var3", current_book.IDK);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "UPDATE Reader SET Liczba_ksiazek = @var1 WHERE IDC = @var2";
                            command.Parameters.AddWithValue("@var1", current_reader.Liczba_ksiazek);
                            command.Parameters.AddWithValue("@var2", current_reader.IDC);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }

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
                (obj.IDC.ToString() == this.readerBox.Text));
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
                Placeholder.passed_idc = current_reader.IDC.ToString();
                BooksInfo bookInfo_window = new BooksInfo();
                bookInfo_window.Show();
                this.statusLabel.Image = Placeholder.b_info;
                this.statusLabel.Text = "Gotowy";
            }
        }

        private void readerListButton_Click(object sender, EventArgs e)
        {
            Book current_book = Placeholder.books.FirstOrDefault(obj =>
                (obj.IDK.ToString() == this.bookBox.Text));
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
                Placeholder.passed_idc = current_book.IDC_Wypozyczajacego.ToString();
                ReadersInfo readersInfo_window = new ReadersInfo();
                readersInfo_window.Show();
                this.statusLabel.Image = Placeholder.b_info;
                this.statusLabel.Text = "Gotowy";
            }
        }

        private void newReader_Click(object sender, EventArgs e)
        {
            AddReader add_reader = new AddReader();
            add_reader.Show();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            AddBook add_book = new AddBook();
            add_book.Show();
        }

        private void removeReader_Click(object sender, EventArgs e)
        {
            int rows_count = this.dataGridName.SelectedRows.Count;
            foreach (DataGridViewRow row in this.dataGridName.SelectedRows)
            {
                if (Convert.ToInt32(row.Cells[2].Value) > 0)
                {
                    this.statusLabel.Image = Placeholder.b_error;
                    this.statusLabel.Text = "Nie można usunąć czytelnika, który ma wypożyczoną książkę.";
                    continue;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(global::library.Properties.Settings.Default.LibraryDatabaseConnectionString))
                    {
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "DELETE FROM Reader WHERE IDC = @var1";
                            command.Parameters.AddWithValue("@var1", Convert.ToInt32(row.Cells[1].Value));
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }

                    Placeholder.readers.Remove((Reader)row.DataBoundItem);
                    removedInfo(rows_count);
                }
            }
        }

        private void removedInfo(int count)
        {
            this.statusLabel.Image = Placeholder.b_info;
            switch (count)
            {
                case 1:
                    this.statusLabel.Text = "Usunięto " + count + " rekord.";
                    break;
                case 2:
                    this.statusLabel.Text = "Usunięto " + count + " rekordy.";
                    break;
                case 3:
                    this.statusLabel.Text = "Usunięto " + count + " rekordy.";
                    break;
                case 4:
                    this.statusLabel.Text = "Usunięto " + count + " rekordy.";
                    break;
                default:
                    this.statusLabel.Text = "Usunięto " + count + " rekordów.";
                    break;
            }
        }

        private void removeBook_Click(object sender, EventArgs e)
        {
            int rows_count = this.dataGridBooks.SelectedRows.Count;
            foreach (DataGridViewRow row in this.dataGridBooks.SelectedRows)
            {
                if (Convert.ToBoolean(row.Cells[3].Value) == false)
                {
                    this.statusLabel.Image = Placeholder.b_error;
                    this.statusLabel.Text = "Nie można usunąć książki, która jest wypożyczona.";
                    continue;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(global::library.Properties.Settings.Default.LibraryDatabaseConnectionString))
                    {
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "DELETE FROM Book WHERE IDK = @var1";
                            command.Parameters.AddWithValue("@var1", Convert.ToInt32(row.Cells[1].Value));
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }

                    Placeholder.books.Remove((Book)row.DataBoundItem);
                    removedInfo(rows_count);
                }
            }
        }
    }
}
