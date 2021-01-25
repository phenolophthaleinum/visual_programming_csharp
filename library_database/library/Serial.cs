using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    [Serializable]
    public class Serial
    {
        public BindingList<Reader> serialReaders { get; set; }
        public BindingList<Book> serialBooks { get; set; }

        public Serial(BindingList<Reader> readers, BindingList<Book> books)
        {
            this.serialReaders = readers;
            this.serialBooks = books;
        }

        public Serial() { }
    }
}
