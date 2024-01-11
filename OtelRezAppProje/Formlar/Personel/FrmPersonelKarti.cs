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

namespace OtelRezAppProje.Formlar.Personel
{
    public partial class FrmPersonelKarti : Form
    {
        public FrmPersonelKarti()
        {
            InitializeComponent();
        }

        Db_OtelRezAppEntities db = new Db_OtelRezAppEntities();

        public int id;
        Repository<TblPersonel> repo = new Repository<TblPersonel>();

        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();
            lookUpEditDepartman.Properties.DataSource = (from x in db.TblDepartman
                                                         select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAd
                                                         }).ToList();
            
            lookUpEditGorev.Properties.DataSource = (from x in db.TblGorev
                                                     select new
                                                     {
                                                         x.GorevId,
                                                         x.GorevAd
                                                     }).ToList();
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            TxtAdres.Text = PictureEditOn.GetLoadedImageLocation();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            TblPersonel t = new TblPersonel();

            t.AdSoyad = TxtAdSoyad.Text;
            t.TcKimlikNo = TxtTc.Text;
            t.Adres = TxtAdres.Text;
            t.Telefon = TxtTelefon.Text;
            t.MailAdresi = TxtMail.Text;
            t.IseGirisTarihi = DateTime.Parse(dateEditGiris.Text);
            // t.IstenCikisTarihi = DateTime.Parse(dateEditCikis.Text);
            t.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            t.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            t.Aciklama = TxtAciklama.Text;
            t.MailAdresi = TxtMail.Text;
            t.KimlikOn = PictureEditOn.GetLoadedImageLocation();
            t.KimlikArka = PictureEditArka.GetLoadedImageLocation();
            // t.Yetki = 
            // t.Sifre = TxtSifre.Text;
            t.Durum = 1;

            repo.TAdd(t);
            XtraMessageBox.Show("Personel başarılı bir şekilde sisteme kaydedildi.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.PersonelId == id);

            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TcKimlikNo = TxtTc.Text;
            deger.Adres = TxtAdres.Text;
            // deger.Telefon = TxtTelefon.Text;
            // deger.MailAdresi = TxtMail.Text;
            // deger.IseGirisTarihi = DateTime.Parse(dateEditGiris.Text);
            // t.IstenCikisTarihi = DateTime.Parse(dateEditCikis.Text);
            // deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            // deger.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            // deger.Aciklama = TxtAciklama.Text;
            // deger.MailAdresi = TxtMail.Text;
            // deger.KimlikOn = PictureEditOn.GetLoadedImageLocation();
            // deger.KimlikArka = PictureEditArka.GetLoadedImageLocation();
            // t.Yetki = 
            // t.Sifre = TxtSifre.Text;
            // deger.Durum = 1;

            repo.TUpdate(deger);
            XtraMessageBox.Show("Personel kartı bilgileri başarıyla güncellendi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
