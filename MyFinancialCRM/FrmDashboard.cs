using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCRM.Models;

namespace MyFinancialCRM
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancilalCRMEntities2 db = new FinancilalCRMEntities2();
        int count = 0 ;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalbalance = db.Banks.Sum(x => x.BankBalance);
            lbltotalbalance.Text = totalbalance.ToString() + " ₺";

            var lastbankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Select(y=> y.Amount).FirstOrDefault();
            lbllasthavale.Text = lastbankProcessAmount.ToString() + " ₺";

            //Chart 1 Kodları
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData) 
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }
            //Chart 2 Kodları
            var billdata = db.Bills.Select(x => new
            {
                x.BillTıtle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
            foreach (var item in billdata)
            {
                series2.Points.AddXY(item.BillTıtle, item.BillAmount);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            count++;
            if (count % 5 == 1)
            {
                var elektrikfaturası = db.Bills.Where(x => x.BillTıtle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblbilingtıtle.Text = "Elektrik Faturası";
                lblbillamount.Text = elektrikfaturası.ToString() + " ₺";
            }
            if (count % 5 == 2)
            {
                var elektrikfaturası = db.Bills.Where(x => x.BillTıtle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblbilingtıtle.Text = "Doğalgaz Faturası";
                lblbillamount.Text = elektrikfaturası.ToString() + " ₺";
            }
            if (count % 5 == 3)
            {
                var elektrikfaturası = db.Bills.Where(x => x.BillTıtle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblbilingtıtle.Text = "Su Faturası";
                lblbillamount.Text = elektrikfaturası.ToString() + " ₺";
            }
            if (count % 5 == 4)
            {
                var elektrikfaturası = db.Bills.Where(x => x.BillTıtle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblbilingtıtle.Text = "İnternet Faturası";
                lblbillamount.Text = elektrikfaturası.ToString() + " ₺";
            }
            if (count % 5 == 0)
            {
                var elektrikfaturası = db.Bills.Where(x => x.BillTıtle == "Telefon Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblbilingtıtle.Text = "Telefon Faturası";
                lblbillamount.Text = elektrikfaturası.ToString() + " ₺";
            }

        }

        private void btnbanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks(); 
            frmBanks.ShowDialog();  
            this.Hide();    
        }

        private void btnfaturalar_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();   
            frmBilling.ShowDialog();    
            this.Hide();
        }
    }
}
