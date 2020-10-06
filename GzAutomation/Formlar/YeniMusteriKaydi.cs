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
    public partial class YeniMusteriKaydi : Form
    {

        GuzellikSalonuEntities db = new GuzellikSalonuEntities();
        DataGridView dt;

        public YeniMusteriKaydi(DataGridView dt)
        {
            this.dt = dt;
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.AdSoyad = AdSoyadTxtBox.Text;
            m.DogumTarihi = DgmTarihiPicker.Value;
            m.Eposta = EPostaTxtBox.Text;

            m.TelCep = CepTelTxtBox.Text;
            if (CepTelTxtBox.Text != "")
            {
                db.Musterilers.Add(m);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarılı");
                foreach (var item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox a = (TextBox)item;
                        a.Text = "";
                    }
                }

                var tablo = (from r in db.Musterilers
                             orderby r.AdSoyad
                             select new { r.Id, r.AdSoyad, r.DogumTarihi, r.TelCep, r.Eposta }).ToList();
                dt.DataSource = tablo;



            }
            else MessageBox.Show("Lütfen Cep Telefonu Giriniz");
        }

        private void CepTelTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CepTelTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
