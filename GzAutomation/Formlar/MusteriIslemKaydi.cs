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
    public partial class MusteriIslemKaydi : Form
    {

        GuzellikSalonuEntities db = new GuzellikSalonuEntities();
        DataGridView dt;
        Musteriler bul;
        IslemKaydi ik = new IslemKaydi();
        Borclar bor = new Borclar();
        int musteri_id;

        public MusteriIslemKaydi(string tel,DataGridView dt)
        {
            this.dt = dt;
            InitializeComponent();
            ceptelbul(tel, dt);
        }

        public void ceptelbul(string tel,DataGridView dt)
        {
            bul = db.Musterilers.Where(x => x.TelCep == tel).FirstOrDefault();
            MsAdSoyadTxtBox.Text = bul.AdSoyad;
            MsCepTelTxtBox.Text = bul.TelCep;
        }

        public void kaydet()
        {
            var tablo = (from x in db.Musterilers
                         where x.TelCep == MsCepTelTxtBox.Text
                         select x).FirstOrDefault();
            musteri_id = tablo.Id;

            ik.IslemTarihi = islemtarihi.Value;
            bor.TarihSaat = islemtarihi.Value;
            ik.UygIslem = UygIslemTxtBox.Text;
            ik.MusId = musteri_id;
            bor.MusteriId = musteri_id;
            ik.AlinanUcret = Convert.ToDecimal(AlinanUcretTxtBox.Text);
            ik.Note = NotTxtBox.Text;
            bor.Note = NotTxtBox.Text;
            db.IslemKaydis.Add(ik);
            db.Borclars.Add(bor);
            db.SaveChanges();
            MessageBox.Show("Kayıt başarılı");
        }
        private void VazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriIslemKaydi_Load(object sender, EventArgs e)
        {

        }

        private void AlinanUcretTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlinanUcretTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
