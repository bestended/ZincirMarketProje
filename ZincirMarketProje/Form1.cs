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
    public partial class Form1 : Form
    {
        MarketlerimContainer con = new MarketlerimContainer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_müsteriBilgi.DataSource = con.MüsteriSet.ToList();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Müsteri m1 = new Müsteri();
            m1.AdSoyad = txt_adSoyad.Text;
            m1.Telefon = txt_telefon.Text;
            m1.Sehir = txt_sehir.Text;
            con.MüsteriSet.Add(m1);
            con.SaveChanges();

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(txt_adSoyad.Tag);
            var nesne=con.MüsteriSet.Where(i => i.müsteriId == ID).FirstOrDefault();
            nesne.AdSoyad = txt_adSoyad.Text;
            nesne.Telefon = txt_telefon.Text;
            nesne.Sehir = txt_sehir.Text;
            con.SaveChanges();
            dgw_müsteriBilgi.DataSource = nesne;


        }

        private void dgw_müsteriBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgw_müsteriBilgi.CurrentRow;

            txt_adSoyad.Tag = row.Cells["müsteriId"].Value.ToString();
            txt_adSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
            txt_telefon.Text = row.Cells["Telefon"].Value.ToString();
            txt_sehir.Text = row.Cells["Sehir"].Value.ToString();
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_adSoyad.Tag);
            var nesne = con.MüsteriSet.Where(i => i.müsteriId == ID).FirstOrDefault();
            con.MüsteriSet.Remove(nesne);
            con.SaveChanges();
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            dgw_müsteriBilgi.DataSource = con.MüsteriSet.Where(i => i.AdSoyad == txt_adSoyad.Text).ToList();
        }
    }
}
