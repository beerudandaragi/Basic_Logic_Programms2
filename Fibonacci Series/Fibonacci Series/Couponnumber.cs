using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Couponnumber
    {

        public void coupons(int n)//n=5
        {

            Random ran = new Random();
            //n = ran.Next(1, 9);
            int check = ran.Next(1, 9);
            //Console.WriteLine("enter the coupon limit");
            int count = 0;
            Console.WriteLine("coupon number is: " + n);
            while (n > 0)
            {
                if (check == n)
                {
                    Console.WriteLine("number is present");
                    break;
                }
                count++;
                Console.WriteLine("count :" + count);
                n--;
            }
            Console.WriteLine("to get  number we need count " + count);

        }
    }
}