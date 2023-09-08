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
    public partial class Depolarim : Form
    {
        MarketlerimContainer con = new MarketlerimContainer();
        public Depolarim()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {


            dgw_DepoBilgi.DataSource = con.DepolarSet.ToList();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Depolar d1 = new Depolar();
            d1.ürünIsimleri= txt_ürünIsim.Text;
            d1.DepoSorumlusu = txt_depoSorumlusu.Text;
            d1.ürünId=Convert.ToInt32(txt_ürünId.Text);



            con.DepolarSet.Add(d1);
            con.SaveChanges();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(txt_ürünIsim.Tag);
            var nesne = con.DepolarSet.Where(i => i.DepoId == ID).FirstOrDefault();
            nesne.ürünIsimleri = txt_ürünIsim.Text;
            nesne.DepoSorumlusu = txt_depoSorumlusu.Text;
            nesne.ürünId= Convert.ToInt32(txt_ürünId.Text);
            con.SaveChanges();
            dgw_DepoBilgi.DataSource = nesne;
        }

        private void dgw_DepoBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgw_DepoBilgi.CurrentRow;

            txt_ürünIsim.Tag = row.Cells["DepoId"].Value.ToString();
            txt_ürünIsim.Text = row.Cells["ürünIsimleri"].Value.ToString();
            txt_depoSorumlusu.Text = row.Cells["DepoSorumlusu"].Value.ToString();
            txt_ürünId.Text= row.Cells["ürünId"].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_ürünIsim.Tag);
            var nesne = con.DepolarSet.Where(i => i.ürünId == ID).FirstOrDefault();
            con.DepolarSet.Remove(nesne);
            con.SaveChanges();
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            dgw_DepoBilgi.DataSource = con.DepolarSet.Where(i => i.ürünIsimleri == txt_ürünIsim.Text).ToList();

        }

        private void cmb_ürünId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
