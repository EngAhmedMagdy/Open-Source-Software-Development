using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastFoodResturant
{
    public partial class paymentUserControl1 : UserControl
    {
        public paymentUserControl1()
        {
            InitializeComponent();
            textBox1.Text = (double.Parse(textBox2.Text) + double.Parse(textBox2.Text)).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
