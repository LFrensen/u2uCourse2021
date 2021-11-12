using System;

namespace U2UPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Object initialization
            Person filip = new Person() { Name = "Filip", Gender = GenderType.Male, Age = 52 };
            Person albert = new Person() { Name = "Albert", Age = 73 };
            Person liz = new Person() { Name = "Liz", Gender = GenderType.Female };

            // Using constructor
            Person jack = new Person("Jack Walker", 76);
            Person johnny = new Person("Johhny Daniels", 17, GenderType.Male);
            Person ben = new Person("Ben Navis", 24, GenderType.Female);
            Console.WriteLine(jack.GetInfo());
            Console.WriteLine(johnny.GetInfo());
            Console.WriteLine(ben.GetInfo());

            Excercise_4 e = new Excercise_4();
            Console.WriteLine(Excercise_4.CapitalizeEachWord("Hello World"));

            Employee e1 = new Employee("Henk", 24, GenderType.Male, "TJIP");
            Console.WriteLine(e1.GetInfo());

            Person p4 = new Person("Wim", 35);
            Person p5 = new Person("Wim", 35);
            Person p6 = new Person("Jim", 35);
            Employee e2 = new Employee("Wim", 35, "U2U");

            if (p4.Equals(p5))
            {
                Console.WriteLine("p4 is equal to p5");
            }
            else
            {
                Console.WriteLine("Objects are not equal");
            }
            if(p4.Equals(p6))
            {
                Console.WriteLine("p4 is equal to p6");
            } else
            {
                Console.WriteLine("Objects are not equal");
            }
            if(p4.Equals(e2))
            {
                Console.WriteLine("p4 is equal to e2");
            }
            else
            {
                Console.WriteLine("Objects are not equal");
            }

            Person[] people =
            {
                new Person("Ted Mosby", 27, GenderType.Male),
                new Person("Robin Scherbatsky", 23, GenderType.Female),
                new Person("Barney Stinson", 29, GenderType.Male),
                new Person("Lily Aldrin", 27, GenderType.Female),
                new Person("Marshall Eriksen", 27, GenderType.Male)
            };

            Array.Sort(people);
            foreach (Person p in people)
            {
                Console.WriteLine(p.GetInfo());
            }

        }
    }
}
