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
    public partial class registerUserControl1 : UserControl
    {
        public registerUserControl1()
        {
            InitializeComponent();
            
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            string[] employees = new string[]{"Hamilton, David", "Hensien, Kari",
            "Hammond, Maria", "Harris, Keith", "Henshaw, Jeff D.", 
            "Hanson, Mark", "Harnpadoungsataya, Sariya", 
            "Harrington, Mark", "Harris, Keith", "Hartwig, Doris", 
            "Harui, Roger", "Hassall, Mark", "Hasselberg, Jonas", 
            "Harnpadoungsataya, Sariya", "Henshaw, Jeff D.", 
            "Henshaw, Jeff D.", "Hensien, Kari", "Harris, Keith", 
            "Henshaw, Jeff D.", "Hensien, Kari", "Hasselberg, Jonas",
            "Harrington, Mark", "Hedlund, Magnus", "Hay, Jeff", 
            "Heidepriem, Brandon D."};
            comboBox1.Items.AddRange(employees);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
