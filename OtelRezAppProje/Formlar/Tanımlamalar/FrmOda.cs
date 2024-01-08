using DevExpress.XtraEditors;
using OtelRezAppProje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezAppProje.Formlar.Tanımlamalar
{
    public partial class FrmOda : Form
    {
        public FrmOda()
        {
            InitializeComponent();
        }

        Db_OtelRezAppEntities db = new Db_OtelRezAppEntities();

        private void FrmOda_Load(object sender, EventArgs e)
        {
            db.TblOda.Load();
            bindingSource1.DataSource = db.TblOda.Local;

            repositoryItemLookUpDurum.DataSource = (from x in db.TblDurum
                                                        select new
                                                        {
                                                            x.DurumId,
                                                            x.DurumAd
                                                        }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bilgiler kaydedilirken hata oluştu, kontrol edip tekrar deneyiniz!");
            }
        }
    }
}
