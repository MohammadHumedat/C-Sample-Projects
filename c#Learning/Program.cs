using System;
using System.Net.NetworkInformation;

namespace HelloWorld
{
    class Program {

        static void TestMethod( int[,] myNumbers)
        {
            foreach (var number in myNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static void Main(string[] args)
        {
           
            int[,] myNumbers = { {1,2,3 },{4,5,6},{7,8,9}};
           TestMethod(myNumbers);
            Console.ReadLine();
            TestMethod(myNumbers);
           
        }
    }
}