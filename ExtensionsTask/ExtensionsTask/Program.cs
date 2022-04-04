using System;
using Extensions;
namespace ExtensionsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1001;
            Console.WriteLine(num.IsPrime());

            int num2 = 1024;
            Console.WriteLine(num2.IsPowOfTwo());

            char pattern2 = 'a';
            Console.WriteLine(pattern2.CustomContains("Salam"));

            string pattern = "Salam";
            Console.WriteLine(pattern.CustomContains("Salam necesiz ?"));
 
        }
    }
}
