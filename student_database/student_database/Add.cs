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

namespace student_database
{
    public partial class Add : Form
    {
        public Add()
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
                    string semester_value = row.Cells[1].Value.ToString();
                    Placeholder.students.Add(new Student(name_value, semester_value));
                }
                else
                {
                    this.labelStatus.Image = Placeholder.b_error;
                    this.labelStatus.Text = "Proszę uzupełnić wszystkie pola.";
                    return;

                }
            }
            this.addedInfo(this.data_addGrid.Rows.Count - 1);
            Console.WriteLine(Placeholder.students.Count);
        }

        private void data_addGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch(e.ColumnIndex)
            {
                case 0:
                    if (!Regex.IsMatch(e.FormattedValue.ToString(), @"[A-Za-z]"))
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
                    else if (Convert.ToInt32(e.FormattedValue) > 10 || Convert.ToInt32(e.FormattedValue) <= 0)
                    {
                        e.Cancel = true;
                        this.labelStatus.Image = Placeholder.b_error;
                        this.labelStatus.Text = "Proszę wpisać wartość numeryczną z zakresu 1-10.";
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

        public void addedInfo(int count)
        {
            this.labelStatus.Image = Placeholder.b_info;
            switch (count)
            {
                case 1:
                    this.labelStatus.Text = "Dodano " + count + " wiersz.";
                    break;
                case 2:
                    this.labelStatus.Text = "Dodano " + count + " wiersze.";
                    break;
                case 3:
                    this.labelStatus.Text = "Dodano " + count + " wiersze.";
                    break;
                case 4:
                    this.labelStatus.Text = "Dodano " + count + " wiersze.";
                    break;
                default:
                    this.labelStatus.Text = "Dodano " + count + " wierszy.";
                    break;
            }
        }
    }
}
