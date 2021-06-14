using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starting_with_HashTables.Components
{
    struct Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string talent { get; set; }

        public Student(string name, int age, string talent)
        {
            this.name = name;
            this.age = age;
            this.talent = talent;
        }
    }
}
