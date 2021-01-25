using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    [Serializable]
    public class Book
    {
        private string name;
        private int id;
        private int loaner_id;
        private bool isAvalible;

        public Book(string name, int id, int loaner_id, bool flag)
        {
            Nazwa = name;
            IDK = id;
            IDC_Wypozyczajacego = loaner_id;
            Dostepny = flag;
        }

        public Book() { }

        public string Nazwa
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

        public int IDK
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

        public int IDC_Wypozyczajacego
        {
            get
            {
                return loaner_id;
            }
            set
            {
                loaner_id = value;
            }
        }

        public bool Dostepny
        {
            get
            {
                return isAvalible;
            }
            set
            {
                isAvalible = value;
            }
        }

        //public virtual Reader Wypozyczajacy { get; set; }

        /*public override string ToString()
        {
            return id;
        }*/
    }
}
