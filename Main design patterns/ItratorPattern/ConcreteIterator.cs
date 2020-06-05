using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastFoodResturant.ItratorPattern
{
    
        class ConcreteIterator : Iterator
        {

            private ConcreteAggregate _aggregate;

            private int _current = 0;



            // Constructor

            public ConcreteIterator(ConcreteAggregate aggregate)
            {

                this._aggregate = aggregate;

            }



            // Gets first iteration item

            public override orderUserControl1 First()
            {

                return _aggregate[0];

            }



            // Gets next iteration item





            // Gets current iteration item

            public override orderUserControl1 CurrentItem()
            {

                return _aggregate[_current];

            }



            // Gets whether iterations are complete

            public override bool IsDone()
            {

                return _current >= _aggregate.Count;

            }


            public override orderUserControl1 Last()
            {
            orderUserControl1 o = null; ;
                while (!IsDone())
                {

                    o = _aggregate[++_current - 1];
                }
                return o;
            }

            public override orderUserControl1 Next()
            {
                return _aggregate[++_current];
            }
        }
    }
