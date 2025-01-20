using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCRM.Models;

namespace MyFinancialCRM
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancilalCRMEntities2 db = new FinancilalCRMEntities2();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Bills.ToList();   
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnödemelistesi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Bills.ToList();
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnyeniödeme_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.BillTıtle = txtbaslık.Text;
            bills.BillAmount = decimal.Parse(txtmiktar.Text);
            bills.BillPeriod = txtperiyot.Text;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Bills.ToList();
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnödemesil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtıd.Text);
            var removevalue = db.Bills.Find(id);
            db.Bills.Remove(removevalue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Bills.ToList();
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnödemegüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtıd.Text);
            var updatedvalue = db.Bills.Find(id);
            updatedvalue.BillTıtle = txtbaslık.Text;
            updatedvalue.BillAmount = decimal.Parse(txtmiktar.Text);
            updatedvalue.BillPeriod = txtperiyot.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Bills.ToList();
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnbanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks(); 
            frmBanks.Show();  
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();   
            frmBilling.Show();  
            this.Hide();    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard(); 
            frmDashboard.Show();    
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
