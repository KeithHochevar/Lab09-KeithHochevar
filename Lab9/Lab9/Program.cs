using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath MyMath = new MyMath();

            MyMath.Multiply(1, 2);
            Console.WriteLine(MyMath.GetResult());

            MyMath.Divide(2, 3);
            Console.WriteLine(MyMath.GetResult());

            MyMath.Subtract(3, 4);
            Console.WriteLine(MyMath.GetResult());

            MyMath.Add(4, 5);
            Console.WriteLine(MyMath.GetResult());
        }
    }
}
