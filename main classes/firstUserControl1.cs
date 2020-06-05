using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fastFoodResturant.builderpattern;
using fastFoodResturant.facadePattern;
namespace fastFoodResturant
{
    public partial class firstUserControl1 : UserControl
    {
        notificationUserControl1 form;
        manfacture manfacture = new manfacture();
        public firstUserControl1(notificationUserControl1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            orderUserControl1 o = new orderUserControl1(form);
            facade concreteFacade = new facade(new manfacture(), form);
            concreteFacade.SendNotification(new meal(), o, notificationUserControl1.N++);
        }
    }
}
