using ExcelDataReader;
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

namespace excel_reader
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void sheetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Placeholder.currentTable = Placeholder.tableCollection[this.sheetCombo.SelectedItem.ToString()];
            this.prepareData();
            this.showTable.Enabled = true;
            this.showChart.Enabled = true;
            //this.dataGridView1.DataSource = Placeholder.currentTable;
            //this.dataGridView1.Columns[0].HeaderText = "Lotnisko";
            //this.dataGridView1.Columns[1].HeaderText = "Pasażerowie";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Open Workbook";
                dialog.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    using(var stream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet data = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = false}
                            });
                            Placeholder.tableCollection = data.Tables;
                            this.sheetCombo.Items.Clear();
                            foreach(DataTable table in Placeholder.tableCollection)
                            {
                                this.sheetCombo.Items.Add(table.TableName);
                            }
                            this.sheetCombo.SelectedIndex = 0;
                            this.filenameStrip.Text = string.Format("Plik: {0}", dialog.FileName);
                        }
                    }
                }    
            }
        }

        private void prepareData()
        {
            int all_passengers = 0;
            int index = 1;

            this.removeEmpty();

            Placeholder.currentTable.Columns[0].ColumnName = "Lotnisko";
            Placeholder.currentTable.Columns[1].ColumnName = "Pasażerowie";
            Placeholder.currentTable.Columns.Add("Indeks", typeof(System.Int32)).SetOrdinal(0);
            Placeholder.currentTable.Columns.Add("Procent", typeof(System.Double));

            foreach(DataRow row in Placeholder.currentTable.Rows)
            {
                int passengers = 0;
                try
                {
                    passengers = Convert.ToInt32(string.Concat(row.Field<string>(2).Where(c => !Char.IsWhiteSpace(c))));
                }
                catch(Exception)
                {
                    passengers = Convert.ToInt32(row.ItemArray[2]);
                }
                all_passengers += passengers;
            }

            foreach(DataRow row in Placeholder.currentTable.Rows)
            {
                int passengers = 0;
                try
                {
                    passengers = Convert.ToInt32(string.Concat(row.Field<string>(2).Where(c => !Char.IsWhiteSpace(c))));
                }
                catch (Exception)
                {
                    passengers = Convert.ToInt32(row.ItemArray[2]);
                }
                row["Procent"] = Convert.ToDouble(passengers) / Convert.ToDouble(all_passengers) * 100;
                row["Indeks"] = index;
                index++;
            }
        }

        private void removeEmpty()
        {
            Placeholder.currentTable = Placeholder.currentTable.Rows.Cast<DataRow>()
                .Where(row => !row.ItemArray.All(field => field is DBNull ||
                string.IsNullOrWhiteSpace(field as string))).CopyToDataTable();

            foreach(var col in Placeholder.currentTable.Columns.Cast<DataColumn>().ToArray())
            {
                if(Placeholder.currentTable.AsEnumerable().All(row => row.IsNull(col)))
                {
                    Placeholder.currentTable.Columns.Remove(col);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sheetCombo.SelectedItem = null;
            this.sheetCombo.SelectedText = "Wybierz arkusz";
        }

        private void showTable_Click(object sender, EventArgs e)
        {
            Table table_window = new Table();
            table_window.Show();
        }

        private void showChart_Click(object sender, EventArgs e)
        {
            Chart chart_window = new Chart();
            chart_window.Show();
        }
    }
}
