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
    public partial class Frm_Personeller : Form
    {
        public Frm_Personeller()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        void PersonelListesi()
        {
            var degerler = (from x in db.Personel
                            select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Mail,
                               x.Telefon,
                               Departman=x.Departmanlar.Departman_Ad,
                               x.Durum
                           });

            gridControl1.DataSource = degerler.Where(x=>x.Durum==true).ToList();
        }
        private void Frm_Personeller_Load(object sender, EventArgs e)
        {
            PersonelListesi();

            var departmanlar = (from x in db.Departmanlar
                                select new
                                {
                                    x.ID,
                                    x.Departman_Ad
                                }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Departman_Ad";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            PersonelListesi();
        }

       

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(TxtPersonelID.Text);
            var deger = db.Personel.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel Silme İşlemi Başarılı Bir Şekilde Gerçekleşmiştir.Silinen Personel Listesinden Silinen Tüm Personel Bilgilerine  Ulaşabilirsiniz .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PersonelListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtPersonelID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtPersonelAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtPersonelSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtPersonelTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            TxtPersonelMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            lookUpEdit1.Text= gridView1.GetFocusedRowCellValue("Departman").ToString();

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtPersonelID.Text);
            var deger = db.Personel.Find(x);
            deger.Ad = TxtPersonelAd.Text;
            deger.Soyad = TxtPersonelSoyad.Text;
            deger.Telefon = TxtPersonelTelefon.Text;
            deger.Mail = TxtPersonelMail.Text;
            deger.Gorsel = TxtPersonelGorsel.Text;
            deger.P_Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Personel Bilgileri Başarılı Bir Şekilde Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListesi();

        }
    }
}
