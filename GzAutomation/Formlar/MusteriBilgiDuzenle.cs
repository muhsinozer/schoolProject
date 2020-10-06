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
    public partial class MusteriBilgiDuzenle : Form
    {
        GuzellikSalonuEntities db = new GuzellikSalonuEntities();
        DataGridView dt;
        Musteriler bul;

        public MusteriBilgiDuzenle(string tel, DataGridView dt)
        {
            this.dt = dt;
            InitializeComponent();
            ceptelbul(tel,dt);
        }
        public void ceptelbul(string tel,DataGridView dt)
        {
            this.dt = dt;
            bul = db.Musterilers.Where(x => x.TelCep == tel).FirstOrDefault();
            if (bul != null)
            {
                AdSoyadTxtBox.Text = bul.AdSoyad;
                CepTelTxtBox.Text = bul.TelCep;
                EPostaTxtBox.Text = bul.Eposta;
                try
                {
                    DogumTarihi.Value = (DateTime)bul.DogumTarihi;
                }
                catch
                {
                    DogumTarihi.Value = DogumTarihi.Value;
                }

            }
            else MessageBox.Show("Bulunamadı");
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriBilgiDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            bul.AdSoyad = AdSoyadTxtBox.Text;
            bul.DogumTarihi = DogumTarihi.Value;
            bul.Eposta = EPostaTxtBox.Text;
            bul.TelCep = CepTelTxtBox.Text;
            db.SaveChanges();
            dt.DataSource = db.Musterilers.Select(r => new { r.Id, r.AdSoyad, r.DogumTarihi, r.TelCep, r.Eposta }).OrderBy(x => x.AdSoyad).ToList();
            MessageBox.Show("Değişiklikler kaydedildi.");
            Close();
        }
    }
}
