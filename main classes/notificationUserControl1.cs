using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fastFoodResturant.ItratorPattern;

namespace fastFoodResturant
{
    public partial class notificationUserControl1 : UserControl
    {

        private ConcreteAggregate myorders = new ConcreteAggregate();


        public notificationUserControl1()
        {
            InitializeComponent();
           
            
        }
        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        public FlowLayoutPanel setFlow
        {
            get { return flowLayoutPanel1; }
            set { flowLayoutPanel1 = value; }
        }

        public static int N { get; set; } =0;
        internal ConcreteAggregate Myorders { get => myorders; set => myorders = value; }

        public void removeOrder(int index)
        {
            ConcreteIterator iterator = new ConcreteIterator(Myorders);
            
            while(true)
            {
                if(iterator.CurrentItem().Index == index)
                {
                    this.setFlow.Controls.Remove(iterator.CurrentItem());
                    break;
                }
                iterator.Next();
            }
            
            //MessageBox.Show(index.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConcreteIterator iterator = new ConcreteIterator(Myorders);
            
        }
    }
}
