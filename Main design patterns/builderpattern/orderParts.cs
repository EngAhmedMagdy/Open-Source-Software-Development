using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace fastFoodResturant.builderpattern
{
    public interface orderParts
    {
        string setName();
        string setExters();
        string setType();
        string setSize();
        void setImage(orderUserControl1 o);
        
    }
}
