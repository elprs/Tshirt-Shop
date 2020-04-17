using ImplementationOfStrategy.Products;

namespace ImplementationOfStrategy.Strategies.TshirtVariationStrategies
{
    class SizeVariation : IVariationStrategy
    {
        public void Cost(Tshirt tshirt)
        {
            switch (tshirt.Size)
            {
                case Enums.Size.XS:tshirt.Price += 1.29m;break;
                case Enums.Size.S: tshirt.Price += 1.35m; break;
                case Enums.Size.M:tshirt.Price += 1.43m;break;
                case Enums.Size.L:tshirt.Price += 2.25m;break;
                case Enums.Size.XL:tshirt.Price += 1.85m; break;
                case Enums.Size.XXL: tshirt.Price += 1.05m;break;
                case Enums.Size.XXXL: tshirt.Price += 1.00m; break;
                default:tshirt.Price += 1.25m;break;
            }
        }
    }
}
