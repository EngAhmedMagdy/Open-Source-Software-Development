using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Drawing;
using fastFoodResturant;
namespace fastFoodResturant.builderpattern
{
    public class cake2 : orderParts
    {
        order order;

        public cake2()
        {
            this.order = new order();
        }

        public string setName()
        {
            order.Name = Name.theRancher;
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
            order.Type = Type.CAKE;
            return order.Type.ToString();
        }

        public void setImage(orderUserControl1 o)
        {
            
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(fastFoodResturant.Properties.Resources._8);

            o.Image = bitmap;
           
        }
    }
}
