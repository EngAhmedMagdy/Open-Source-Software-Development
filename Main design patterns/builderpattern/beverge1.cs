using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace fastFoodResturant.builderpattern
{
    class beverge1 : orderParts
    {
        
            order order;

            public beverge1()
            {
                this.order = new order();
            }

            public string setName()
            {
                order.Name = Name.cocacola;
                return order.Name.ToString();
            }

            public string setExters()
            {
                order.Exters = Exters.NO;
                return order.Exters.ToString();
            }

            public string setSize()
            {
                order.Size = Size.Medium;
                return order.Size.ToString();
            }

            public string setType()
            {
                order.Type = Type.BEVERGES;
                return order.Type.ToString();
            }

            public void setImage(orderUserControl1 o)
            {

                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(fastFoodResturant.Properties.Resources._1);

                o.Image = bitmap;
               


        }
        }
}
