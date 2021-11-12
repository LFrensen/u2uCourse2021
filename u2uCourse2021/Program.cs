using System;

namespace u2uCourse2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day 1 excercises
            BankAccount bankAccount = new BankAccount();
            bankAccount.DepositMoney(100);
            bankAccount.WithdrawMoney(400);

            Beer b1 = new Beer("Duvel");
            Beer b2 = new Beer("Brugse Zot", "Depends on which one");
            Beer b3 = new Beer("Orval", "jummy", 6.2);

            // Day 2 excercises
            Rational one = new Rational() { Denominator = 1, Numerator = 2};
            Rational two = new Rational() { Denominator = 1, Numerator = 2};
            Rational three = one.Multiply(one, two);
            Console.WriteLine($"Numerator: {three.Denominator} - Denominator: {three.Numerator}");

            // Day 3 excercises
            Stack s = new Stack();
            s.Push("a");
            s.Push("b");
            s.Push("c");
            s.Push("d");
            s.Push("e");
            s.Push("f");
            s.Push("g");
            s.Push("h");
            s.Push("i");
            s.Push("j");
            s.Push("k");
            s.Push("l");

            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());


            // Day 4 excercise
            Robot wallE = new Robot() { Name = "Wall-E" };
            wallE.Routine = Chacha;
            wallE.Routine += Waltz;
            wallE.Routine += Chacha;
            wallE.Routine = ChachaThenWaltz;
            wallE.Stepped += WallE_Stepped;
            wallE.Go();

            
        }

        private static void WallE_Stepped(object sender, EventArgs eventArgs)
        {
            Robot r = (Robot)sender;
            Console.WriteLine($"{r.Name} is now at {r.Position}");
        }
        static void Chacha(Robot r)
        {
            Console.WriteLine($"{r.Name} is doing the ChaCha");
            r.MoveTo(1, 0);
            r.MoveTo(2, 0);
            r.MoveTo(-1, 0);
            r.MoveTo(-2, 0);
        }
        static void Waltz(Robot r)
        {
            Console.WriteLine($"{r.Name} is doing the Waltz");
            r.MoveTo(0, 1);
            r.MoveTo(1, 1);
            r.MoveTo(0, 0);
        }
        static void ChachaThenWaltz(Robot r)
        {
            Chacha(r);
            Waltz(r);
        }
    }
}
