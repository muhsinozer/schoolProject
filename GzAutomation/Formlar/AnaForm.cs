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
    public partial class AnaForm : Form
    {
        GuzellikSalonuEntities db = new GuzellikSalonuEntities();
        Randevular rdn = new Randevular();

        public AnaForm()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MislemleriBtn_Click(object sender, EventArgs e)
        {
            MusteriBilgileri frm = new MusteriBilgileri();
            frm.ShowDialog();
        }

        private void RndVerBtn_Click(object sender, EventArgs e)
        {
            Randevu rd = new Randevu(MsRndDataGrid);
            rd.ShowDialog();
        }

        private void HRndVerBtn_Click(object sender, EventArgs e)
        {
            HizliRandevu hrn = new HizliRandevu(MsRndDataGrid);
            hrn.ShowDialog();
        }

        private void GeldiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(MsRndDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                var secili = (from x in db.Randevulars
                              where x.Id == id
                              select x).FirstOrDefault();
                secili.Durum = "Geldi";
                db.SaveChanges();
                //MessageBox.Show("müşterinin geldiğini onayladınız");
                var tablo = (from r in db.Randevulars
                             join m in db.Musterilers on r.MusId equals m.Id
                             orderby r.Saat
                             where r.Tarih.Day == DateTime.Now.Day &&
                             r.Tarih.Month == DateTime.Now.Month &&
                             r.Tarih.Year == DateTime.Now.Year
                             select new { r.Id, m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem, m.TelCep }
                             ).ToList();
                MsRndDataGrid.DataSource = tablo;
            }
            catch
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz");
            }
        }

        private void GelmediBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(MsRndDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                var secili = (from x in db.Randevulars
                              where x.Id == id
                              select x).FirstOrDefault();
                secili.Durum = "Gelmedi";
                db.SaveChanges();
                //MessageBox.Show("müşterinin gelmediğini onayladınız");
                var tablo = (from r in db.Randevulars
                             join m in db.Musterilers on r.MusId equals m.Id
                             orderby r.Saat
                             where r.Tarih.Day == DateTime.Now.Day &&
                             r.Tarih.Month == DateTime.Now.Month &&
                             r.Tarih.Year == DateTime.Now.Year
                             select new { r.Id, m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem, m.TelCep }
                           ).ToList();
                MsRndDataGrid.DataSource = tablo;
            }
            catch
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz");
            }
        }

        private void IptalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(MsRndDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                var secili = (from x in db.Randevulars
                              where x.Id == id
                              select x).FirstOrDefault();
                secili.Durum = "İptal";
                db.SaveChanges();
                //MessageBox.Show("Randevunun iptal edildiğini onayladınız");
                var tablo = (from r in db.Randevulars
                             join m in db.Musterilers on r.MusId equals m.Id
                             orderby r.Saat

                             where r.Tarih.Day == DateTime.Now.Day &&
                             r.Tarih.Month == DateTime.Now.Month &&
                             r.Tarih.Year == DateTime.Now.Year
                             select new { r.Id, m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem, m.TelCep }
                           ).ToList();
                MsRndDataGrid.DataSource = tablo;
            }
            catch
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            var tablo = (from r in db.Randevulars
                         join m in db.Musterilers on r.MusId equals m.Id
                         orderby r.Saat
                         where r.Tarih.Day == DateTime.Now.Day &&
                         r.Tarih.Month == DateTime.Now.Month &&
                         r.Tarih.Year == DateTime.Now.Year
                         select new { r.Id, m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem, m.TelCep }
                       ).ToList();
            MsRndDataGrid.DataSource = tablo;
            MsRndDataGrid.RowHeadersWidth = 20;
        }

        private void BugunkuRndBtn_Click(object sender, EventArgs e)
        {
            var tablo = (from r in db.Randevulars
                         join m in db.Musterilers on r.MusId equals m.Id
                         orderby r.Saat
                         where r.Tarih.Day == DateTime.Now.Day &&
                         r.Tarih.Month == DateTime.Now.Month &&
                         r.Tarih.Year == DateTime.Now.Year
                         select new { r.Id, m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem, m.TelCep }
                      ).ToList();
            MsRndDataGrid.DataSource = tablo;
            MsRndDataGrid.RowHeadersWidth = 20;
            groupBox1.Text = "Bugün Randevusu Olan Müşteriler";
        }

        private void BuAykiRndBtn_Click(object sender, EventArgs e)
        {
            var tablo = (from r in db.Randevulars
                         join m in db.Musterilers on r.MusId equals m.Id
                         orderby r.Tarih
                         where r.Tarih.Month == DateTime.Now.Month &&
                         r.Tarih.Month == DateTime.Now.Month &&
                         r.Tarih.Year == DateTime.Now.Year
                         select new { r.Id, m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem, m.TelCep }
                      ).ToList();
            MsRndDataGrid.DataSource = tablo;
            MsRndDataGrid.RowHeadersWidth = 20;
            groupBox1.Text = "Bu Ay Randevusu Olan Müşteriler";
        }

        private void TarihSec_ValueChanged(object sender, EventArgs e)
        {
            Randevular re = new Randevular();
            DateTime dt = this.TarihSec.Value.Date;
            var tablo = (from r in db.Randevulars
                         join m in db.Musterilers on r.MusId equals m.Id
                         orderby r.Tarih
                         where r.Tarih == dt
                         select new { r.Id, m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem, m.TelCep }
                     ).ToList();
            MsRndDataGrid.DataSource = tablo;
            MsRndDataGrid.RowHeadersWidth = 20;
            groupBox1.Text = dt.ToShortDateString() + "  Tarihinde Randevusu Olan Müşteriler";
        }
    }
}
