using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsolationTasks
{
    internal class Person
    {
        public string name { get;  }
        public int age { get; }
        public string iadress { get; set; }

        public Person (string name, int age, string iadress)
        {
            this.name = name;
            this.age = age;
            this.iadress = iadress;
        } 

        

    }

    

}
