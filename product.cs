using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsolationTasks
{
    internal class product
    {
        public int nproduct { set; get; }
        public string name { set; get; }
        public decimal price { set; get; }

        public product(int nproduct, string name, decimal price)
        {
            this.nproduct = nproduct;
            this.name = name;
            this.price = price;
        }

        public decimal discounted(decimal amount)
        {
            amount = this.price -((amount/100)*this.price);
            return amount;
        }

        public void getInformation()
        {
            Console.WriteLine(this.name + " " + this.nproduct +" " + this.price );
        }

    }
}
