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
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }

        Db_OtelRezAppEntities db = new Db_OtelRezAppEntities();

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

        private void FrmGorev_Load(object sender, EventArgs e)
        {
            db.TblGorev.Load();
            bindingSource1.DataSource = db.TblGorev.Local;

            repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurum
                                                        select new
                                                        {
                                                            x.DurumId,
                                                            x.DurumAd
                                                        }).ToList();
            
            repositoryItemLookUpEditDepartman.DataSource = (from x in db.TblDepartman
                                                        select new
                                                        {
                                                            x.DepartmanID,
                                                            x.DepartmanAd
                                                        }).ToList();
        }
    }
}
