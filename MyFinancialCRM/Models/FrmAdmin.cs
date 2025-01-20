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
using MyFinancialCRM.Models;

namespace MyFinancialCRM.Models
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        SqlConnection baglantı= new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=FinancilalCRM;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("Select * from Users where Username=@p1 and Password=@p2",baglantı);
            cmd.Parameters.AddWithValue("@p1", txtusername.Text);
            cmd.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmBanks frmBanks = new FrmBanks();
                frmBanks.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı veya Şifreniz Hatalı !!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
            baglantı.Close();




        }
    }
}
