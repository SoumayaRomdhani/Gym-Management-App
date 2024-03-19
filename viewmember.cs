using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_management
{
    public partial class viewmember : Form
    {
        public viewmember()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-8U1LSLT6\\SQLEXPRESS01;Initial Catalog=gymdb;Integrated Security=True;Encrypt=False");
        private void filterbyname()
        {
            try
            {
                Con.Open();
                String query = "select * from membert where Mname='" + recherche.Text + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                // Vérifier si le DataSet est vide
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Ce nom n'existe pas.");
                }
                else
                {
                    memberSDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void populate()
        {
            Con.Open();
            String query = "select * from membert";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            memberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void viewmember_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            filterbyname();
            recherche.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
