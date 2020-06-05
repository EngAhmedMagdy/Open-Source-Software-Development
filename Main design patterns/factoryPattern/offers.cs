using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fastFoodResturant.builderpattern;
namespace fastFoodResturant.factoryPattern
{
    public abstract class offers
    {
        public abstract orderParts CreateProductA();

        public abstract orderParts CreateProductB();
        public abstract orderParts CreateProductD();

       
    }
}
