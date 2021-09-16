using System;

namespace Les4
{
    class Program
    {
        static void Main(string[] args)
        {
            //L2.1
            int x,y,a,b,c;
            Console.WriteLine("input x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input c");
            c = Convert.ToInt32(Console.ReadLine());

            if (x < 5 & y < 6)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (x < 5 == false)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (x < 4 | y < 5)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (x < 4 & y < 6 == false)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (x < 2 & y >3 )
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            // L2.2


            if (a > 10 & b>10 == true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            int tmp;
            int tmp1;
            tmp = a % 2 ;
            tmp1 = b % 2 ;
            if ((tmp == 0 & tmp1 !=0)| (tmp1 == 0 & tmp != 0))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            if (a > 0 | b > 0 == true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            if (a % 3 == 0 & b % 3 == 0 & c % 3 == 0)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (a < 0 | b < 0 | c < 0)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if ((a < 5) ^ (b < 5) ^ (c < 5) )
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.WriteLine();
        }
    }
}
