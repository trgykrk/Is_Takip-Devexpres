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
    public partial class Frm_aktifGorevler : Form
    {
        public Frm_aktifGorevler()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        private void Frm_aktifGorevler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Gorevler
                                       select new
                                       {
                                           x.Aciklama,
                                           Olusturan = x.Personel.Ad + " " + x.Personel.Soyad,
                                           Sorumlu = x.Personel1.Ad + " " + x.Personel1.Soyad,
                                           x.Tarih,
                                           x.Durum

                                       }).Where(y => y.Durum == true).ToList();

            gridView1.Columns["Durum"].Visible = false;
        }
    }
}
