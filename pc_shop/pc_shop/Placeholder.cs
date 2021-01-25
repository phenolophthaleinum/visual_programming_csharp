using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;

namespace pc_shop
{
    public static class Placeholder
    {
        public static MainWindow main = default;
        public static double current_price = 0;
        public static List<CPU> cpu_list = new List<CPU>()
        {
            new CPU("i7-4790", 1400.99),
            new CPU("AMD Ryzen 5 3600", 1100),
            new CPU("i9-10900K", 2500)
        };
        public static List<Monitor> monitor_list = new List<Monitor>()
        {
            new Monitor("Iiyama", 1000),
            new Monitor("AOC", 899.99),
            new Monitor("BenQ", 1234.99)
        };

        public static Bitmap b_exclam = SystemIcons.Exclamation.ToBitmap();
        public static Bitmap b_error = SystemIcons.Error.ToBitmap();
        public static Bitmap b_info = SystemIcons.Information.ToBitmap();
    }
}
