using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    [Serializable]
    public class Reader : IEquatable<Reader>
    {
        private string name;
        private int id;
        private int books_num;

        public Reader(string name, int id, int books_num)
        {
            Nazwisko = name;
            IDC = id;
            Liczba_ksiazek = books_num;
        }

        public Reader() { }

        public string Nazwisko
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int IDC
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int Liczba_ksiazek
        {
            get
            {
                return books_num;
            }
            set
            {
                books_num = value;
            }
        }

        //public virtual ICollection<Book> Ksiazki { get; set; }

        public bool Equals(Reader other)
        {
            if (Object.ReferenceEquals(other, null)) return false;
            if (Object.ReferenceEquals(this, other)) return true;
            return name.Equals(other.name);
        }

        public override int GetHashCode()
        {

            //Get hash code for the Name field if it is not null.
            int hashProductName = name == null ? 0 : name.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductName;
        }
    }
}
