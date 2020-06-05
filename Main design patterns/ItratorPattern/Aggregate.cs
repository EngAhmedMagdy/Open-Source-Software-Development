using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastFoodResturant.ItratorPattern
{
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();

    }
}
