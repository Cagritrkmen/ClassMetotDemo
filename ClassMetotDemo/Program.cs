using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Ahmet";
            customer1.CustomerSurname = "Türkmen";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Ayşe";
            customer2.CustomerSurname = "Türkmen";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Çağrı";
            customer3.CustomerSurname = "Türkmen";

            
            
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("....................Ekleme İşlemi................");

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("----------------------Listeleme İşlemi ----------");

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (Customer customer in customers)
            {
                customerManager.List(customer);
            }

            Console.WriteLine("***********Silme İşlemi**********");


            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);

            Console.Read();





        }
    }
}
