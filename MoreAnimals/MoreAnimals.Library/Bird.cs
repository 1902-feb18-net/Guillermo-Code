using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
    class Bird : IAnimals
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }

        public void flyFrom(string pointA, string pointB)
        {
            Console.WriteLine($"{Name} is going from {pointA} to {pointB}");
        }
    }
}
