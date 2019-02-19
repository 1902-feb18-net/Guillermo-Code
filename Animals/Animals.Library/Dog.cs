using System;

namespace Animals
{
    public class Dog
    {
        public string Noise = "Woof!";

        public void GoTo(string location)
        {
            Console.WriteLine("Walking to " + location);

            //string interpolation syntax
            Console.WriteLine($"Walking to {location}");
        }

        public void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }
}