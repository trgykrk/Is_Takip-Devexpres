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
    public partial class Frm_GorevTanımı : Form
    {
        public Frm_GorevTanımı()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Gorevler g = new Gorevler();
            g.Aciklama = TxtAciklama.Text;
            g.Durum = true;
            g.Tarih = DateTime.Parse(TxtTarih.Text);
            g.Gorev_Alan = int.Parse(lookUpEdit1.EditValue.ToString());
            g.Gorev_Veren = int.Parse(TxtGorevVeren.Text);
            db.Gorevler.Add(g);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başarılı Bir Şekilde Tanımlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
            GorevDetay gd = new GorevDetay();
            gd.Aciklama = TxtAciklama.Text;
            gd.Tarih = DateTime.Parse(TxtTarih.Text);
            gd.Gorev = g.ID;
            db.GorevDetay.Add(gd);
            db.SaveChanges();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_GorevTanımı_Load(object sender, EventArgs e)
        {
            var deger = (from x in db.Personel
                         select new
                         {
                             x.ID,
                             AdSoyad=x.Ad + " " + x.Soyad
                         }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = deger;


        }

       
    }
}
