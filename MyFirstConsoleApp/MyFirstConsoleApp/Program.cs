using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
        }

        private static void OperatorExamples()
        {
            int width = 3;

            width++;

            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);
        }
    }
}
