using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.data_addGrid.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string name_value = row.Cells[0].Value.ToString();
                    int idk_value = Convert.ToInt32(row.Cells[1].Value);
                    foreach (Book b in Placeholder.books)
                    {
                        if (b.IDK == idk_value)
                        {
                            this.labelStatus.Image = Placeholder.b_error;
                            this.labelStatus.Text = "Książka o danym ID już istnieje.";
                            return;
                        }
                    }
                    Placeholder.books.Add(new Book(name_value, idk_value, 0, true));
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nazwa", typeof(string));
                    dt.Columns.Add("IDK", typeof(int));
                    dt.Columns.Add("IDC_Wypozyczajacego", typeof(int));
                    dt.Columns.Add("Dostepny", typeof(bool));
                    var book = Placeholder.books.Last();
                    DataRow dr = dt.NewRow();
                    dr["Nazwa"] = book.Nazwa;
                    dr["IDK"] = book.IDK;
                    dr["IDC_Wypozyczajacego"] = book.IDC_Wypozyczajacego;
                    dr["Dostepny"] = book.Dostepny;
                    dt.Rows.Add(dr);

                    SqlConnection connection = new SqlConnection(
                global::library.Properties.Settings.Default.LibraryDatabaseConnectionString);

                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.ConnectionString))
                    {
                        connection.Open();
                        bulkCopy.ColumnMappings.Add("Nazwa", "Nazwa");
                        bulkCopy.ColumnMappings.Add("IDK", "IDK");
                        bulkCopy.ColumnMappings.Add("IDC_Wypozyczajacego", "IDC_Wypozyczajacego");
                        bulkCopy.ColumnMappings.Add("Dostepny", "Dostepny");
                        /*foreach(DataColumn c in this.reader_table.Columns)
                        {
                            bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);
                        }*/
                        bulkCopy.DestinationTableName = "dbo.Book";
                        try
                        {
                            bulkCopy.WriteToServer(dt);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        connection.Close();
                        this.labelStatus.Image = Placeholder.b_info;
                        this.labelStatus.Text = "Dodano książkę.";
                    }
                }
                else
                {
                    this.labelStatus.Image = Placeholder.b_error;
                    this.labelStatus.Text = "Proszę uzupełnić wszystkie pola.";
                    return;

                }
            }
        }

        private void data_addGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    if (!Regex.IsMatch(e.FormattedValue.ToString(), @"^[\p{L} ]*$"))
                    {
                        e.Cancel = true;
                        this.labelStatus.Image = Placeholder.b_error;
                        this.labelStatus.Text = "Proszę wpisać litery.";
                    }
                    break;
                case 1:
                    int i;
                    if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                    {
                        e.Cancel = true;
                        this.labelStatus.Image = Placeholder.b_error;
                        this.labelStatus.Text = "Proszę wpisać wartość numeryczną.";
                    }
                    else if (Convert.ToInt32(e.FormattedValue) < 1)
                    {
                        e.Cancel = true;
                        this.labelStatus.Image = Placeholder.b_error;
                        this.labelStatus.Text = "Proszę wpisać wartość numeryczną większą od 1.";
                    }
                    break;
                default:
                    e.Cancel = false;
                    break;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = false;
        }
    }
}
