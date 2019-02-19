using Shapes.Library;
using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = new Circle
            {
                Name = "CircleBro",
                Size = 10
            };
            C.getId("001");
            C.Stance();
        }
    }
}
