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
    public partial class secondUserControl1 : UserControl
    {
        notificationUserControl1 form;
        manfacture manfacture = new manfacture();
        public secondUserControl1(notificationUserControl1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderUserControl1 o = new orderUserControl1(form);
           
            facade concreteFacade = new facade(new manfacture(), form);
            concreteFacade.SendNotification(new sandwish1(), o, notificationUserControl1.N++);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderUserControl1 o = new orderUserControl1(form);
            
            facade concreteFacade = new facade(new manfacture(), form);
            concreteFacade.SendNotification(new cake3(), o, notificationUserControl1.N++);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderUserControl1 o = new orderUserControl1(form);
            
            facade concreteFacade = new facade(new manfacture(), form);
            concreteFacade.SendNotification(new beverge1(), o, notificationUserControl1.N++);
        }
    }
}
