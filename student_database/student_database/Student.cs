using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_database
{
    [Serializable]
    public class Student
    {
        private string name;
        private string semester;

        public Student(string name, string semester)
        {
            Name = name;
            Semester = semester;
        }

        public Student() { }

        public string Name
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
        public string Semester
        {
            get
            {
                return semester;
            }
            set
            {
                semester = value;
            }
        }
    }
}
