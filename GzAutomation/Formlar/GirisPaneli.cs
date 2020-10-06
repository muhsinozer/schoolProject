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
    public partial class GirisPaneli : Form
    {
        GuzellikSalonuEntities db = new GuzellikSalonuEntities();

        public GirisPaneli()
        {
            InitializeComponent();
        }


        private void EnterButton_Click(object sender, EventArgs e)
        {
            login();
        }


        public void login()
        {
            var yenikullanici = db.Kullanicilars.Where(x => x.Kuladi == logintxtbox.Text && x.Sifre == passwordtxtbox.Text).SingleOrDefault();
            if (yenikullanici == null)
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (yenikullanici != null)
            {
                AnaForm af = new AnaForm();
                af.Show();
                this.Hide();
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
