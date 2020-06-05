using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace fastFoodResturant.builderpattern
{
    class meal : orderParts
    {
        order order;

        public meal()
        {
            this.order = new order();
        }

        public string setName()
        {
            order.Name = Name.ZINGER_SUPREME_OFFER;
            return order.Name.ToString();
        }

        public string setExters()
        {
            order.Exters = Exters.YES;
            return order.Exters.ToString();
        }

        public string setSize()
        {
            order.Size = Size.Big;
            return order.Size.ToString();
        }

        public string setType()
        {
            order.Type = Type.MEAL;
            return order.Type.ToString();
        }

        public void setImage(orderUserControl1 o)
        {

            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(fastFoodResturant.Properties.Resources._10);

            o.Image = bitmap;
            

        }
    }
}
