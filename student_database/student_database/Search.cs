using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_database
{
    public partial class Search : Form
    {
        List<Student> filteredStudents = new List<Student>();
        public Search()
        {
            InitializeComponent();
            showFiltered();
            this.filteredGrid.DataSource = this.filteredStudents;
        }

        private void showFiltered()
        {
            foreach (Student student in Placeholder.students)
            {
                if(student.Semester == Placeholder.filter_value)
                {
                    this.filteredStudents.Add(student);
                }
            }
            this.searchedInfo(this.filteredStudents.Count);
        }

        private void searchedInfo(int count)
        {
            this.labelStatus.Image = Placeholder.b_info;
            switch (count)
            {
                case 1:
                    this.labelStatus.Text = "Znaleziono " + count + " wiersz.";
                    break;
                case 2:
                    this.labelStatus.Text = "Znaleziono " + count + " wiersze.";
                    break;
                case 3:
                    this.labelStatus.Text = "Znaleziono " + count + " wiersze.";
                    break;
                case 4:
                    this.labelStatus.Text = "Znaleziono " + count + " wiersze.";
                    break;
                default:
                    this.labelStatus.Text = "Znaleziono " + count + " wierszy.";
                    break;
            }
        }
    }
}
