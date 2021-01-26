using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekleme(Customer customer)
        {
            Console.WriteLine(customer.Ad + " adlı müşteri eklendi. Yeni müşterimizin mesleği: " + customer.Meslek );
        }
        public void Silme(Customer customer)
        {
            Console.WriteLine(customer.Ad + " adlı müşteri silindi");
        }
        public void Listeleme(Customer customer)
        {
            Console.WriteLine("Müşterinin adı:"+ customer.Ad);
            Console.WriteLine("Müşterinin soyadı:"+ customer.Soyad);
            Console.WriteLine("Müşterinin ID'si:"+ customer.Id);
            Console.WriteLine("Müşteri mesleği:"+ customer.Meslek);
        }

    }
}
