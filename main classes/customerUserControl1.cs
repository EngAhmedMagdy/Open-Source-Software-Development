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
    public partial class customerUserControl1 : UserControl
    {

        /*private static customerUserControl1 _instance;
        public static customerUserControl1 getInstance()
        {
            if(_instance ==null)
            {
                _instance = new customerUserControl1();
            }
            return _instance;
        }*/
        public customerUserControl1()
        {
            InitializeComponent();
        }

        private void customerUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CurrentUser.getCurrentUser());
        }
    }
}
