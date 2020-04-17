using ImplementationOfStrategy.Products;

namespace ImplementationOfStrategy.Strategies.TshirtVariationStrategies
{
    interface IVariationStrategy
    {
        void Cost(Tshirt tshirt);
    }
}
