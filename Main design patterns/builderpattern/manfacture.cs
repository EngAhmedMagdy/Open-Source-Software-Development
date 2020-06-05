using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastFoodResturant.builderpattern
{
    public class manfacture
    {
        
        public orderUserControl1 ConstructOrder(orderParts orderParts, orderUserControl1 n,int index,string s,decimal quantity)
        {
            orderParts.setImage(n);
            n.Name = orderParts.setName();
            n.Type = orderParts.setType();
            n.Exters = orderParts.setExters();
            n.Size1 = s;
            n.Index = index;
            n.Quantity = quantity;
            return n;
        }
        public void ConstructOrder(orderParts orderParts,orderUserControl1 n,int index)
        {
            orderParts.setImage(n);
            n.Name = orderParts.setName();
            n.Type = orderParts.setType();
            n.Exters = orderParts.setExters();
            n.Size1 = orderParts.setSize();
            n.Index = index;
            n.Quantity = 1;
            
            
            

        }
    }
}
