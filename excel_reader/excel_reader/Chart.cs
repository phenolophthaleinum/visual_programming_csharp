using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel_reader
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
            this.chart1.DataSource = Placeholder.currentTable;
            this.chart1.Series.Add("Procent pasażerów");
            this.chart1.Series["Procent pasażerów"].XValueMember = "Indeks";
            this.chart1.Series["Procent pasażerów"].YValueMembers = "Procent";
            this.chart1.Titles.Add("Udział lotnisk w liczbie pasażerów w Polsce");
        }
    }
}
