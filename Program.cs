using System;
using System.Text;

namespace Csharp_Essential_Training_One
{
    class Program
    {
        enum weekDays { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5 };
        
        static void Main(string[] args)
        {
            var someTime = new DateTime(2021, 08, 29, 23, 30, 30);
            Console.WriteLine(someTime.ToLongDateString());
        }
    }
}
