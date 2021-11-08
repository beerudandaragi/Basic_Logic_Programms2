using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fibonacci_Series
{
    class Class1
    {
        public void fibonacciseris()
        {
             int N1 = 0, N2 = 1, N3, i, Number;
            //Console.Write("Enter the number of elements: ");
            Number = int.Parse(Console.ReadLine());
            Console.Write(N1 + " " + N2 + " "); //printing 0 and 1    
            for (i = 2; i < Number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                N3 = N1 + N2;
                Console.Write(N3 + " ");
                N1 = N2;
                N2 = N3;
            }
        }
        }
    }