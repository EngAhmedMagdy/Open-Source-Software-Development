using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastFoodResturant.ItratorPattern
{
    abstract class Iterator
    {
        public abstract orderUserControl1 First();
        public abstract orderUserControl1 Last();
        public abstract orderUserControl1 Next();

        public abstract bool IsDone();

        public abstract orderUserControl1 CurrentItem();
    }
}
