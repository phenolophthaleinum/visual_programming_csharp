using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace student_database
{
    public static class Placeholder
    {
        public static MainWindow main = default;
        public static string filter_value = null;
        public static BindingList<Student> students = new BindingList<Student>()
        {
            new Student("Kowalski", "2"),
            new Student("Wróbel", "8")
        };

        public static Bitmap b_info = SystemIcons.Information.ToBitmap();
        public static Bitmap b_error = SystemIcons.Error.ToBitmap();
    }
}
