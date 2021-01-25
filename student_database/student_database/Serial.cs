using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_database
{
    [Serializable]
    public class Serial
    {
        public BindingList<Student> serialStudents { get; set; }

        public Serial(BindingList<Student> students)
        {
            this.serialStudents = students;
        }

        public Serial() { }
    }
}
