using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fastFoodResturant.factoryPattern;
namespace fastFoodResturant
{
    
    public partial class offers : UserControl
    {
        offer1 offer1 = new offer1();
        offer1 offer2 = new offer1();

        public offers()
        {
            
            InitializeComponent();
            label2.Text = offer1.CreateProductA().setName() + " + " + offer1.CreateProductB().setName() + " + " + offer1.CreateProductD().setName();
            label3.Text = offer2.CreateProductA().setName() + " + " +  offer2.CreateProductB().setName() + " + " + offer2.CreateProductD().setName();
            //pictureBox1.Image = offer1.CreateProductA().setImage(new orderUserControl1());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
