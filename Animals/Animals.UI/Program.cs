using System;
using Animals.Library;

namespace Animals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var Snoop = new Dog();
            Snoop.GoTo("Outside");
            Snoop.MakeNoise();
        }
    }
}
