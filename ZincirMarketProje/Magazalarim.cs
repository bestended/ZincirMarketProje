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
    public partial class Magazalarim : Form
    {
        MarketlerimContainer con = new MarketlerimContainer();
        public Magazalarim()
        {
            InitializeComponent();
        }

        private void dgw_MagazaBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgw_MagazaBilgi.CurrentRow;

            txt_sehrim.Tag = row.Cells["MagazaId"].Value.ToString();
            txt_sehrim.Text = row.Cells["Sehir"].Value.ToString();
            txt_telefonum.Text = row.Cells["Telefon"].Value.ToString();
            txt_ülkem.Text = row.Cells["Sehir"].Value.ToString();
            txt_plakaNo.Text = row.Cells["AracPlaka"].Value.ToString();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_MagazaBilgi.DataSource = con.MagazalarSet.ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Magazalar m1 = new Magazalar();
            m1.Sehir = txt_sehrim.Text;
            m1.Telefon = txt_telefonum.Text;
            m1.Ulke = txt_ülkem.Text;
            m1.AracPlaka = Convert.ToInt32(txt_plakaNo.Text);

            con.MagazalarSet.Add(m1);
            con.SaveChanges();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_sehrim.Tag);
            var nesne = con.MagazalarSet.Where(i => i.MagazaId == ID).FirstOrDefault();
            nesne.Sehir = txt_sehrim.Text;
            nesne.Telefon = txt_telefonum.Text;
            nesne.Sehir = txt_sehrim.Text;
            con.SaveChanges();
            dgw_MagazaBilgi.DataSource = nesne;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_sehrim.Tag);
            var nesne = con.MagazalarSet.Where(i => i.MagazaId == ID).FirstOrDefault();
            con.MagazalarSet.Remove(nesne);
            con.SaveChanges();
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            dgw_MagazaBilgi.DataSource = con.MagazalarSet.Where(i => i.Ulke == txt_ülkem.Text).ToList();
        }
    }
}
