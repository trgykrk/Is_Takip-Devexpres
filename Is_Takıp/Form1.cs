using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_Takıp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frm_Departmanlar frm1 = new Formlar.Frm_Departmanlar();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frm_Personeller frm2 = new Formlar.Frm_Personeller();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frm_Personel_istatistik frm3 = new Formlar.Frm_Personel_istatistik();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frm_GorevListesi frm4 = new Formlar.Frm_GorevListesi();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frm_GorevTanımı frm5 = new Formlar.Frm_GorevTanımı();
            frm5.Show();
        }

        Formlar.Frm_GorevDetay frm6;
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new Formlar.Frm_GorevDetay();
                frm6.Show();
            }
        }

        Formlar.Frm_Anaform frm7;
        private void BtnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7==null || frm7.IsDisposed) 
            {
                frm7 = new Formlar.Frm_Anaform();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }

        Formlar.Frm_PersonelEkle frm8;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new Formlar.Frm_PersonelEkle();      
                frm8.Show();
            }
        }
        Formlar.Frm_DepartmanEkle frm9;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new Formlar.Frm_DepartmanEkle();
                frm9.Show();
            }
        }

        Formlar.Frm_TamamlananGorev frm10;
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new Formlar.Frm_TamamlananGorev();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }

        Formlar.Frm_aktifGorevler frm11;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm11 == null || frm11.IsDisposed)
            {
                frm11 = new Formlar.Frm_aktifGorevler();
                frm11.MdiParent = this;
                frm11.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Formlar.Frm_Firmalar frm12;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Formlar.Frm_Firmalar();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frm_FirmaEkle frm13 = new Formlar.Frm_FirmaEkle();
            frm13.Show();
        }
    }
}
