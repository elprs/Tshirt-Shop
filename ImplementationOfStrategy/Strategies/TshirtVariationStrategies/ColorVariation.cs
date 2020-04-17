using ImplementationOfStrategy.Products;

namespace ImplementationOfStrategy.Strategies.TshirtVariationStrategies
{
    class ColorVariation : IVariationStrategy
    {
        public void Cost(Tshirt tshirt)
        {
            switch (tshirt.Color) // You can choose to use dictionary. Enums help to find them easier. 
            {
                case Enums.Color.Blue: tshirt.Price += 1.25m; break;
                case Enums.Color.Green: tshirt.Price += 1.35m; break;
                case Enums.Color.Indigo: tshirt.Price += 0.25m;break;
                case Enums.Color.Orange: tshirt.Price += 2.25m;break;
                case Enums.Color.Red: tshirt.Price += 3.25m;break;
                case Enums.Color.Violet: tshirt.Price += 1.35m; break;
                case Enums.Color.Yellow: tshirt.Price += 1.09m;break;
                default:tshirt.Price += 0m; break;
            }
        }
    }
}
