using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fastFoodResturant.builderpattern;

namespace fastFoodResturant.factoryPattern
{
    class offer1 : offers
    {
        public override orderParts CreateProductA()
        {
            return new cake2();
        }

        public override orderParts CreateProductB()
        {
            return new beverge2();
        }

        public override orderParts CreateProductD()
        {
            return new sandwish2();
        }
    }
}
