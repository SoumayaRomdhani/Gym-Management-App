using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox2.Text == "")
            {
                MessageBox.Show("missing informations");
            }
            else if(textBox1.Text =="soumaya" && textBox2.Text =="sou2003")
            {
                mainform m = new mainform();
                m.Show();
                this.Hide();
            }
            else { MessageBox.Show("wrong informations"); }
        }
    }
}
