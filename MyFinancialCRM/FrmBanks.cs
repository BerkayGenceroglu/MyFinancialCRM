using MyFinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCRM
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancilalCRMEntities2 db = new FinancilalCRMEntities2();   

        private void Form1_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatbankBalance = db.Banks.Where(x => x.BankTitle== "Ziraat Bankası").Select(x => x.BankBalance).FirstOrDefault();
            var yapıkredibankBalance = db.Banks.Where(x => x.BankTitle== "YapıKredi").Select(x => x.BankBalance).FirstOrDefault();
            var denizbankBalance = db.Banks.Where(x => x.BankTitle== "Denizbank").Select(x => x.BankBalance).FirstOrDefault();

            lblziraatbankbalance.Text = ziraatbankBalance.ToString()+ " ₺";
            lblyapıkredıbankbalance.Text = yapıkredibankBalance.ToString() + " ₺";
            lbldenizbankbalance.Text = denizbankBalance.ToString() + " ₺";


            //Banka Hareketleri 
            var bankprocess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblbankProcess1.Text = bankprocess1.Description + " ------ " + bankprocess1.Amount + " ------ " + bankprocess1.ProcessDate;
            var bankprocess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblbankProcess2.Text = bankprocess2.Description + " ------ " + bankprocess2.Amount + " ------ " + bankprocess2.ProcessDate;
            var bankprocess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblbankProcess3.Text = bankprocess3.Description + " ------ " + bankprocess3.Amount + " ------ " + bankprocess3.ProcessDate;
            var bankprocess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            llblbankProcess4.Text = bankprocess4.Description + " ------ " + bankprocess4.Amount + " ------ " + bankprocess1.ProcessDate;
            var bankprocess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblbankProcess5.Text = bankprocess5.Description + " ------ " + bankprocess5.Amount + " ------- " +bankprocess5.ProcessDate;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks(); 
            frmBanks.Show();  
            this.Hide();
        }

        private void btnfaturalar_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();    
            frmCategory.Show(); 
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGiderler frm = new FrmGiderler();  
            frm.Show(); 
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankaHareketleri frm = new FrmBankaHareketleri();    
            frm.Show(); 
            this.Hide();    

        }
    }
}
