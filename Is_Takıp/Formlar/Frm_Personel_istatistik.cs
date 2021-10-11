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
    public partial class Frm_Personel_istatistik : Form
    {
        public Frm_Personel_istatistik()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        DBTakipEntities db = new DBTakipEntities();

        private void Frm_Personel_istatistik_Load(object sender, EventArgs e)
        {
            LblToplamPersonel.Text = db.Personel.Count().ToString();
            LblToplamDepartman.Text = db.Departmanlar.Count().ToString();
            LblFirma.Text = db.Firmalar.Count().ToString();
            LblAktifis.Text = db.Gorevler.Count(x => x.Durum == true).ToString();
            LblPasifis.Text = db.Gorevler.Count(x => x.Durum == false).ToString();
            LblSonGorev.Text = db.Gorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            LblsonGorevdetay.Text= db.Gorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
            LblSektor.Text = db.Firmalar.Select(x => x.Sektör).Distinct().Count().ToString();
            LblSehir.Text = db.Firmalar.Select(x => x.il).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            LblBugunacilangorevler.Text = db.Gorevler.Count(x => x.Tarih == bugun).ToString();
            var p1 = db.Gorevler.GroupBy(x => x.Gorev_Alan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            LblMvpPersonel.Text = db.Personel.Where(x => x.ID == p1).Select(y => y.Ad + " " + y.Soyad).FirstOrDefault().ToString();
            LblMvpDepartman.Text = db.Departmanlar.Where(x => x.ID == db.Personel.Where(t => t.ID == p1).Select(z => z.P_Departman).FirstOrDefault()).Select(y => y.Departman_Ad).FirstOrDefault().ToString();

        }
    }
}
