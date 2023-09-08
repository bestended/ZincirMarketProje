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
    public partial class Sevkiyatlarim : Form
    {
        MarketlerimContainer con = new MarketlerimContainer();
        public Sevkiyatlarim()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_sevkiyatBilgi.DataSource = con.SevkiyatSet.ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Sevkiyat p1 = new Sevkiyat();

            p1.SürücüAdSoyad = txt_sürücüAdSoyad.Text;
            p1.Telefon = txt_telefon.Text;
            p1.Maas = Convert.ToInt32(txt_maas.Text);
            p1.Vardiya = txt_vardiya.Text;
            p1.DepoId = Convert.ToInt32(txt_depoId.Text);
            con.SevkiyatSet.Add(p1);
            con.SaveChanges();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_sürücüAdSoyad.Tag);
            var nesne = con.SevkiyatSet.Where(i => i.AracPlaka == ID).FirstOrDefault();
            nesne.SürücüAdSoyad = txt_sürücüAdSoyad.Text;
            nesne.Telefon = txt_telefon.Text;
            nesne.Maas = Convert.ToInt32(txt_maas.Text);
            nesne.Vardiya = txt_vardiya.Text;
            nesne.DepoId = Convert.ToInt32(txt_depoId.Text);
            con.SaveChanges();
            dgw_sevkiyatBilgi.DataSource = nesne;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_sürücüAdSoyad.Tag);
            var nesne = con.SevkiyatSet.Where(i => i.AracPlaka == ID).FirstOrDefault();
            con.SevkiyatSet.Remove(nesne);
            con.SaveChanges();
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            dgw_sevkiyatBilgi.DataSource = con.SevkiyatSet.Where(i => i.SürücüAdSoyad == txt_sürücüAdSoyad.Text).ToList();

        }

        private void dgw_sevkiyatBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgw_sevkiyatBilgi.CurrentRow;

            txt_sürücüAdSoyad.Tag = row.Cells["AracPlaka"].Value.ToString();
            txt_sürücüAdSoyad.Text = row.Cells["SürücüAdSoyad"].Value.ToString();
            txt_telefon.Text = row.Cells["telefon"].Value.ToString();
            txt_maas.Text = row.Cells["maas"].Value.ToString();
            txt_vardiya.Text = row.Cells["vardiya"].ToString();
            txt_depoId.Text = row.Cells["depoId"].Value.ToString();



        }
    }
}
