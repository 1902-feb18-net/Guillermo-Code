using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
   public class Circle
    {
        public string Name { get; set; }
        public int Size { get; set; }
        private string Id { get; set; }

        public void getId(string id)
        {
            Id = id;
        }
        public void Stance()
        {
            Console.WriteLine($"I am {Name} and my size is {Size} with an ID of {Id}.");
        }

    }
}
