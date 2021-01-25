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
    public partial class AddReader : Form
    {
        public AddReader()
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
                    int idc_value = Convert.ToInt32(row.Cells[1].Value);
                    foreach(Reader r in Placeholder.readers)
                    {
                        if(r.IDC == idc_value)
                        {
                            this.labelStatus.Image = Placeholder.b_error;
                            this.labelStatus.Text = "Czytelnik od danym ID już istnieje.";
                            return;
                        }
                    }
                    Placeholder.readers.Add(new Reader(name_value, idc_value, 0));
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nazwisko", typeof(string));
                    dt.Columns.Add("IDC", typeof(int));
                    dt.Columns.Add("Liczba_ksiazek", typeof(int));
                    var reader = Placeholder.readers.Last();
                    DataRow dr = dt.NewRow();
                    dr["Nazwisko"] = reader.Nazwisko;
                    dr["IDC"] = reader.IDC;
                    dr["Liczba_ksiazek"] = reader.Liczba_ksiazek;
                    dt.Rows.Add(dr);

                    SqlConnection connection = new SqlConnection(
                global::library.Properties.Settings.Default.LibraryDatabaseConnectionString);

                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.ConnectionString))
                    {
                        connection.Open();
                        bulkCopy.ColumnMappings.Add("Nazwisko", "Nazwisko");
                        bulkCopy.ColumnMappings.Add("IDC", "IDC");
                        bulkCopy.ColumnMappings.Add("Liczba_ksiazek", "Liczba_ksiazek");
                        /*foreach(DataColumn c in this.reader_table.Columns)
                        {
                            bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);
                        }*/
                        bulkCopy.DestinationTableName = "dbo.Reader";
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
                        this.labelStatus.Text = "Dodano osobę.";
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
                    if (!Regex.IsMatch(e.FormattedValue.ToString(), @"^[\p{L} ]+$"))
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
