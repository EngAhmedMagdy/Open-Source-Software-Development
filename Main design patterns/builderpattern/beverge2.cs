using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastFoodResturant.builderpattern
{
    class beverge2 : orderParts
    {
        
            order order;

            public beverge2()
            {
                this.order = new order();
            }

            public string setName()
            {
                order.Name = Name.fanta;
                return order.Name.ToString();
            }

            public string setExters()
            {
                order.Exters = Exters.NO;
                return order.Exters.ToString();
            }

            public string setSize()
            {
                order.Size = Size.Small;
                return order.Size.ToString();
            }

            public string setType()
            {
                order.Type = Type.BEVERGES;
                return order.Type.ToString();
            }

            public void setImage(orderUserControl1 o)
            {

                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(fastFoodResturant.Properties.Resources._3);

                o.Image = bitmap;
            


            }

        
    }
}
