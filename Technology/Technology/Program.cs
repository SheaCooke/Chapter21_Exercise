using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer test = new Computer("2020", "Iphone", "Apple");
            Computer test2 = new Computer("2020", "Iphone", "Apple");
            Laptop ltTest = new Laptop("user", "2020", "Macbook", "Apple");
            Smartphone smTest = new Smartphone("user", "2021", "Iphone", "Apple");

            test.UseEmail();

            Laptop laptopTest = new Laptop("user", "2020", "mac", "Apple");

            laptopTest.UseEmail();

            Console.WriteLine(test.Id);
            Console.WriteLine(test2.Id);
            Console.WriteLine(ltTest.Id);
            Console.WriteLine(smTest.Id);
        }
    }
}
