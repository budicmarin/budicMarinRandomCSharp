using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinRandomCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator rand=new RandomGenerator();
            int i = rand.RandomNumber(1,1000);
            Console.WriteLine(i);
            string password = rand.RandomPassword();
            Console.WriteLine(password);

            string str= rand.RandomString(15, false);
            Console.WriteLine(str);

            Console.ReadKey();


        }
    }
}
