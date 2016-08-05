using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        // now we need to catch the exception
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            //Speed past the cars max to trigger exception
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error ***");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }

            // the error has been handled, processing continues with next statment
            Console.WriteLine("***** Out of the exception logic *****");
            Console.ReadLine();
        }
    }
}
