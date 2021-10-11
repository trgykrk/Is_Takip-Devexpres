using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Is_Takıp.Entity;

namespace Is_Takıp.Formlar
{
    public partial class Frm_GorevListesi : Form
    {
        public Frm_GorevListesi()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        private void Frm_GorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Gorevler
                                       select new
                                       {                            
                                           x.ID,
                                           Gorev_Alan=x.Personel1.Ad +" "+ x.Personel1.Soyad,
                                           Gorev_Veren=x.Personel.Ad +" "+ x.Personel.Soyad,
                                           x.Aciklama
                                       }).ToList();
            LblAktifGorev.Text = db.Gorevler.Where(x => x.Durum == true).Count().ToString();
            LblPasifGorev.Text = db.Gorevler.Where(x => x.Durum == false).Count().ToString();
            LblToplamDepartman.Text = db.Departmanlar.Count().ToString();



            chartControl1.Series["Gorev Durumu"].Points.AddPoint("Aktif Görevler", int.Parse(LblAktifGorev.Text));
            chartControl1.Series["Gorev Durumu"].Points.AddPoint("Tamamlanan  Görevler", int.Parse(LblPasifGorev.Text));

        }
    }
}
