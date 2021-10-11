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
    public partial class Frm_PersonelEkle : Form
    {
        public Frm_PersonelEkle()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Ad = TxtPersonelAd.Text;
            p.Soyad = TxtPersonelSoyad.Text;
            p.Telefon = TxtPersoneliletisim.Text;
            p.Mail = TxtPersonelMail.Text;
            p.P_Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            p.Gorsel = TxtPersonelGorsel.Text;
            p.Durum = true;
            db.Personel.Add(p);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Personel Kaydı Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Frm_PersonelEkle_Load(object sender, EventArgs e)
        {
            var deger = (from x in db.Departmanlar
                         select new
                         {
                             x.ID,
                             Departman=x.Departman_Ad
                         }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Departman";
            lookUpEdit1.Properties.DataSource = deger;

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
