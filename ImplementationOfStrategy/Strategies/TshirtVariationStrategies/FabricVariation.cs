using ImplementationOfStrategy.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy.Strategies.TshirtVariationStrategies
{
    class FabricVariation : IVariationStrategy
    {

        public void Cost(Tshirt tshirt)
        {
            switch (tshirt.Fabric)
            {
                case Enums.Fabric.Casmere:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Fabric.Cotton:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Fabric.Liner:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Fabric.Polyester:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Fabric.Rayon:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Fabric.Silk:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Fabric.Wool:
                    tshirt.Price += 1.25m;
                    break;
                default:
                    tshirt.Price += 1.25m;
                    break;
            }
        }
    }
}

