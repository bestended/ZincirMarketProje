using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZincirMarketProje
{
    public partial class AnaFormMenü : Form
    {
        public AnaFormMenü()
        {
            InitializeComponent();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Depolarim depolarim = new Depolarim();
            depolarim.Show();
        }

        private void btn_market_Click(object sender, EventArgs e)
        {

            Magazalarim magazalarim = new Magazalarim();
            magazalarim.Show();


        }

        private void btn_calisan_Click(object sender, EventArgs e)
        {
            Personellerim personellerim = new Personellerim();
            personellerim.Show();
        }

        private void btn_sevkiyat_Click(object sender, EventArgs e)
        {
            Sevkiyatlarim sevkiyatlarim = new Sevkiyatlarim();
            sevkiyatlarim.Show();



        }

        private void btn_ürünler_Click(object sender, EventArgs e)
        {
            Urünlerim urünlerim = new Urünlerim();
            urünlerim.Show();
            
        }

        private void btn_müsteriler_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            Raporlar rapor = new Raporlar();
            rapor.Show();



        }
    }
}
