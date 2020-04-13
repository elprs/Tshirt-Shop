using ImplementationOfStrategy.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy.Strategies.TshirtVariationStrategies
{
    class SizeVariation : IVariationStrategy
    {
        public void Cost(Tshirt tshirt)
        {
            switch (tshirt.Size)
            {
                case Enums.Size.XS:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Size.S:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Size.M:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Size.L:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Size.XL:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Size.XXL:
                    tshirt.Price += 1.25m;
                    break;
                case Enums.Size.XXXL:
                    tshirt.Price += 1.25m;
                    break;
                default:
                    tshirt.Price += 1.25m;
                    break;
            }
        }
    }
}
