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
    public partial class BooksInfo : Form
    {
        public BooksInfo()
        {
            InitializeComponent();
        }

        private void BooksInfo_Load(object sender, EventArgs e)
        {
            this.nameLabel.Text = Placeholder.readers.FirstOrDefault(obj =>
            (obj.IDC.ToString() == Placeholder.passed_idc)).Nazwisko;
            foreach(Book book in Placeholder.books)
            {
                if(book.IDC_Wypozyczajacego.ToString() == Placeholder.passed_idc)
                {
                    this.booksListBox.Items.Add(book.Nazwa);
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
