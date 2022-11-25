using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            int cnt;
            for(cnt =5; cnt <=25; cnt+=5)
            {
                Console.Write(cnt + " ");
            }
            Console.WriteLine();

            int year = 2022;
            Console.WriteLine(year+ " ");
            if ((year % 400) == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else if ((year % 100) == 0)
            {
                Console.WriteLine("Not Leap Year");
            }
            else if ((year % 4) == 0)
            {
                Console.WriteLine("Not Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
            }

        }
        
}

