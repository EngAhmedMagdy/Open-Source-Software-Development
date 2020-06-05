using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fastFoodResturant.builderpattern;
using fastFoodResturant.ItratorPattern;
namespace fastFoodResturant.facadePattern
{
    class facade
    {
        manfacture manfacture;
        notificationUserControl1 form;

        public facade(manfacture manfacture,notificationUserControl1 form)
        {
            this.manfacture = manfacture;
            this.form = form;
        }
        public orderUserControl1 SendNotification(orderParts orderParts,orderUserControl1 order, int index, string s, decimal quantity)
        {
            
            manfacture.ConstructOrder(orderParts,order,index,s,quantity);
            form.setFlow.Controls.Add(order);
            form.Myorders[form.Myorders.Count] = order;
            return order;

        }
        public orderUserControl1 SendNotification(orderParts orderParts, orderUserControl1 order, int index)
        {

            manfacture.ConstructOrder(orderParts, order, index);
            form.setFlow.Controls.Add(order);

            form.Myorders[form.Myorders.Count] = order;
            return order;

        }

    }
}
