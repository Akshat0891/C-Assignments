using System;

public class ParamsProgram
{
    public static void Main(string[] args)
    {
        Params(1,2,3,4,5,6,7,8,9,10);
    }
    public static void Params(params int[] val)
    {
        int sum=0;
        Console.WriteLine("Sum of all integers: ");
        foreach(int i in val)
            sum+=i;
        Console.Write(sum);
        Console.ReadLine();
    }
    
}