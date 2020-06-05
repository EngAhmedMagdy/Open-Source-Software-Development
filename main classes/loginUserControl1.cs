using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fastFoodResturant.SingletonPattern;

namespace fastFoodResturant
{
    public partial class loginUserControl1 : UserControl
    {
        customerUserControl1 form;
        public loginUserControl1(customerUserControl1 form)
        {
            InitializeComponent();
            this.form = form;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            form.BringToFront();
            CurrentUser.setCurrentUser(textBox1.Text);  //SINGLETON
            
        }
    }
}
