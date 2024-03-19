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
    public partial class PAYMENT : Form
    {
        public PAYMENT()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-8U1LSLT6\\SQLEXPRESS01;Initial Catalog=gymdb;Integrated Security=True;Encrypt=False");
        private void fillname()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Mname FROM membert", Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                // Création d'une liste pour stocker les noms de membres
                List<string> memberNames = new List<string>();

                while (rdr.Read())
                {
                    // Ajouter chaque nom de membre à la liste
                    memberNames.Add(rdr["Mname"].ToString());
                }
                Con.Close();

                // Lier la liste des noms de membres au ComboBox
                namep.DataSource = memberNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des noms de membres : " + ex.Message);
            }
        }

        private void PAYMENT_Load(object sender, EventArgs e)
        {
            fillname();
            populate();
        }
        private void filterbyname()
        {
            Con.Open();
            String query = "select * from PaymentTbl where pmember='"+recherche.Text+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            paymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            String query = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            paymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            amountp.Text = "";
            namep.Text = "";
            datep.Text = "";

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            mainform m = new mainform();
            m.Show();
            this.Hide();
        }
        int Key = 1;
        private void PAY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namep.Text) || string.IsNullOrWhiteSpace(amountp.Text))
            {
                MessageBox.Show("missing information");
            }
            else
            {
                String payperiod = datep.Value.Month.ToString() + datep.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from PaymentTbl where pmember=@pmember and pmonth=@pmonth", Con);
                cmd.Parameters.AddWithValue("@pmember", (namep.SelectedValue != null) ? namep.SelectedValue.ToString() : "");
                cmd.Parameters.AddWithValue("@pmonth", payperiod);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("already paid for this month");
                }
                else
                {
                    string query = "insert into PaymentTbl values (@pmonth, @pmember, @amount)";
                    SqlCommand insertCmd = new SqlCommand(query, Con);
                    insertCmd.Parameters.AddWithValue("@pmonth", payperiod);
                    insertCmd.Parameters.AddWithValue("@pmember", (namep.SelectedValue != null) ? namep.SelectedValue.ToString() : "");
                    insertCmd.Parameters.AddWithValue("@amount", amountp.Text);
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("amount paid successfully");
                }
                Con.Close();
                populate();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            filterbyname();
            recherche.Text = "";
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
