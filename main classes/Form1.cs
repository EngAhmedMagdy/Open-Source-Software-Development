using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastFoodResturant
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            panel4.Top = button3.Top;
            firstUserControl11.BringToFront();
            notificationUserControl11.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Top = button3.Top;
            firstUserControl11.BringToFront();
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Top = button1.Top;
            secondUserControl11.BringToFront();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void reg_btn(object sender, EventArgs e)
        {
            panel4.Top = button6.Top;
            registerUserControl11.BringToFront();
        }

        private void login_btn(object sender, EventArgs e)
        {
            panel4.Top = button12.Top;
            loginUserControl11.BringToFront();
        }

        private void order_btn(object sender, EventArgs e)
        {
            panel4.Top = button4.Top;
            collectionUserControl11.BringToFront();
        }

        private void not_Click(object sender, EventArgs e)
        {
            if(notificationUserControl11.Visible)
            {
                notificationUserControl11.Visible = false;
                notificationUserControl11.SendToBack();
                
            }
            else
            {
                notificationUserControl11.Visible = true;
                notificationUserControl11.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void custome_btn(object sender, EventArgs e)
        {
            panel4.Top = button8.Top;
            customerUserControl11.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void payment_btn(object sender, EventArgs e)
        {
            panel4.Top = button7.Top;
            paymentUserControl11.BringToFront();
        }

        private void offer_btn(object sender, EventArgs e)
        {
            panel4.Top = button7.Top;
            offers1.BringToFront();
        }
    }
}
