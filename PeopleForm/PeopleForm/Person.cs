using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleForm
{
    [Serializable]
    class Person
    {
        public string name;
        public string last_name;
        public string position;
        //public enum Position { student = 0, professor = 1, doctor = 2, other = 3 };
        public string sex;
        public int birth;
        public Person(string in_name, string in_last, string in_pos, string in_sex, string in_birth)
        {
            this.name = in_name;
            this.last_name = in_last;
            this.position = in_pos;
            this.sex = in_sex;
            this.birth = int.Parse(in_birth);
        }
    }
}
