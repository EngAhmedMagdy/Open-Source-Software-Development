using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace fastFoodResturant
{
    public partial class orderUserControl1 : UserControl
    {
        private string name;
        private decimal quantity = 0;
        private string type = "";
        private string size = "";
        private string exters = "";
        private Bitmap image ;
        
        public notificationUserControl1 form;
        private int index = 0;
        public orderUserControl1()
        {

        }
        public orderUserControl1(notificationUserControl1 c)
        {
            InitializeComponent();
            form = c;

        }
        public string Name { get => name; set { name = value; label1.Text = value; } }
        public string Type { get => type; set { type = value; label2.Text = value; } }
        public string Size1 { get => size; set { size = value; label3.Text = value; } }
        public string Exters { get => exters; set { exters = value; label4.Text = value; } }
        public Bitmap Image { get => image; set { image = value; pictureBox1.Image = value; } }
                
            
        public int Index { get => index; set => index = value; }
        
        public decimal Quantity { get => quantity; set => label5.Text = value.ToString(); }
        

        private void orderUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.removeOrder(index);
        }
    }
}
