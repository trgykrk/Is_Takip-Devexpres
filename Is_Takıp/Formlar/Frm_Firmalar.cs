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
    public partial class Frm_Firmalar : Form
    {
        public Frm_Firmalar()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        void Listele()
        {

            var deger = (from x in db.Firmalar
                         select new
                         {
                             x.ID,
                             x.Firma_Unvan,
                             x.Yetkili,
                             x.Telefon,
                             x.Mail,
                             x.Sektör,
                             x.Adres,
                             Bölge=x.ilce + "/" + x.il,
                             x.il,
                             x.ilce
                         }).ToList();

            gridControl1.DataSource = deger;
            gridView1.Columns["ilce"].Visible = false;
            gridView1.Columns["il"].Visible = false;
        }

        private void Frm_Firmalar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtFirmaID.Text);
            var deger = db.Firmalar.Find(x);
            deger.Firma_Unvan = TxtFirmaUnvan.Text;
            deger.Yetkili = TxtFirmaYetkili.Text;
            deger.Telefon = TxtFirmano.Text;
            deger.Mail = TxtFirmamail.Text;
            deger.Sektör = TxtFirmaSektor.Text;
            deger.Adres = TxtFirmaAdres.Text;
            deger.ilce = Txtilce.Text;
            deger.il = Txtil.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Firma Bilgileri Başarılı Bir Şekilde Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtFirmaID.Text);
            var deger = db.Firmalar.Find(x);
            db.Firmalar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Firma Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtFirmaID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtFirmaUnvan.Text = gridView1.GetFocusedRowCellValue("Firma_Unvan").ToString();
            TxtFirmaYetkili.Text = gridView1.GetFocusedRowCellValue("Yetkili").ToString();
            TxtFirmano.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            TxtFirmamail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            TxtFirmaSektor.Text = gridView1.GetFocusedRowCellValue("Sektör").ToString();
            TxtFirmaAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            Txtilce.Text = gridView1.GetFocusedRowCellValue("ilce").ToString();
            Txtil.Text = gridView1.GetFocusedRowCellValue("il").ToString();
            
        }

        
    }
}
