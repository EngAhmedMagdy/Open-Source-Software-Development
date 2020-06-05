using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastFoodResturant.ItratorPattern
{
    class ConcreteAggregate : Aggregate
    {

        public List<orderUserControl1> myOrders = new List<orderUserControl1>();



        public override Iterator CreateIterator()
        {

            return new ConcreteIterator(this);

        }



        // Gets item count

        public int Count
        {

            get { return myOrders.Count; }

        }



        // Indexer

        public orderUserControl1 this[int index]
        {

            get { return myOrders[index]; }

            set { myOrders.Insert(index, value); }

        }

    }
}
