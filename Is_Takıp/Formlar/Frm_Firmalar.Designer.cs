
namespace Is_Takıp.Formlar
{
    partial class Frm_Firmalar
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Firmalar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txtil = new DevExpress.XtraEditors.TextEdit();
            this.Txtilce = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtFirmaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFirmaAdres = new DevExpress.XtraEditors.MemoEdit();
            this.TxtFirmaSektor = new DevExpress.XtraEditors.TextEdit();
            this.TxtFirmamail = new DevExpress.XtraEditors.TextEdit();
            this.TxtFirmano = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFirmaUnvan = new DevExpress.XtraEditors.TextEdit();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.TxtFirmaYetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaSektor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmamail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaYetkili.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            gridLevelNode3.RelationName = "Level3";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(976, 416);
            this.gridControl1.TabIndex = 1;
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
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.Txtil);
            this.groupControl1.Controls.Add(this.Txtilce);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.TxtFirmaID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.TxtFirmaAdres);
            this.groupControl1.Controls.Add(this.TxtFirmaSektor);
            this.groupControl1.Controls.Add(this.TxtFirmamail);
            this.groupControl1.Controls.Add(this.TxtFirmano);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtFirmaUnvan);
            this.groupControl1.Controls.Add(this.BtnGüncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.TxtFirmaYetkili);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(978, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(343, 416);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = " ";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 314);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "İlçe/İl :";
            // 
            // Txtil
            // 
            this.Txtil.Location = new System.Drawing.Point(230, 307);
            this.Txtil.Name = "Txtil";
            this.Txtil.Size = new System.Drawing.Size(101, 20);
            this.Txtil.TabIndex = 20;
            
            // 
            // Txtilce
            // 
            this.Txtilce.Location = new System.Drawing.Point(108, 307);
            this.Txtilce.Name = "Txtilce";
            this.Txtilce.Size = new System.Drawing.Size(116, 20);
            this.Txtilce.TabIndex = 19;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(5, 26);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(326, 67);
            this.pictureEdit1.TabIndex = 18;
            // 
            // TxtFirmaID
            // 
            this.TxtFirmaID.Location = new System.Drawing.Point(108, 99);
            this.TxtFirmaID.Name = "TxtFirmaID";
            this.TxtFirmaID.Size = new System.Drawing.Size(223, 20);
            this.TxtFirmaID.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 102);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(44, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Firma ID:";
            // 
            // TxtFirmaAdres
            // 
            this.TxtFirmaAdres.Location = new System.Drawing.Point(108, 259);
            this.TxtFirmaAdres.Name = "TxtFirmaAdres";
            this.TxtFirmaAdres.Size = new System.Drawing.Size(223, 42);
            this.TxtFirmaAdres.TabIndex = 15;
            // 
            // TxtFirmaSektor
            // 
            this.TxtFirmaSektor.Location = new System.Drawing.Point(108, 233);
            this.TxtFirmaSektor.Name = "TxtFirmaSektor";
            this.TxtFirmaSektor.Size = new System.Drawing.Size(223, 20);
            this.TxtFirmaSektor.TabIndex = 14;
            // 
            // TxtFirmamail
            // 
            this.TxtFirmamail.Location = new System.Drawing.Point(108, 207);
            this.TxtFirmamail.Name = "TxtFirmamail";
            this.TxtFirmamail.Size = new System.Drawing.Size(223, 20);
            this.TxtFirmamail.TabIndex = 13;
            // 
            // TxtFirmano
            // 
            this.TxtFirmano.Location = new System.Drawing.Point(108, 181);
            this.TxtFirmano.Name = "TxtFirmano";
            this.TxtFirmano.Size = new System.Drawing.Size(223, 20);
            this.TxtFirmano.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 261);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Adres:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 184);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "İletişim:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 210);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(22, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Mail:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 240);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Sektör:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 128);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Firma Ünvanı:";
            // 
            // TxtFirmaUnvan
            // 
            this.TxtFirmaUnvan.Location = new System.Drawing.Point(108, 125);
            this.TxtFirmaUnvan.Name = "TxtFirmaUnvan";
            this.TxtFirmaUnvan.Size = new System.Drawing.Size(223, 20);
            this.TxtFirmaUnvan.TabIndex = 6;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(16, 382);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(149, 23);
            this.BtnGüncelle.TabIndex = 5;
            this.BtnGüncelle.Text = "GÜNCELLE";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(185, 382);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(146, 23);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtFirmaYetkili
            // 
            this.TxtFirmaYetkili.Location = new System.Drawing.Point(108, 153);
            this.TxtFirmaYetkili.Name = "TxtFirmaYetkili";
            this.TxtFirmaYetkili.Size = new System.Drawing.Size(223, 20);
            this.TxtFirmaYetkili.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 156);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Firma Yetkilisi:";
            // 
            // Frm_Firmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 418);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Firmalar";
            this.Text = "Firma Listesi";
            this.Load += new System.EventHandler(this.Frm_Firmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaSektor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmamail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirmaYetkili.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtFirmaSektor;
        private DevExpress.XtraEditors.TextEdit TxtFirmamail;
        private DevExpress.XtraEditors.TextEdit TxtFirmano;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtFirmaUnvan;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.TextEdit TxtFirmaYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit TxtFirmaAdres;
        private DevExpress.XtraEditors.TextEdit TxtFirmaID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit Txtil;
        private DevExpress.XtraEditors.TextEdit Txtilce;
    }
}