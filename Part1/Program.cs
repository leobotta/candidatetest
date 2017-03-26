using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool multOfThree = false;
            bool multOfFive = false;
            string fizz = "fizz";
            string buzz = "buzz";

            for (int h = 1; h <= 100; h++)
            {
                string txt = null;
                multOfThree = h % 3 == 0;
                multOfFive = h % 5 == 0;

                if (multOfThree && multOfFive) txt = $"{fizz}{buzz}";
                else if (multOfThree) txt = fizz;
                else if (multOfFive) txt = buzz;
                if (!multOfThree && !multOfFive) txt = $"{h}";

                Console.WriteLine(txt);
            }

            Console.ReadKey();
        }
    }
}
