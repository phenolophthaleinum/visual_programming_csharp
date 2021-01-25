using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace student_database
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Placeholder.main = this;
            this.DoubleBuffered = true;
            this.Load += new EventHandler(this.loadFile);
            this.FormClosing += new FormClosingEventHandler(this.saveFile);
            this.dataGrid.DataSource = Placeholder.students;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Add add_window = new Add();
            add_window.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(this.semesterBox.Text, @"^([1-9]|10)$") && this.semesterBox.Text.Length > 0)
            {
                Placeholder.filter_value = this.semesterBox.Text.ToString();
                this.doneInfo();
                Search search_window = new Search();
                search_window.Show();
            }
            else
            {
                this.labelStrip.Image = Placeholder.b_error;
                this.labelStrip.Text = "Numer semestru musi być z zakresu 1-10.";
            }
        }
        public void updateGrid()
        {
            this.dataGrid.DataSource = Placeholder.students;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int rows_count = this.dataGrid.SelectedRows.Count;
            foreach (DataGridViewRow row in this.dataGrid.SelectedRows)
            {
                Placeholder.students.Remove((Student)row.DataBoundItem);
            }
            this.removedInfo(rows_count);
        }

        private void saveFile(object sendel, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serial));
            Serial request = new Serial(Placeholder.students);
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

        private void loadFile(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serial));
                using (var reader = XmlReader.Create("database.xml"))
                {
                    Serial data = (Serial)xmlSerializer.Deserialize(reader);
                    Placeholder.students = data.serialStudents;
                    this.updateGrid();
                }
            }
            catch (FileNotFoundException)
            {
                return;
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            Placeholder.main.labelStrip.Image = Placeholder.b_info;
            switch (this.dataGrid.SelectedRows.Count)
            {
                case 1:
                    this.labelStrip.Text = "Zaznaczono " + this.dataGrid.SelectedRows.Count + " wiersz.";
                    break;
                case 2:
                    this.labelStrip.Text = "Zaznaczono " + this.dataGrid.SelectedRows.Count + " wiersze.";
                    break;
                case 3:
                    this.labelStrip.Text = "Zaznaczono " + this.dataGrid.SelectedRows.Count + " wiersze.";
                    break;
                case 4:
                    this.labelStrip.Text = "Zaznaczono " + this.dataGrid.SelectedRows.Count + " wiersze.";
                    break;
                default:
                    this.labelStrip.Text = "Zaznaczono " + this.dataGrid.SelectedRows.Count + " wierszy.";
                    break;
            }
        }

        private void removedInfo(int count)
        {
            Placeholder.main.labelStrip.Image = Placeholder.b_info;
            switch (count)
            {
                case 1:
                    this.labelStrip.Text = "Usunięto " + count + " wiersz.";
                    break;
                case 2:
                    this.labelStrip.Text = "Usunięto " + count + " wiersze.";
                    break;
                case 3:
                    this.labelStrip.Text = "Usunięto " + count + " wiersze.";
                    break;
                case 4:
                    this.labelStrip.Text = "Usunięto " + count + " wiersze.";
                    break;
                default:
                    this.labelStrip.Text = "Usunięto " + count + " wierszy.";
                    break;
            }
        }
        public void doneInfo()
        {
            this.labelStrip.Image = Placeholder.b_info;
            this.labelStrip.Text = "Gotowy";
        }
    }
}
