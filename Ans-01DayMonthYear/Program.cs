using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ans_01DayMonthYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Inter Year:");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year > 2017)
            {
                Console.WriteLine(" Sorry, you provide an invalid year. Try again!");
            }

            Console.Write("Please Inter Month:");
            int Month = Convert.ToInt32(Console.ReadLine());

            if (Month <=0  )
            {
                Console.WriteLine(" Sorry, you provide an invalid Month. Try again!");
            }
            if (Month  >12)
            {
                Console.WriteLine(" Sorry, you provide an invalid Month. Try again!");
            }

            Console.Write("Please Inter Day:");
            int Day = Convert.ToInt32(Console.ReadLine());


            if (Day <= 0)
            {
                Console.WriteLine(" Sorry, you provide an invalid Day. Try again!");
            }
            if (Day > 30)
            {
                Console.WriteLine(" Sorry, you provide an invalid Month. Try again!");
            }

            Console.WriteLine( " youre date Is:{0}-{1}-{2} "+  Day, Month,Year );

            

            Console.ReadKey();
        }

        
    }
}
