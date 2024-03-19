using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GYM_management
{
    public partial class addmember : Form
    {
        public addmember()
        {
            InitializeComponent();
        }
       
            private void addmember_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "" || phoneTb.Text == "" || amountTb.Text == "" || ageTb.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    string connectionString = "Data Source=LAPTOP-8U1LSLT6\\SQLEXPRESS01;Initial Catalog=gymdb;Integrated Security=True;Encrypt=False";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "insert into membert values (@name, @phone, @gender, @age, @amount, @timing)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@name", nameTb.Text);
                        cmd.Parameters.AddWithValue("@phone", phoneTb.Text);
                        cmd.Parameters.AddWithValue("@gender", gendercb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@age", ageTb.Text);
                        cmd.Parameters.AddWithValue("@amount", amountTb.Text);
                        cmd.Parameters.AddWithValue("@timing", timingcb.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member successfully added");
                        con.Close();
                        amountTb.Text = "";
                        nameTb.Text = "";
                        ageTb.Text = "";
                        phoneTb.Text = "";
                        gendercb.Text = "";
                        timingcb.Text = "";  

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            amountTb.Text = "";
            nameTb.Text = "";
            ageTb.Text = "";
            phoneTb.Text = "";
            gendercb.Text = "";
            timingcb.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            mainform m = new mainform();
            m.Show();
            this.Hide();
        }
    }
}
