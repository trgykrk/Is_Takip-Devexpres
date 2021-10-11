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
    public partial class Frm_Anaform : Form
    {
        public Frm_Anaform()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        private void Frm_Anaform_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Gorevler
                                       select new
                                       {
                                           x.Aciklama,
                                          Sorumlu= x.Personel1.Ad + " " + x.Personel1.Soyad,
                                          x.Durum
                                           
                                       }).Where(y=>y.Durum==true).ToList();

            gridView1.Columns["Durum"].Visible = false;

            //Bugün Yapılan Görevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());

            gridControl2.DataSource = (from x in db.GorevDetay
                                       select new
                                       {
                                           Görev = x.Gorevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih
                                       }).Where(x => x.Tarih == bugun).ToList();

            gridControl3.DataSource = (from x in db.Gorevler
                                       select new
                                       {
                                           x.ID,
                                           x.Aciklama,
                                           Sorumlu = x.Personel1.Ad + " " + x.Personel1.Soyad,
                                           x.Durum
                                       }).Where(x => x.Durum == false).ToList();

            gridView3.Columns["Durum"].Visible = false;



        }

       
    }
}
