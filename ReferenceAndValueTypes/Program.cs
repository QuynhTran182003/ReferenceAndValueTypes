using System.Security.Cryptography;

namespace ReferenceAndValueTypes
{
    internal class Program
    {
        class Person
        {
            public int Id { get; set; }

            public Person(int id)
            {
                Id = id;
            }
        }

        static void Main(string[] args)
        {
            // Value Type
            int z = 10;
            int x = z;
            Console.WriteLine($"x = {x}, z={z}"); //x = 10, z = 10

            z = 30;
            Console.WriteLine($"x = {x}, z={z}"); //x = 10, z = 30

            x = 20;
            Console.WriteLine($"x = {x}, z={z}"); //x = 20, z = 30


            // Reference Type
            Person p = new Person(1);
            Person p2 = p;

            Console.WriteLine($"{p.Id}, {p2.Id}"); // 1, 1
            Console.WriteLine(p2 == (p)); // True

            p2.Id = 33;
            Console.WriteLine($"{p.Id}, {p2.Id}"); // 33, 33
            Console.WriteLine(p2 == (p)); // True, cus it references to the same object

            p = new Person(3);
            Console.WriteLine($"{p.Id}, {p2.Id}"); // 3, 33
            Console.WriteLine(p2 == (p)); // False

            p2 = new Person(2);
            Console.WriteLine($"{p.Id}, {p2.Id}");// 3, 2
            Console.WriteLine(p2 == (p)); // False
        }
    }
}