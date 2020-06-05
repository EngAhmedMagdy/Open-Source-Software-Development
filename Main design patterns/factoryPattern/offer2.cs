using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fastFoodResturant.builderpattern;
namespace fastFoodResturant.factoryPattern
{
    class offer2 : offers
    {
        public override orderParts CreateProductA()
        {
            return new cake1();
        }

        public override orderParts CreateProductB()
        {
            return new beverge1();
        }

        public override orderParts CreateProductD()
        {
            return new sandwish1();
        }
    }
}
