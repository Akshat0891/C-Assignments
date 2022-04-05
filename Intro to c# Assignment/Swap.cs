using System;

namespace SwappingValues
{
    class Program
    {
        static void SwapNum(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter value of a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( "Value of a and b before sawapping");
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine( "b=" + " " + b);
            SwapNum(ref a, ref b);
            Console.WriteLine("Value of a and b after sawapping");
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            Console.ReadLine();
        }
    }
}