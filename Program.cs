namespace EncapsolationTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ahmed ", 24, "Sinaw");
            Console.Write(p1.name + " " + p1.age + " " + p1.iadress);
            p1.iadress = "Muscat";// it is can be setted to auther addres due to the definition in the class
            //p1.age = 24;//it cant be re setted becouse it identifyed as get read only
            Console.WriteLine();
            Console.Write(p1.name + " " + p1.age + " " + p1.iadress);
            Console.WriteLine();
            Console.WriteLine("******************** Bank account *****************");//Q2

            BankAccount account1 = new BankAccount(" 0012034829001 ", 2460);
            Console.WriteLine(" The account Number " + account1.AccountNumber + " have " + account1.Balance + " After desposit = " + account1.deposit(31));
            Console.WriteLine(" The account Number " + account1.AccountNumber + " have " + account1.Balance + " After Withdraw = " + account1.withdraw(450));

            Console.WriteLine();
            Console.WriteLine("******************** Rectangle  *****************");//Q3

            Rectangle R1 = new Rectangle(29, 14);
            Console.WriteLine(" The area of Rectangle = " + R1.areaRectangle());

            Console.WriteLine();
            Console.WriteLine("******************** Employee   *****************");//Q4

            Employee Em1 = new Employee(" Mohammed Al-Maamari ", 2333212, " cluthes Designer ", " 1000 ");
            Em1.getInformation();
            Em1.position = " senior ENG ";
            Em1.salary = " 4890 ";
            Em1.getInformation();

            Console.WriteLine();
            Console.WriteLine("******************** Product   *****************");//Q5

            product P1 = new product(22, " iphon pro 11 ", 398);
            P1.getInformation();
            Console.WriteLine(" after discounting = "+P1.discounted(31));
            P1.getInformation();
        }
    }
}