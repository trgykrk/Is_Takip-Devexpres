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
    public partial class Frm_FirmaEkle : Form
    {
        public Frm_FirmaEkle()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Firmalar p = new Firmalar();
            p.Firma_Unvan = TxtFirmaUnvan.Text;
            p.Yetkili = TxtFirmaYetkilisi.Text;
            p.Telefon = TxtFirmailetisim.Text;
            p.Mail = TxtFirmaMail.Text;
            p.Sektör = TxtFirmaSektor.Text;
            p.Adres = TxtFirmaAdres.Text;
            p.il = TxtFirmail.Text;
            p.ilce = TxtFirmailce.Text;
            db.Firmalar.Add(p);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Firma Kaydı Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
