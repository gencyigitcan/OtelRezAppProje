using OtelRezAppProje.Entity;
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

        private void FrmMisafirKarti_Load(object sender, EventArgs e)
        {
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
            secilen = int.Parse(lookUpEditSehir.EditValue.ToString());
           lookUpEditIlceler.Properties.DataSource = (from x in db.ilceler
                                                      select new
                                                      {
                                                          Id = x.id,
                                                          İlçe = x.ilce,
                                                          Şehir = x.sehir
                                                      }).Where(y => y.Şehir == secilen).ToList();
        }

        private void lookUpEditilce_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
