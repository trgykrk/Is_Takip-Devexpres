using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Is_Takıp.Entity;

namespace Is_Takıp.Formlar
{
    public partial class Frm_KullaniciGirisi : Form
    {
        public Frm_KullaniciGirisi()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            var login = db.Admin.Where(x => x.Kullanici == TxtKullaniciAdi.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();

            if (login != null)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı veya Şifre yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
