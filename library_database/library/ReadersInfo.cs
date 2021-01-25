using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class ReadersInfo : Form
    {
        public ReadersInfo()
        {
            InitializeComponent();
        }

        private void ReadersInfo_Load(object sender, EventArgs e)
        {
            this.nameLabel.Text = Placeholder.books.FirstOrDefault(obj => 
            (obj.IDC_Wypozyczajacego.ToString() == Placeholder.passed_idc)).Nazwa;
            if(Placeholder.passed_idk == true)
            {
                this.readersListBox.Show();
            }
            else
            {
                this.readersListBox.Items.Add(Placeholder.readers.FirstOrDefault(obj =>
                (obj.IDC.ToString() == Placeholder.passed_idc)).Nazwisko);
            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
