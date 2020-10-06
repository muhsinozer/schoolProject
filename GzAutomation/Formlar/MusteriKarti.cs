using GzAutomation.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GzAutomation.Formlar
{
    public partial class MusteriKarti : Form
    {
        Musteriler bul;
        GuzellikSalonuEntities db = new GuzellikSalonuEntities();
        DataGridView dt;

        string telcep;
        int musteri_id;
        string tel;

        public MusteriKarti(string tel,DataGridView dt)
        {

            this.dt = dt;
            this.tel = tel;
            bul = db.Musterilers.Where(x => x.TelCep == tel).FirstOrDefault();
            InitializeComponent();
        }

        
        public void musterigetir()
        {
            var msbilgitablo = (from r in db.Musterilers
                         orderby r.AdSoyad
                         select new { r.AdSoyad, r.DogumTarihi, r.TelCep, r.Eposta }).ToList();
            MsBiDataGrid.DataSource = msbilgitablo;

            telcep = tel;
            var IdBulmaTablo = (from x in db.Musterilers
                          where x.TelCep == telcep
                          select x).FirstOrDefault();
            musteri_id = IdBulmaTablo.Id;

            var islemkayditablo= (from x in db.IslemKaydis
                                  join m in db.Musterilers
                                  on x.MusId equals m.Id
                                  where x.MusId == musteri_id
                                  select new
                                  {
                                      m.AdSoyad,
                                      x.UygIslem,
                                      x.AlinanUcret,
                                      x.Note,
                                      x.IslemTarihi
                                  }).ToList();

            MsIslemDataGrid.DataSource = islemkayditablo;
            MsIslemDataGrid.Columns[1].Width = 750;
            MsIslemDataGrid.Columns[2].Width = 64;
            MsIslemDataGrid.Columns[3].Width = 155;
            MsIslemDataGrid.Columns[4].Width = 64;
            MsIslemDataGrid.RowHeadersWidth = 20;

            var randevubilgitablo= (from r in db.Randevulars
                                    join m in db.Musterilers
                                    on r.MusId equals m.Id
                                    where r.MusId == musteri_id
                                    orderby r.Saat
                                    select new { m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem }
                       ).ToList();
            MsRndDataGrid.DataSource = randevubilgitablo;
            MsRndDataGrid.Columns[2].Width = 70;

        }
        private void MusteriKarti_Load(object sender, EventArgs e)
        {
            musterigetir();

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            var tablo = (from r in db.Musterilers
                         where r.AdSoyad.Contains(SearchTxtBox.Text)
                         orderby r.AdSoyad
                         select new { r.AdSoyad, r.DogumTarihi, r.TelCep, r.Eposta }).ToList();
            MsBiDataGrid.DataSource = tablo;
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {

        }
        public void kayitgetir()
        {
            telcep = MsBiDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            var tablo = (from x in db.Musterilers
                         where x.TelCep == telcep
                         select x).FirstOrDefault();

            musteri_id = tablo.Id;

            var tablo2 = (from x in db.IslemKaydis
                          join m in db.Musterilers
                          on x.MusId equals m.Id
                          where x.MusId == musteri_id
                          select new
                          {
                              m.AdSoyad,
                              x.UygIslem, /*x.UygUrun,*/ /*x.IslemUcreti,*/
                              x.AlinanUcret, /*x.KalanUcret,*/ /*x.Sonuc, */
                              x.Note,
                              x.IslemTarihi
                          }).ToList();
            //burada müşterinin isteği doğrultusunda yorum satırı yapılan yerler iptal edildi.
            //
            MsIslemDataGrid.DataSource = tablo2;
            MsIslemDataGrid.Columns[1].Width = 750;
            MsIslemDataGrid.Columns[2].Width = 64;
            MsIslemDataGrid.Columns[3].Width = 155;
            MsIslemDataGrid.Columns[4].Width = 64;
            MsIslemDataGrid.Columns[7].Width = 60;
            MsIslemDataGrid.RowHeadersWidth = 20;
            

            telcep = tel;
            var tablo1 = (from x in db.Musterilers
                          where x.TelCep == telcep
                          select x).FirstOrDefault();

            var tablo3 = (from r in db.Randevulars
                          join m in db.Musterilers
                          on r.MusId equals m.Id
                          where r.MusId == musteri_id
                          orderby r.Saat
                          select new { m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem }
                       ).ToList();


            MsRndDataGrid.DataSource = tablo3;
        }
    }
}
