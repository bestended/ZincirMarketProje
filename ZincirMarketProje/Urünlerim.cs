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
    public partial class Urünlerim : Form
    {

        MarketlerimContainer con = new MarketlerimContainer();
        public Urünlerim()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_ürünBilgi.DataSource = con.UrünlerSet.ToList();


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            Urünler ü1 = new Urünler();
            ü1.ürünCinsi = txt_ürünCins.Text;
            ü1.ürünFiyati =Convert.ToInt32(txt_ürünFiyati.Text);
            ü1.müsteriId= Convert.ToInt32(txt_müsteriId.Text);
            con.UrünlerSet.Add(ü1);
            con.SaveChanges();


        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ürünCins.Tag);
            var nesne = con.UrünlerSet.Where(i=>i.ürünId==id).FirstOrDefault();
            nesne.ürünCinsi = txt_ürünCins.Text;
            nesne.ürünFiyati = Convert.ToInt32(txt_ürünFiyati.Text);
            nesne.müsteriId = Convert.ToInt32(txt_müsteriId.Text);
            con.SaveChanges();
            dgw_ürünBilgi.DataSource = nesne;



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {


            int ID = Convert.ToInt32(txt_ürünCins.Tag);
            var nesne = con.UrünlerSet.Where(i => i.ürünId == ID).FirstOrDefault();
            con.UrünlerSet.Remove(nesne);
            con.SaveChanges();


        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            dgw_ürünBilgi.DataSource = con.UrünlerSet.Where(i => i.ürünCinsi == txt_ürünCins.Text).ToList();

        }

        private void dgw_ürünBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgw_ürünBilgi.CurrentRow;

            txt_ürünCins.Tag = row.Cells["ürünId"].Value.ToString();
            txt_ürünCins.Text = row.Cells["ürünCinsi"].Value.ToString();
            txt_ürünFiyati.Text = row.Cells["ürünFiyati"].Value.ToString();
            txt_müsteriId.Text = row.Cells["MüsteriId"].Value.ToString();
           
        }
    }
}
