using System;

namespace Circle
{
    class CircleProgram
    {
        
        public static void Main(string[] args)
        {
            double r;
            Console.WriteLine("Enter the radius of the circle");
            r = Convert.ToDouble(Console.ReadLine());

            double area = Area(r);
            double circumference = Circumference(r);
            Console.WriteLine("Area of the circle = {0}",area);
            Console.WriteLine("Circumference of the circle = {0}",circumference);
            Console.Read();
        }
        
        public static double Area(double r)
        {
            double pi = 3.14;
            return pi*r*r;
        }
        
        public static double Circumference(double r)
        {
            double pi = 3.14;
            return 2*pi*r;
        }
    }
}