using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_shop
{
    [Serializable]
    public class Serial
    {
        public List<CPU> CPUs { get; set; }
        public List<Monitor> Monitors { get; set; }

        public Serial(List<CPU> cpus, List<Monitor> monitors)
        {
            this.CPUs = cpus;
            this.Monitors = monitors;
        }


        public Serial() { }
    }
}
