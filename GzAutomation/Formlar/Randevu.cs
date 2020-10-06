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
    public partial class Randevu : Form
    {
        GuzellikSalonuEntities db = new GuzellikSalonuEntities();
        Musteriler bul;
        DataGridView dt;
        string tel;
        int musid;
        List<Button> butonlar = new List<Button>();
        List<string> isaretlenmis = new List<string>();

        public Randevu(DataGridView dt)
        {
            this.dt = dt;
            InitializeComponent();
        }

        public void musterikontrol()
        {
            tel = MsCepTelTxtbox.Text;
            bul = db.Musterilers.Where(x => x.TelCep == tel).FirstOrDefault();
            if (bul != null)
            {
                var tablo = (from x in db.Musterilers
                             where x.TelCep == MsCepTelTxtbox.Text
                             select x).FirstOrDefault();
                musid = tablo.Id;
                var tablo2 = (from x in db.Musterilers
                              where x.TelCep == MsCepTelTxtbox.Text
                              select new { x.AdSoyad, x.DogumTarihi, x.TelCep, x.Eposta }).ToList();
                MsBilDataGrid.DataSource = tablo2;
            }
            else if (bul == null) MessageBox.Show("Müşteri bulunamadı");

        }
        private void randevuver(DateTime date, string saat)
        {
            Randevular rdn = new Randevular();
            rdn.SecilenSaatler = "";
            rdn.MusId = musid;
            rdn.Islem = YapIslemTxtBox.Text;
            foreach (var item in isaretlenmis)
            {
                rdn.SecilenSaatler += item.ToString() + ",";
            }
            rdn.SecilenSaatler.Trim(',');
            rdn.Tarih = date;
            rdn.Saat = isaretlenmis[0].ToString();
            rdn.Durum = "Bekleniyor";
            db.Randevulars.Add(rdn);
            db.SaveChanges();



            var tablo = (from r in db.Randevulars
                         join m in db.Musterilers on r.MusId equals m.Id
                         orderby r.Saat
                         where r.Tarih.Day == DateTime.Now.Day &&
                         r.Tarih.Month == DateTime.Now.Month &&
                         r.Tarih.Year == DateTime.Now.Year
                         select new { r.Id, m.AdSoyad, r.Tarih, r.Saat, r.Durum, r.Islem, m.TelCep }
                        ).ToList();
            dt.DataSource = tablo;
            MessageBox.Show("Randevu kaydı Başarılı");
            Close();
        }

        public void rndsaat()
        {
            List<string> d1 = new List<string>();
            d1.Add("00");
            d1.Add("15");
            d1.Add("30");
            d1.Add("45");
            DateTime a = new DateTime();
            a = DateTime.Parse(RndTarihDTPicker.Value.ToString("yyyy-MM-dd"));
            var result = (from x in db.Randevulars
                          where x.Tarih == a
                          orderby x.Saat
                          select new { x.SecilenSaatler }).ToList();
            Randevular rdn = new Randevular();
            int say = 0;
            int say2 = 09;
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    Button b = new Button();
                    b.Location = new Point(j * 50, i * 50);
                    b.Size = new Size(50, 50);
                    if (say2 != 9)
                        b.Text = say2.ToString() + " : " + d1[say];
                    else b.Text = "09 : " + d1[say];
                    b.BackColor = Color.White;
                    say++;
                    int newSize = 8;
                    b.Font = new Font(b.Font.FontFamily, newSize);
                    if (say >= 4)
                    {
                        say2 += 1;
                        say = 0;
                    }
                    RndSaatGrpBox.Controls.Add(b);
                    b.Click += new EventHandler(b_Click);//b.Click diyerek tıklama özelliğine bir event tanımladık.
                }
            }


            foreach (var item in result)
            {
                foreach (var saatler in item.SecilenSaatler.Split(','))
                {
                    foreach (Button b in RndSaatGrpBox.Controls)
                    {
                        if (b.Text == saatler)
                        {
                            b.Visible = false;
                        }
                    }
                }
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DateTime date = RndTarihDTPicker.Value;
            string saat = btn.Text;
            if (btn.BackColor != Color.Green)
            {
                isaretlenmis.Add(saat);
                btn.BackColor = Color.Green;
            }
            else
            {
                btn.BackColor = Color.White;
                isaretlenmis.Remove(saat);
            }

        }

        private void KontrolBtn_Click(object sender, EventArgs e)
        {
            musterikontrol();
        }

        private void VazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Randevu_Load(object sender, EventArgs e)
        {

        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                randevuver(RndTarihDTPicker.Value, isaretlenmis[0].ToString());
            }
            catch
            {
                MessageBox.Show("Lütfen Randevu saati seçiniz");
            }

        }

        private void RndTarihDTPicker_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in RndSaatGrpBox.Controls)
            {
                RndSaatGrpBox.Controls.Remove((Control)item);
            }
            rndsaat();

        }
    }
}
