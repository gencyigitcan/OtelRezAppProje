using DevExpress.XtraEditors;
using OtelRezAppProje.Entity;
using OtelRezAppProje.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezAppProje.Formlar.Misafir
{
    public partial class FrmMisafirKarti : Form
    {
        public FrmMisafirKarti()
        {
            InitializeComponent();
        }

        Db_OtelRezAppEntities db = new Db_OtelRezAppEntities();

        Repository<TblMisafir> repo = new Repository<TblMisafir>();
        TblMisafir t = new TblMisafir();

        string resim1, resim2;

        public int id;
        private void FrmMisafirKarti_Load(object sender, EventArgs e)
        {
            // Güncellenecek Kart Bilgileri

            if (id != 0)
            {
                var misafir = repo.Find(x => x.MisafirId == id);

                TxtAdSoyad.Text = misafir.AdSoyad;
                TxtTc.Text = misafir.TCKimlikNo;
                TxtAdres.Text = misafir.Adres;
                TxtTelefon.Text = misafir.TelefonNo;
                TxtMail.Text = misafir.MailAdresi;
                TxtAciklama.Text = misafir.Aciklama;
                resim1 = misafir.KimlikFoto1;
                resim2 = misafir.KimlikFoto2;
                PictureEditOn.Image = Image.FromFile(misafir.KimlikFoto1);
                PictureEditArka.Image = Image.FromFile(misafir.KimlikFoto2);
             //   lookUpEditSehir.EditValue = misafir.Sehir;
                lookUpEditUlke.EditValue = misafir.Ulke;
             //   lookUpEditIlceler.EditValue = misafir.Ilce;

            }

            // Ülke listesi
            lookUpEditUlke.Properties.DataSource = (from x in db.TblUlke
                                                    select new
                                                    {
                                                        x.UlkeId,
                                                        x.UlkeAd
                                                    }).ToList();
            // Şehir listesi
            lookUpEditSehir.Properties.DataSource = (from x in db.iller
                                                     select new
                                                     {
                                                         Id = x.id,
                                                         Şehir = x.sehir
                                                     }).ToList();
        }

        private void lookUpEditSehir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            //secilen = int.Parse(lookUpEditSehir.EditValue.ToString());
            //lookUpEditIlceler.Properties.DataSource = (from x in db.ilceler
            //                                           select new
            //                                           {
            //                                               Id = x.id,
            //                                               İlçe = x.ilce,
            //                                               Şehir = x.sehir
            //                                           }).Where(y => y.Şehir == secilen).ToList();
        }

        private void lookUpEditilce_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void PictureEditOn_EditValueChanged(object sender, EventArgs e)
        {
            resim1 = PictureEditOn.GetLoadedImageLocation().ToString();
        }

        private void PictureEditArka_EditValueChanged(object sender, EventArgs e)
        {
            resim2 = PictureEditArka.GetLoadedImageLocation().ToString();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            t.AdSoyad = TxtAdSoyad.Text;
            t.TCKimlikNo = TxtTc.Text;
            t.MailAdresi = TxtMail.Text;
            t.Adres = TxtAdres.Text;
            t.Aciklama = TxtAciklama.Text;
            t.Durum = 1;
            t.Sehir = lookUpEditSehir.Text;
            t.Ilce = lookUpEditIlceler.Text;
            t.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
            t.KimlikFoto1 = resim1;
            t.KimlikFoto2 = resim2;

            repo.TAdd(t);
            XtraMessageBox.Show("Misafir sisteme başarılı bir şekilde kaydedildi.",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
