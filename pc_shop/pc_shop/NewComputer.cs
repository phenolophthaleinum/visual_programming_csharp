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
    public partial class NewComputer : Form
    {
        //public List<CPU> cpus;
       // private MainWindow mainWindow;
        public Dictionary<string, Drive> drives = new Dictionary<string, Drive>();

        public NewComputer()
        {
            InitializeComponent();
            //this.cpus = main_window.cpu_list;
            //this.mainWindow = main_window;
            this.drives.Add("240 GB SSD", new Drive("240 GB SSD", 150.99));
            this.drives.Add("500 GB SATA", new Drive("500 GB SATA", 90.69));
            this.drives.Add("1000 GB SATA", new Drive("1000 GB SATA", 145));
            this.populateCPU();

            this.cpuBox.TextChanged += priceChange;
            this.driveBox.TextChanged += priceChange;
        }

        private void populateCPU()
        {
            foreach(CPU cpu in Placeholder.cpu_list)
            {
                if(this.cpuCombo.Items.Contains(cpu) != true)
                {
                    this.cpuCombo.Items.Add(cpu);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Checked)
            {
                this.driveBox.Text = this.drives[radio.Text].Price.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Checked)
            {
                this.driveBox.Text = this.drives[radio.Text].Price.ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Checked)
            {
                this.driveBox.Text = this.drives[radio.Text].Price.ToString();
            }
        }

        private void cpuCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected_cpu = (CPU)this.cpuCombo.SelectedItem;
            this.cpuBox.Text = selected_cpu.Price.ToString();
        }

        private void priceChange(object sender, EventArgs e)
        {
            double price_cpu, price_drive;
            if (this.cpuBox.Text.Length != 0 && this.driveBox.Text.Length != 0)
            {
                price_cpu = double.Parse(this.cpuBox.Text);
                price_drive = double.Parse(this.driveBox.Text);
            }
            else
            {
                return;
            }
            this.sumBox.Text = (price_cpu + price_drive).ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                Placeholder.current_price += double.Parse(this.sumBox.Text);
            }
            catch (FormatException)
            {
                SystemSounds.Exclamation.Play();
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Proszę wybrać procesor i dysk";
                return;
            }
            Placeholder.main.priceUpdate();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
