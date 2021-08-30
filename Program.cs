using System;
using System.Text;

namespace Csharp_Essential_Training_One
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = "Dallas";
            var temperature = 103.4f;
            var currentDt = DateTime.Now;
            Console.WriteLine(string.Format("Welcome to {0}. The time is {1:t}. The temperature is {2:0.00}.", city, currentDt, temperature));
        }
    }
}
