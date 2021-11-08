using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Label: Console.WriteLine("1.Fibonacci Series 2.Perfactnumber 3.primeNumber 4.Reversenumber 5.stopwatch 6.Couponnumber 7.Vending_machine\n");
            Console.WriteLine("type the option");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:

                    Console.WriteLine("\nEnter the number of elements \n ");
                    Class1 fibonacciseris1 = new Class1();
                    fibonacciseris1.fibonacciseris();
                    break;
                    
                case 2:
                    Console.WriteLine("enter the Number\n");
                    Perfactnumber obj = new Perfactnumber();
                    obj.perfactnumber();
                    break;
                case 3:
                    Console.WriteLine("Enter the Number to check Prime: \n");
                    Prime_Number obj1 = new Prime_Number();
                    obj1.primeNumber();
                    break;
                case 4:
                    Console.WriteLine("Enter the Number: \n");
                    Reversenumber obj2 = new Reversenumber();
                    obj2.reversenumbers();
                    break;
                case 5:
                    Console.WriteLine("Enter the Number: \n");
                    stopwatch obj3 = new stopwatch();
                    obj3.printWatch();
                    break;
                case 6:
                    Console.WriteLine("Enter the Number: \n");
                    Couponnumber obj4 = new Couponnumber();
                    obj4.coupons(10);
                    break;
                case 7:
                    Console.WriteLine("Enter the Number: \n");
                    Vending_machine obj5= new Vending_machine();
                    obj5.MinimumNumberOfNote(1000);
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
            Console.WriteLine(" do you want continoue ....yes/no");
            if (Console.ReadKey().KeyChar.ToString() == "yes")
            {
                goto Label;
            }
            Console.ReadKey();
        }
    }
}
