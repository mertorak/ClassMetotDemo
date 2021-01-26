using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Ad = "Mert";
            customer1.Soyad = "Orak";
            customer1.Meslek = "Software Developer";
            customer1.Id = 1; 


            Customer customer2 = new Customer();
            customer2.Ad = "Berk";
            customer2.Soyad = "Orak";
            customer2.Meslek = "Ogrenci";
            customer2.Id = 2;

            Customer customer3 = new Customer();
            customer3.Ad = "Maral";
            customer3.Soyad = "Orak";
            customer3.Meslek = "Kimyager";
            customer3.Id = 3;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekleme(customer1);
            Console.WriteLine("-----");
            customerManager.Listeleme(customer2);
            Console.WriteLine("-----");
            customerManager.Silme(customer3);

        }
    }
}
