using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pc_shop
{
    public partial class NewMonitor : Form
    {
        //private MainWindow mainWindow;
        public NewMonitor()
        {
            InitializeComponent();
            //this.mainWindow = main_window;
            this.populateMonitor();
        }

        private void monitorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sumBox.Text = ((Monitor)this.monitorsListBox.SelectedItem).Price.ToString();
            }
            catch(NullReferenceException)
            {
                return;
            }
        }

        private void populateMonitor()
        {
            foreach (Monitor monitor in Placeholder.monitor_list)
            {
                if (this.monitorsListBox.Items.Contains(monitor) != true)
                {
                    monitorsListBox.Items.Add(monitor);
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(this.monitorsListBox.SelectedItem == null)
            {
                SystemSounds.Exclamation.Play();
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Proszę wybrać monitor z listy";
                return;
            }
            Placeholder.current_price += double.Parse(this.sumBox.Text);
            Placeholder.main.priceUpdate();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
