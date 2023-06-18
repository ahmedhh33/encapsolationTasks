using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsolationTasks
{
    internal class Employee
    {
        public string name { get; }
        public int id { get; }
        public string position { get; set; }
        public string salary { get; set; }

        public Employee(string name , int id , string position , string salary) 
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public void getInformation()
        {
            Console.WriteLine(this.name+this.id+this.position+this.salary);
        }
    }
}
