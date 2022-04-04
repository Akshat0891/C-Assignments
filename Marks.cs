using System;
namespace Marks
{
    
public class Average_Marks{
  public static void Main(string[] args) {
    double average;
    int marks;
    float highest =0;
    int sum =0;
    Console.WriteLine("Enter Students Marks: ");
    for (int i=1;i<=5;i++)
    {
        Console.Write("Student {0} Marks :",i);
        marks=Convert.ToInt32(Console.ReadLine());
        sum+=marks;
        if(marks>highest)
            highest = marks;
    }
    average = sum/5.0;
    Console.WriteLine("Highest marks: {0}",highest);
    Console.WriteLine("Average marks: {0}",average);
    
  }
}
    
}