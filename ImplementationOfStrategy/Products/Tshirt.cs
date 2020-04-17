using ImplementationOfStrategy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy.Products
{
    public class Tshirt
    {
        public Tshirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        public  Color Color { get; } //Option to have it as readonly
        public  Size Size { get; }
        public  Fabric Fabric { get; }

        public decimal  Price { get; set; }

        public void Output()
        {
            Console.WriteLine("{0, -15}{1, -15}{2, -15}", Color, Size, Fabric);
        }
    }
}
