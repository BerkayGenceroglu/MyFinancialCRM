using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCRM.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MyFinancialCRM
{
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        FinancilalCRMEntities2 db = new FinancilalCRMEntities2();   

        private void FrmGiderler_Load(object sender, EventArgs e)
        {

            var data = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.Categories.CategoryName
            }).ToList();
            dataGridView1.DataSource = data;

            cmbkategori.DataSource = db.Categories.ToList();
            cmbkategori.DisplayMember = "CategoryName";
            cmbkategori.ValueMember = "CategoryId";

        }
        
        private void btngiderlistele_Click(object sender, EventArgs e)
        {
            var data = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.Categories.CategoryName
            }).ToList();
            dataGridView1.DataSource = data;

            cmbkategori.DataSource = db.Categories.ToList();
            cmbkategori.DisplayMember = "CategoryName";
            cmbkategori.ValueMember = "CategoryId";
        }

        private void btngiderekle_Click(object sender, EventArgs e)
        {
            Spendings spendings = new Spendings();
            spendings.SpendingDate = dtpick.Value;
            spendings.SpendingTitle = txtbaslık.Text;
            spendings.SpendingAmount = decimal.Parse(txtmiktar.Text);
            spendings.CategoryId = int.Parse(cmbkategori.SelectedValue.ToString());
            db.Spendings.Add(spendings);    
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btngidersil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deletedvalue = db.Spendings.Find(id);
            db.Spendings.Remove(deletedvalue);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngidergüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deletedvalue = db.Spendings.Find(id);
            deletedvalue.SpendingTitle = txtbaslık.Text;
            deletedvalue.SpendingAmount = decimal.Parse(txtmiktar.Text);
            deletedvalue.SpendingDate = dtpick.Value;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
