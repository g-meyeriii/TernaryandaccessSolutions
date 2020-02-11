using System;

namespace Ternaryandaccess {
    public class Program {


        static void Main(string[] args) { 

            Console.WriteLine($"The cube of 17 is { Cubed(17)}");
            //var message = Customer.PrintNextId();

            //Console.WriteLine(ToString);

            var cust1 = new Customer("Max Tech Training");
            Console.WriteLine(cust1);
            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Target");

            cust1.NationalAccount("yes");

            var order1 = new Order { Amount = 1000, customer = cust1 };
            var order2 = new Order { Amount = 1000, customer = cust1 };


            static int Cubed(int nbr) {
                return nbr * nbr * nbr;


            }
        }
    }
}
