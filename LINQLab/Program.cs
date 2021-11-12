using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LINQLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nrs = { 1, 2, 3, 4 };
            Console.WriteLine(5.ToUpperString());
            Console.WriteLine("jefke".ToUpperString().Reverse());
            nrs.Dump();
            Console.WriteLine(5.ConvertTo<double>());

            List<Person> people = new List<Person>()
            {
                new Person { Name = "Bob", Age = 27 },
                new Person { Name = "Priyanka", Age = 37 },
                new Person { Name = "Limei", Age = 12 },
                new Person { Name = "Robin", Age = 13 },
                new Person { Name = "Kaushal", Age = 26 }
            };
            var byMethodCall = people.FindAll(p => OlderOrEqualTo18(p));
            var byAnonymousMEthodSyntax = people.FindAll(delegate (Person pers) { return pers.Age >= 18; });
            var byLambdaCall = people.FindAll(p => p.Age >= 18);

            Point[] points =
            {
                new Point(1, 2),
                new Point(3, 4),
                new Point(4, 5),
                new Point(5, 6)
            };
            Array.ForEach(points, PrintPoints);
            int value = 1;
            Predicate<Point> criteria = delegate (Point p)
            {
                if (p.X > value && p.Y > value)
                { return true; }
                return false;
            };
            Point findCriteria = Array.Find<Point>(points, criteria);
            Console.WriteLine($"Answer: {findCriteria.X} - {findCriteria.Y}");

            Predicate<Point> lambdaCriteria = p => (p.X > value && p.Y > value);
            Point findLambdaCriteria = Array.Find<Point>(points, lambdaCriteria);
            Console.WriteLine($"Answer lambda: {findCriteria.X} - {findCriteria.Y}");
            
        }

        private static void PrintPoints(Point obj)
        {
            Console.WriteLine($"Foreach: {obj.X} - {obj.Y}");
        }

        public static bool OlderOrEqualTo18(Person p)
        {
            return p.Age >= 18;
        }

        
    }

    public static class ExtensionMethods
    {
        public static string ToUpperString(this object o)
        {
            return (o ?? "").ToString().ToUpper();
        }
        public static string Reverse(this string s)
        {
            return new string (s.ToCharArray().Reverse().ToArray());
        }
        public static void Dump<T>(this IEnumerable<T> ie)
        {
            foreach (var item in ie)
            {
                Console.WriteLine(item);
            }
        }
        public static object ConvertTo<T>(this object o)
        {
            return (T)(Convert.ChangeType(o, typeof(T)));
        }
        public static void ForEach<T>(this List<T> list, Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }
    }
}