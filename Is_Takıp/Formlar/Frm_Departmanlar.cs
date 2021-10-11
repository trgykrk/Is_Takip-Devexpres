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
    public partial class Frm_Departmanlar : Form
    {
        public Frm_Departmanlar()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        void Listele()
        {
            
            var deger = (from x in db.Departmanlar
                         select new
                         {
                             x.ID,
                             x.Departman_Ad
                         }).ToList();

            gridControl1.DataSource = deger;
        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x =int.Parse(TxtDepartmanID.Text);
            var deger = db.Departmanlar.Find(x);
            db.Departmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();

        }

        //Seçilen stunu  textboxlara tasıma//
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtDepartmanID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtDepartmanAd.Text = gridView1.GetFocusedRowCellValue("Departman_Ad").ToString();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtDepartmanID.Text);
            var deger = db.Departmanlar.Find(x);
            deger.Departman_Ad = TxtDepartmanAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }

        private void Frm_Departmanlar_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
