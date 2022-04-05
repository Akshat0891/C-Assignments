using System;
namespace CalculatorApp {  
    class Program {  
        static void Main(string[] args) {  
            Console.WriteLine("Enter the action to be performed");  
            Console.WriteLine("Press 1 for Addition");  
            Console.WriteLine("Press 2 for Subtraction");  
            Console.WriteLine("Press 3 for Multiplication");  
            Console.WriteLine("Press 4 for Division \n");  
            int action = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 1st number:");  
            int num1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 2nd number:");  
            int num2 = Convert.ToInt32(Console.ReadLine());  
            int result = 0;  
            switch (action) {  
                case 1: {  
                    result = Addition(num1, num2);  
                    break;  
                }  
                case 2: {  
                    result = Subtraction(num1, num2);  
                    break;  
                }  
                case 3: {  
                    result = Multiplication(num1, num2);  
                    break;  
                }  
                case 4: {  
                    result = Division(num1, num2);  
                    break;  
                }  
                default:  
                    Console.WriteLine("Wrong input");  
                    break;  
            }  
            Console.WriteLine("The result is: {0}", result);  
            Console.ReadLine();  
        }  
        //Addition  
        public static int Addition(int num1, int num2) {  
            int result = num1 + num2;  
            return result;  
        }  
        //Subtraction  
        public static int Subtraction(int num1, int num2) {  
            int result = num1 - num2;  
            return result;  
        }  
        //Multiplication  
        public static int Multiplication(int num1, int num2) {  
            int result = num1 * num2;  
            return result;  
        }  
        //Division  
        public static int Division(int num1, int num2) {  
            int result = num1 / num2;  
            return result;  
        }  
    }  
}  