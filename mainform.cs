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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addmember ad = new addmember();
            ad.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteup du = new deleteup();
            du.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PAYMENT p = new PAYMENT();
            p.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewmember v = new viewmember();
            v.Show();
            this.Hide();
        }
    }
    
}
