using ImplementationOfStrategy.Products;

namespace ImplementationOfStrategy.Strategies.TshirtVariationStrategies
{
    class FabricVariation : IVariationStrategy
    {
        public void Cost(Tshirt tshirt)
        {
            switch (tshirt.Fabric)
            {
                case Enums.Fabric.Casmere: tshirt.Price += 1.75m; break;
                case Enums.Fabric.Cotton: tshirt.Price += 1.28m; break;
                case Enums.Fabric.Liner:tshirt.Price += 1.45m;break;
                case Enums.Fabric.Polyester: tshirt.Price += 0.25m; break;
                case Enums.Fabric.Rayon:tshirt.Price += 1.65m;break;
                case Enums.Fabric.Silk:tshirt.Price += 2.25m;break;
                case Enums.Fabric.Wool: tshirt.Price += 1.08m;break;
                default:tshirt.Price += 1.25m; break;
            }
        }
    }
}

