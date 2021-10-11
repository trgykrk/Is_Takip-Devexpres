
namespace Is_Takıp.Formlar
{
    partial class Frm_Personeller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Personeller));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtPersonelGorsel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPersonelSoyad = new DevExpress.XtraEditors.TextEdit();
            this.TxtPersonelMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtPersonelTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PersonelAd = new DevExpress.XtraEditors.LabelControl();
            this.TxtPersonelAd = new DevExpress.XtraEditors.TextEdit();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPersonelID = new DevExpress.XtraEditors.TextEdit();
            this.PersonelID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelGorsel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(971, 416);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.TxtPersonelGorsel);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtPersonelSoyad);
            this.groupControl1.Controls.Add(this.TxtPersonelMail);
            this.groupControl1.Controls.Add(this.TxtPersonelTelefon);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.PersonelAd);
            this.groupControl1.Controls.Add(this.TxtPersonelAd);
            this.groupControl1.Controls.Add(this.BtnGüncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.TxtPersonelID);
            this.groupControl1.Controls.Add(this.PersonelID);
            this.groupControl1.Location = new System.Drawing.Point(977, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(343, 416);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = " ";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "";
            this.lookUpEdit1.Location = new System.Drawing.Point(108, 183);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(224, 20);
            this.lookUpEdit1.TabIndex = 18;
            // 
            // TxtPersonelGorsel
            // 
            this.TxtPersonelGorsel.Location = new System.Drawing.Point(108, 209);
            this.TxtPersonelGorsel.Name = "TxtPersonelGorsel";
            this.TxtPersonelGorsel.Size = new System.Drawing.Size(224, 20);
            this.TxtPersonelGorsel.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 216);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Görsel:";
            // 
            // TxtPersonelSoyad
            // 
            this.TxtPersonelSoyad.Location = new System.Drawing.Point(108, 97);
            this.TxtPersonelSoyad.Name = "TxtPersonelSoyad";
            this.TxtPersonelSoyad.Size = new System.Drawing.Size(224, 20);
            this.TxtPersonelSoyad.TabIndex = 14;
            // 
            // TxtPersonelMail
            // 
            this.TxtPersonelMail.Location = new System.Drawing.Point(108, 125);
            this.TxtPersonelMail.Name = "TxtPersonelMail";
            this.TxtPersonelMail.Size = new System.Drawing.Size(224, 20);
            this.TxtPersonelMail.TabIndex = 13;
            // 
            // TxtPersonelTelefon
            // 
            this.TxtPersonelTelefon.Location = new System.Drawing.Point(108, 154);
            this.TxtPersonelTelefon.Name = "TxtPersonelTelefon";
            this.TxtPersonelTelefon.Size = new System.Drawing.Size(224, 20);
            this.TxtPersonelTelefon.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 186);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Departmanı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 157);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Telefon:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Soyadı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mail:";
            // 
            // PersonelAd
            // 
            this.PersonelAd.Location = new System.Drawing.Point(27, 71);
            this.PersonelAd.Name = "PersonelAd";
            this.PersonelAd.Size = new System.Drawing.Size(19, 13);
            this.PersonelAd.TabIndex = 7;
            this.PersonelAd.Text = "Adı:";
            // 
            // TxtPersonelAd
            // 
            this.TxtPersonelAd.Location = new System.Drawing.Point(108, 68);
            this.TxtPersonelAd.Name = "TxtPersonelAd";
            this.TxtPersonelAd.Size = new System.Drawing.Size(224, 20);
            this.TxtPersonelAd.TabIndex = 6;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(143, 374);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(195, 23);
            this.BtnGüncelle.TabIndex = 5;
            this.BtnGüncelle.Text = "GÜNCELLE";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(143, 316);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(195, 23);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(143, 258);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(195, 23);
            this.BtnListele.TabIndex = 2;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtPersonelID
            // 
            this.TxtPersonelID.Location = new System.Drawing.Point(108, 42);
            this.TxtPersonelID.Name = "TxtPersonelID";
            this.TxtPersonelID.Size = new System.Drawing.Size(224, 20);
            this.TxtPersonelID.TabIndex = 1;
            // 
            // PersonelID
            // 
            this.PersonelID.Location = new System.Drawing.Point(27, 45);
            this.PersonelID.Name = "PersonelID";
            this.PersonelID.Size = new System.Drawing.Size(61, 13);
            this.PersonelID.TabIndex = 0;
            this.PersonelID.Text = "Personel IDı:";
            // 
            // Frm_Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 418);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_Personeller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Frm_Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelGorsel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl PersonelAd;
        private DevExpress.XtraEditors.TextEdit TxtPersonelAd;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.TextEdit TxtPersonelID;
        private DevExpress.XtraEditors.LabelControl PersonelID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit TxtPersonelGorsel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtPersonelSoyad;
        private DevExpress.XtraEditors.TextEdit TxtPersonelMail;
        private DevExpress.XtraEditors.TextEdit TxtPersonelTelefon;
    }
}