using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public static class Placeholder
    {
        public static MainWindow main = default;
        public static string passed_idc = null;
        public static bool passed_idk = default;
        public static BindingList<Reader> readers = new BindingList<Reader>()
        {
            new Reader("Dudczak", "R1", 0),
            new Reader("Wróbel", "R2", 0),
            new Reader("Brumbel", "R3", 0),
        };
        public static BindingList<Book> books = new BindingList<Book>()
        { 
            new Book("Jądro ciemności", "B1", null, true),
            new Book("Tango", "B2", null, true),
            new Book("Ferdydurke", "B3", null, true),
        };

        public static Bitmap b_info = SystemIcons.Information.ToBitmap();
        public static Bitmap b_error = SystemIcons.Error.ToBitmap();
        public static Bitmap b_warn = SystemIcons.Exclamation.ToBitmap();
    }
}
