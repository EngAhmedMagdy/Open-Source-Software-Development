using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace fastFoodResturant.builderpattern
{
    public class order
    {
        Name name;
        Type type;
        Size size;
        Exters exters;
        

        public Name Name { get => name; set => name = value; }
        public Type Type { get => type; set => type = value; }
        public Size Size { get => size; set => size = value; }
        public Exters Exters { get => exters; set => exters = value; }
        
    }
}
