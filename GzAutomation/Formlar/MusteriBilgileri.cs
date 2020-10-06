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
    public partial class MusteriBilgileri : Form
    {
        GuzellikSalonuEntities db = new GuzellikSalonuEntities();

        public MusteriBilgileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YMsKaydiBtn_Click(object sender, EventArgs e)
        {
            YeniMusteriKaydi frm = new YeniMusteriKaydi(MsBilgiDataGrid);
            frm.ShowDialog();
        }

        private void MsBilgiDuzenleBtn_Click(object sender, EventArgs e)
        {
            try {
                MusteriBilgiDuzenle mbd = new MusteriBilgiDuzenle(MsBilgiDataGrid.SelectedRows[0].Cells[3].Value.ToString(), MsBilgiDataGrid);
                mbd.ShowDialog();
                mbd.Close();
                }
            catch
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz");
            }
        }

        private void MsKartinaEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriIslemKaydi mik = new MusteriIslemKaydi(MsBilgiDataGrid.SelectedRows[0].Cells[3].Value.ToString(), MsBilgiDataGrid);
                mik.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz");
            }
        }

        private void MsKartiBtn_Click(object sender, EventArgs e)
        {
            try {
                MusteriKarti mk = new MusteriKarti(MsBilgiDataGrid.SelectedRows[0].Cells[3].Value.ToString(), MsBilgiDataGrid);
                mk.ShowDialog();
                }
            catch
            {
                MessageBox.Show("Müşteri Seçiniz");
            }
        }

        private void MsSilBtn_Click(object sender, EventArgs e)
        {
            musterisil();
        }

        public void musterisil()
        {
            DialogResult sonuc = MessageBox.Show("Seçilen müşteri silinsin mi", "Kayıt silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {

                int id = (int)MsBilgiDataGrid.CurrentRow.Cells[0].Value;

                var result1 = db.Musterilers.Where(w => w.Id == id).FirstOrDefault();
                var result2 = db.IslemKaydis.Where(w => w.MusId == id).ToList();
                var result3 = db.Randevulars.Where(w => w.MusId == id).ToList();
                var result4 = db.Borclars.Where(w => w.MusteriId == id).ToList();

                db.Musterilers.Remove(result1);
                db.IslemKaydis.RemoveRange(result2);
                db.Randevulars.RemoveRange(result3);
                db.Borclars.RemoveRange(result4);

                db.SaveChanges();

                var tablo = (from r in db.Musterilers
                             orderby r.AdSoyad
                             select new { r.Id, r.AdSoyad, r.DogumTarihi, r.TelCep, r.Eposta }).ToList();
                MsBilgiDataGrid.DataSource = tablo;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {
            var tablo = (from r in db.Musterilers
                         orderby r.AdSoyad
                         select new { r.Id, r.AdSoyad, r.DogumTarihi, r.TelCep, r.Eposta }).ToList();
            MsBilgiDataGrid.DataSource = tablo;
        }

        private void Aramabox_TextChanged(object sender, EventArgs e)
        {
            var tablo = (from r in db.Musterilers
                         where r.AdSoyad.Contains(SearchTxtBox.Text)
                         orderby r.AdSoyad
                         select new { r.Id, r.AdSoyad, r.DogumTarihi, r.TelCep, r.Eposta }).ToList();
            MsBilgiDataGrid.DataSource = tablo;
        }
    }
}
