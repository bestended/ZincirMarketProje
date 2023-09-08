using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZincirMarketProje
{
    public partial class Raporlar : Form
    {

        MarketlerimContainer con = new MarketlerimContainer();
        public Raporlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var query = from person in con.PersonellerSet
                        join magaza in con.MagazalarSet
                        on person.MagazaId equals magaza.MagazaId
                        select new
                        {
                            magaza.Ulke,
                            person.AdSoyad,
                            person.Maas

                        };


            dgw_rapor.DataSource = query.ToList();








        }

        private void btn_persAd_girisTarih_sehir_Click(object sender, EventArgs e)
        {


            var query = from person in con.PersonellerSet
                        join magaza in con.MagazalarSet
                        on person.MagazaId equals magaza.MagazaId
                        select new
                        {
                            person.AdSoyad,
                            person.iseGirisTarihi,
                            magaza.Sehir


                        };
            dgw_rapor.DataSource = query.ToList();





        }

        private void btn_persAd_magazaAd_sevkSürücüAd_Click(object sender, EventArgs e)
        {


            var query = from person in con.PersonellerSet
                        join magaza in con.MagazalarSet
                        on person.MagazaId equals magaza.MagazaId
                        join sevk in con.SevkiyatSet
                        on magaza.AracPlaka equals sevk.AracPlaka
                        select new
                        {

                            person.AdSoyad,
                            magaza.Sehir,
                            sevk.SürücüAdSoyad

                        };

            dgw_rapor.DataSource = query.ToList();


        }

        private void btn_girisTarihGruplama_Click(object sender, EventArgs e)
        {

            var query = from ürün in con.UrünlerSet
                        group ürün by ürün.ürünCinsi into ürünler
                        select new
                        {
                            ürünCinsi = ürünler.Key,
                            ürünToplamFiyati = ürünler.Sum(i => i.ürünFiyati)



                        };

            dgw_rapor.DataSource = query.ToList();
        }

        private void btn_cinsFiyatMüsteriAd_Click(object sender, EventArgs e)
        {

            var query = from cins in con.UrünlerSet
                        join müsteri in con.MüsteriSet
                        on cins.müsteriId equals müsteri.müsteriId
                        select new
                        {
                            cins.ürünCinsi,
                            cins.ürünFiyati,
                            müsteri.AdSoyad

                        };
            dgw_rapor.DataSource = query.ToList();




        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            var query = from depo in con.DepolarSet
                        join sevk in con.SevkiyatSet
                        on depo.DepoId equals sevk.DepoId
                        join magaza in con.MagazalarSet
                        on sevk.AracPlaka equals magaza.AracPlaka
                        select new
                        {
                            depo.DepoSorumlusu,
                            sevk.SürücüAdSoyad,
                            sevk.Telefon,
                            magaza.Sehir

                        };

            dgw_rapor.DataSource = query.ToList();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            var query = from depo in con.DepolarSet
                        join ürün in con.UrünlerSet
                        on depo.ürünId equals ürün.ürünId
                        select new
                        {
                            depo.DepoId,
                            depo.ürünIsimleri,
                            ürün.ürünId,
                            ürün.ürünCinsi,
                            ürün.ürünFiyati


                        };

            dgw_rapor.DataSource = query.ToList();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = from depo in con.DepolarSet
                        join ürün in con.UrünlerSet
                        on depo.ürünId equals ürün.ürünId
                        orderby ürün.ürünFiyati

                        select new
                        {
                            depo.ürünIsimleri,
                            ürün.ürünFiyati


                        };
            dgw_rapor.DataSource = query.ToList();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            var query = from müsteri in con.MüsteriSet
                        join ürün in con.UrünlerSet
                        on müsteri.müsteriId equals ürün.müsteriId
                        join depo in con.DepolarSet

                        on ürün.ürünId equals depo.ürünId
                        select new
                        {
                            müsteri.AdSoyad,
                            ürün.ürünCinsi,
                            depo.ürünIsimleri

                        };

            dgw_rapor.DataSource = query.ToList();



        }

        private void button5_Click(object sender, EventArgs e)
        {

            var query = from müsteri in con.MüsteriSet
                        orderby müsteri.Sehir
                        select new
                        {
                            müsteri.AdSoyad,
                            müsteri.Sehir

                        };
            dgw_rapor.DataSource = query.ToList();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ürünAdi = txt_ürünAdi.Text;

            var query = from ürün in con.UrünlerSet

                        where ürün.ürünCinsi == ürünAdi
                        select new
                        {
                            ürün.ürünFiyati,
                            ürün.ürünCinsi

                        };

            dgw_rapor.DataSource = query.ToList();



        }

        private void button7_Click(object sender, EventArgs e)
        {

            var query = from sevk in con.SevkiyatSet
                        select new
                        {
                            sevk.SürücüAdSoyad,
                            sevk.Telefon,
                            sevk.Vardiya,
                            sevk.Maas

                        };

            dgw_rapor.DataSource = query.ToList();

        }

        private void button8_Click(object sender, EventArgs e)
        {


            //var query = con.SevkiyatSet.GroupBy(
            //            i => i.Maas,
            //            i => i.SürücüAdSoyad,
            //            (key, x) => new { Maas = key, SürücüAd = x.ToList() });



            //dgw_rapor.DataSource = query.ToList();



            var query = from sevk in con.SevkiyatSet
                        group sevk by sevk.Maas into grupla
                        select new
                        {
                            Maas=grupla.Key,
                            SürücüAd=grupla.ToList()



                        };

            dgw_rapor.DataSource = query.ToList();


        }

        private void button9_Click(object sender, EventArgs e)
        {

            var query = from sevk in con.SevkiyatSet
                        join magaza in con.MagazalarSet
                        on sevk.AracPlaka equals magaza.AracPlaka
                        select new
                        {
                            sevk.SürücüAdSoyad,
                            sevk.Vardiya,
                            magaza.Ulke,
                            magaza.Sehir


                        };
            dgw_rapor.DataSource = query.ToList();


        }

        private void button10_Click(object sender, EventArgs e)
        {


            var query = from magaza in con.MagazalarSet
                        join person in con.PersonellerSet
                        on magaza.MagazaId equals person.MagazaId
                        select new
                        {
                            magaza.Sehir,
                            person.AdSoyad,
                            person.Maas

                        };
            dgw_rapor.DataSource = query.ToList();



        }

        private void button11_Click(object sender, EventArgs e)
        {
            var query =
                            from magaza in con.MagazalarSet
                      

                            group magaza by magaza.Sehir into grupla
                        select new
                        {
                        
                            MagazaSehir=grupla.Key
                            
                     

                        };

            
            dgw_rapor.DataSource = query.ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var query = from magaza in con.MagazalarSet
                        group magaza by magaza.Sehir into grupMagaza
                        select new
                        {
                         magaza=grupMagaza.Key

                        };

                 dgw_rapor.DataSource = query.ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var query = from magaza in con.MagazalarSet
                        join person in con.PersonellerSet
                        on magaza.MagazaId equals person.MagazaId
                        select new
                        {
                            magaza.Ulke,
                            person.AdSoyad,
                            person.Maas,
                            person.iseGirisTarihi

                        };



                        dgw_rapor.DataSource = query.ToList();

        }
    }




}
