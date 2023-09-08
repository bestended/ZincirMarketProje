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
    public partial class Personellerim : Form
    {
        MarketlerimContainer con = new MarketlerimContainer();
        public Personellerim()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_personelBilgi.DataSource = con.PersonellerSet.ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Personeller p1 = new Personeller();
            p1.AdSoyad = txt_adSoyad.Text;
            p1.Sehir = txt_sehir.Text;
            p1.Maas = Convert.ToInt32(txt_maas.Text);
            p1.iseGirisTarihi = Convert.ToDateTime(dtp_iseGirisTarih.Text);
            p1.MagazaId = Convert.ToInt32(txt_magazaId.Text);

            con.PersonellerSet.Add(p1);
            con.SaveChanges();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_adSoyad.Tag);
            var nesne = con.PersonellerSet.Where(i => i.personelId == ID).FirstOrDefault();
            nesne.AdSoyad = txt_adSoyad.Text;
            nesne.Sehir = txt_sehir.Text;
            nesne.Maas = Convert.ToInt32(txt_maas.Text);
            nesne.iseGirisTarihi = Convert.ToDateTime(txt_sehir.Text);
            nesne.MagazaId = Convert.ToInt32(txt_magazaId.Text);
            con.SaveChanges();
            dgw_personelBilgi.DataSource = nesne;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_adSoyad.Tag);
            var nesne = con.PersonellerSet.Where(i => i.personelId == ID).FirstOrDefault();
            con.PersonellerSet.Remove(nesne);
            con.SaveChanges();
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            dgw_personelBilgi.DataSource = con.PersonellerSet.Where(i => i.AdSoyad == txt_adSoyad.Text).ToList();

        }

        private void dgw_personelBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgw_personelBilgi.CurrentRow;

            txt_adSoyad.Tag = row.Cells["personelId"].Value.ToString();
            txt_adSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
            txt_sehir.Text = row.Cells["Sehir"].Value.ToString();
            txt_maas.Text = row.Cells["Maas"].Value.ToString();
            dtp_iseGirisTarih.Text = row.Cells["iseGirisTarihi"].ToString();
            txt_magazaId.Text = row.Cells["MagazaId"].Value.ToString();


        }
    }
}
