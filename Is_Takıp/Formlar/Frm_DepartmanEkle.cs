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
    public partial class Frm_DepartmanEkle : Form
    {
        public Frm_DepartmanEkle()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Departmanlar dep = new Departmanlar();
            dep.Departman_Ad = TxtDepartmanAd.Text;
            db.Departmanlar.Add(dep);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Başarılı Bir Şekilde Sisteme  Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
