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
    public partial class FrmUrunGrup : Form
    {
        public FrmUrunGrup()
        {
            InitializeComponent();
        }

        Db_OtelRezAppEntities db = new Db_OtelRezAppEntities();

        private void FrmUrunGrup_Load(object sender, EventArgs e)
        {
            db.TblUrunGrup.Load();
            bindingSource1.DataSource = db.TblUrunGrup.Local;

            repositoryItemLookUpDurum.DataSource = (from x in db.TblDurum
                                                    select new
                                                    {
                                                        x.DurumId,
                                                        x.DurumAd
                                                    }).ToList();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
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
