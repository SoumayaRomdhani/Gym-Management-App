using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_management
{
    public partial class deleteup : Form
    {
        public deleteup()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-8U1LSLT6\\SQLEXPRESS01;Initial Catalog=gymdb;Integrated Security=True;Encrypt=False");
        private void populate()
        {
            Con.Open();
            String query = "select * from membert";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            memebrsgbd.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void deleteup_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void memebrsgbd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0) // Check if a valid row is selected
            {
                
                DataGridViewRow row = this.memebrsgbd.Rows[e.RowIndex];

                nameTb.Text = row.Cells["Mname"].Value?.ToString() ?? "";
                phoneTb.Text = row.Cells["Mphone"].Value?.ToString() ?? "";
                amountTb.Text = row.Cells["Mamount"].Value?.ToString() ?? "";
                ageTb.Text = row.Cells["Mage"].Value?.ToString() ?? "";

                // Populate gender ComboBox
                string gender = row.Cells["Mgen"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(gender))
                {
                    gendercb.SelectedItem = gender; // Assuming gendercb already contains gender options
                }
                // Populate timing ComboBox
                string timing = row.Cells["Mtiming"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(timing))
                {
                    timingcb.SelectedItem = timing; // Assuming timingcb already contains timing options
                }
                // Extracting key
                if (int.TryParse(row.Cells[0].Value.ToString(), out int extractedKey))
                {
                    key = extractedKey;
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform();
            mf.Show();
            this.Hide();

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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("select the member to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM memberT WHERE Mid = @key;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member deleted successfully");
                    Con.Close();
                    populate(); // Assuming populate() method repopulates the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PAY_Click(object sender, EventArgs e)
        {
            if (key == 0 || nameTb.Text =="" || ageTb.Text=="" || amountTb.Text == "" || gendercb.Text == "" || phoneTb.Text == "" || timingcb.Text == ""  )
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE membert set Mname='"+nameTb.Text+"',Mphone='"+phoneTb.Text+"',Mgen='"+gendercb.Text+"',Mage='"+ageTb.Text+"',Mtiming='"+timingcb.Text+"',Mamount='"+amountTb.Text+"' where Mid=@key";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member updated successfully");
                    Con.Close();
                    populate(); // Assuming populate() method repopulates the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //second method to avoid '"++"'
            //string query = "UPDATE membert SET Mname=@Mname, Mphone=@Mphone, Mgen=@Mgen, Mage=@Mage, Mtiming=@Mtiming, Mamount=@Mamount WHERE Mid=@key";
            //SqlCommand cmd = new SqlCommand(query, Con);
            //cmd.Parameters.AddWithValue("@Mname", nameTb.Text);
            //cmd.Parameters.AddWithValue("@Mphone", phoneTb.Text);
            //cmd.Parameters.AddWithValue("@Mgen", gendercb.Text);
            //cmd.Parameters.AddWithValue("@Mage", ageTb.Text);
            //cmd.Parameters.AddWithValue("@Mtiming", timingcb.Text);
            //cmd.Parameters.AddWithValue("@Mamount", amountTb.Text);
            //cmd.Parameters.AddWithValue("@key", key);

        }
    }
}
