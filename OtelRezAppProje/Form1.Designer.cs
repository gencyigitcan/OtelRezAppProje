﻿namespace OtelRezAppProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnMisafirListesi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDurumTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBirimTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDepartmanTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGorevTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKasaTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKurTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnOdaTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTelefonTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUlkeTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUrunGrupTanimları = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersonelListesi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersonelKarti = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMisafirKarti = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnMisafirListesi,
            this.BtnDurumTanimlari,
            this.BtnBirimTanimlari,
            this.BtnDepartmanTanimlari,
            this.BtnGorevTanimlari,
            this.BtnKasaTanimlari,
            this.BtnKurTanimlari,
            this.BtnOdaTanimlari,
            this.BtnTelefonTanimlari,
            this.BtnUlkeTanimlari,
            this.BtnUrunGrupTanimları,
            this.BtnPersonelListesi,
            this.BtnPersonelKarti,
            this.BtnMisafirKarti});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 150);
            // 
            // BtnMisafirListesi
            // 
            this.BtnMisafirListesi.Caption = "Misafir Listesi";
            this.BtnMisafirListesi.Id = 1;
            this.BtnMisafirListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.BtnMisafirListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.BtnMisafirListesi.Name = "BtnMisafirListesi";
            this.BtnMisafirListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMisafirListesi_ItemClick);
            // 
            // BtnDurumTanimlari
            // 
            this.BtnDurumTanimlari.Caption = "Durum Tanımları";
            this.BtnDurumTanimlari.Id = 2;
            this.BtnDurumTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDurumTanimlari.ImageOptions.Image")));
            this.BtnDurumTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDurumTanimlari.ImageOptions.LargeImage")));
            this.BtnDurumTanimlari.Name = "BtnDurumTanimlari";
            this.BtnDurumTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDurumTanimlari_ItemClick);
            // 
            // BtnBirimTanimlari
            // 
            this.BtnBirimTanimlari.Caption = "Birim Tanımları";
            this.BtnBirimTanimlari.Id = 3;
            this.BtnBirimTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBirimTanimlari.ImageOptions.Image")));
            this.BtnBirimTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBirimTanimlari.ImageOptions.LargeImage")));
            this.BtnBirimTanimlari.Name = "BtnBirimTanimlari";
            this.BtnBirimTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBirimTanimlari_ItemClick);
            // 
            // BtnDepartmanTanimlari
            // 
            this.BtnDepartmanTanimlari.Caption = "Departman Tanımları";
            this.BtnDepartmanTanimlari.Id = 4;
            this.BtnDepartmanTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDepartmanTanimlari.ImageOptions.Image")));
            this.BtnDepartmanTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDepartmanTanimlari.ImageOptions.LargeImage")));
            this.BtnDepartmanTanimlari.Name = "BtnDepartmanTanimlari";
            this.BtnDepartmanTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDepartmanTanimlari_ItemClick);
            // 
            // BtnGorevTanimlari
            // 
            this.BtnGorevTanimlari.Caption = "Görev Tanımları";
            this.BtnGorevTanimlari.Id = 5;
            this.BtnGorevTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGorevTanimlari.ImageOptions.Image")));
            this.BtnGorevTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGorevTanimlari.ImageOptions.LargeImage")));
            this.BtnGorevTanimlari.Name = "BtnGorevTanimlari";
            this.BtnGorevTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGorevTanimlari_ItemClick);
            // 
            // BtnKasaTanimlari
            // 
            this.BtnKasaTanimlari.Caption = "Kasa Tanımları";
            this.BtnKasaTanimlari.Id = 6;
            this.BtnKasaTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKasaTanimlari.ImageOptions.Image")));
            this.BtnKasaTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKasaTanimlari.ImageOptions.LargeImage")));
            this.BtnKasaTanimlari.Name = "BtnKasaTanimlari";
            this.BtnKasaTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKasaTanimlari_ItemClick);
            // 
            // BtnKurTanimlari
            // 
            this.BtnKurTanimlari.Caption = "Kur Tanımları";
            this.BtnKurTanimlari.Id = 7;
            this.BtnKurTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKurTanimlari.ImageOptions.Image")));
            this.BtnKurTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKurTanimlari.ImageOptions.LargeImage")));
            this.BtnKurTanimlari.Name = "BtnKurTanimlari";
            this.BtnKurTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKurTanimlari_ItemClick);
            // 
            // BtnOdaTanimlari
            // 
            this.BtnOdaTanimlari.Caption = "Oda Tanımları";
            this.BtnOdaTanimlari.Id = 8;
            this.BtnOdaTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOdaTanimlari.ImageOptions.Image")));
            this.BtnOdaTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnOdaTanimlari.ImageOptions.LargeImage")));
            this.BtnOdaTanimlari.Name = "BtnOdaTanimlari";
            this.BtnOdaTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnOdaTanimlari_ItemClick);
            // 
            // BtnTelefonTanimlari
            // 
            this.BtnTelefonTanimlari.Caption = "Telefon Tanımları";
            this.BtnTelefonTanimlari.Id = 9;
            this.BtnTelefonTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTelefonTanimlari.ImageOptions.Image")));
            this.BtnTelefonTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnTelefonTanimlari.ImageOptions.LargeImage")));
            this.BtnTelefonTanimlari.Name = "BtnTelefonTanimlari";
            this.BtnTelefonTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTelefonTanimlari_ItemClick);
            // 
            // BtnUlkeTanimlari
            // 
            this.BtnUlkeTanimlari.Caption = "Ülke Tanımları";
            this.BtnUlkeTanimlari.Id = 10;
            this.BtnUlkeTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUlkeTanimlari.ImageOptions.Image")));
            this.BtnUlkeTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUlkeTanimlari.ImageOptions.LargeImage")));
            this.BtnUlkeTanimlari.Name = "BtnUlkeTanimlari";
            this.BtnUlkeTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUlkeTanimlari_ItemClick);
            // 
            // BtnUrunGrupTanimları
            // 
            this.BtnUrunGrupTanimları.Caption = "Ürün Grup Tanımları";
            this.BtnUrunGrupTanimları.Id = 11;
            this.BtnUrunGrupTanimları.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunGrupTanimları.ImageOptions.Image")));
            this.BtnUrunGrupTanimları.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUrunGrupTanimları.ImageOptions.LargeImage")));
            this.BtnUrunGrupTanimları.Name = "BtnUrunGrupTanimları";
            this.BtnUrunGrupTanimları.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUrunGrupTanimları_ItemClick);
            // 
            // BtnPersonelListesi
            // 
            this.BtnPersonelListesi.Caption = "Personel Listesi";
            this.BtnPersonelListesi.Id = 12;
            this.BtnPersonelListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelListesi.ImageOptions.Image")));
            this.BtnPersonelListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonelListesi.ImageOptions.LargeImage")));
            this.BtnPersonelListesi.Name = "BtnPersonelListesi";
            this.BtnPersonelListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersonelListesi_ItemClick);
            // 
            // BtnPersonelKarti
            // 
            this.BtnPersonelKarti.Caption = "Personel Kartı";
            this.BtnPersonelKarti.Id = 13;
            this.BtnPersonelKarti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelKarti.ImageOptions.Image")));
            this.BtnPersonelKarti.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonelKarti.ImageOptions.LargeImage")));
            this.BtnPersonelKarti.Name = "BtnPersonelKarti";
            this.BtnPersonelKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersonelKarti_ItemClick);
            // 
            // BtnMisafirKarti
            // 
            this.BtnMisafirKarti.Caption = "Yeni Misafir Kartı";
            this.BtnMisafirKarti.Id = 14;
            this.BtnMisafirKarti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMisafirKarti.ImageOptions.Image")));
            this.BtnMisafirKarti.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMisafirKarti.ImageOptions.LargeImage")));
            this.BtnMisafirKarti.Name = "BtnMisafirKarti";
            this.BtnMisafirKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMisafirKarti_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Form";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Müşteriler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnMisafirListesi);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnMisafirKarti);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Personel";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnPersonelListesi);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnPersonelKarti);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Ürünler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Rezervasyonlar";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Tanımlamalar";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnDurumTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnBirimTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnDepartmanTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnGorevTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnKasaTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnKurTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnOdaTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnTelefonTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnUlkeTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnUrunGrupTanimları);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Projesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem BtnMisafirListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem BtnDurumTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnBirimTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnDepartmanTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnGorevTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnKasaTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnKurTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnOdaTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnTelefonTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnUlkeTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnUrunGrupTanimları;
        private DevExpress.XtraBars.BarButtonItem BtnPersonelListesi;
        private DevExpress.XtraBars.BarButtonItem BtnPersonelKarti;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnMisafirKarti;
    }
}

