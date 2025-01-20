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
    public partial class FrmBankaHareketleri : Form
    {
        public FrmBankaHareketleri()
        {
            InitializeComponent();
        }
        FinancilalCRMEntities2 db = new FinancilalCRMEntities2();   
        private void FrmBankaHareketleri_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.BankProcesses.Select(x => new{
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.BankProcessId 
            }).ToList();
            dataGridView1.RowHeadersVisible = true;

        }
    }
}
