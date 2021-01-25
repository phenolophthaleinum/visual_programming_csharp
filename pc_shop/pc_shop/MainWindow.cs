using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace pc_shop
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            Placeholder.main = this;
            this.Load += new EventHandler(this.loadFile);
            this.FormClosing += new FormClosingEventHandler(this.saveFile);
        }

        private void monitorButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Placeholder.current_price);
            NewMonitor monitor_window = new NewMonitor();
            monitor_window.Show();
        }

        private void computerButton_Click(object sender, EventArgs e)
        {
            NewComputer computer_window = new NewComputer();
            computer_window.Show();
        }

        private void cpu_updateButton_Click(object sender, EventArgs e)
        {
            UpdateCPU cpu_window = new UpdateCPU();
            cpu_window.Show();
        }

        private void monitor_updateButton_Click(object sender, EventArgs e)
        {
            UpdateMonitor mon_update_window = new UpdateMonitor();
            mon_update_window.Show();
        }

        public void priceUpdate()
        {
            this.priceBox.Text = Placeholder.current_price.ToString();
        }

        private void saveFile(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serial));
            Serial request = new Serial(Placeholder.cpu_list, Placeholder.monitor_list);
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
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serial));
            try
            {
                using (var reader = XmlReader.Create("database.xml"))
                {
                    Serial data = (Serial)xmlSerializer.Deserialize(reader);
                    Placeholder.cpu_list = data.CPUs;
                    Placeholder.monitor_list = data.Monitors;
                }
            }
            catch (FileNotFoundException)
            {
                return;
            }
        }
    }
}
