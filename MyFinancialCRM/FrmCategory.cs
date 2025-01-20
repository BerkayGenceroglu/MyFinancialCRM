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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        FinancilalCRMEntities2 db = new FinancilalCRMEntities2();

        public void listele()
        {
            var data = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            }).ToList();
            dataGridView1.DataSource = data;
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.CategoryName = txtAd.Text;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı bir şekilde gerçekleştirildi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            var list = db.Categories.ToList();
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtıd.Text); 
            var deletedvalue = db.Categories.Find(id);
            db.Categories.Remove(deletedvalue); 
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı bir şekilde gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var list = db.Categories.ToList();
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtıd.Text);
            var deletedvalue = db.Categories.Find(id);
            deletedvalue.CategoryName = txtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var list = db.Categories.ToList();
            listele();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
