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
using DevExpress.XtraEditors;
using OtelRezAppProje.Entity;
using DevExpress.XtraEditors;

namespace OtelRezAppProje.Formlar.Tanımlamalar
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }

        Db_OtelRezAppEntities db = new Db_OtelRezAppEntities();

        private void FrmDurum_Load(object sender, EventArgs e)
        {
            db.TblDurum.Load();
            bindingSource1.DataSource = db.TblDurum.Local;

            // Binding Source kullanımından sonra yorum haline geldi.

            //var durumlar = (from x in db.TblDurum
            //                select new
            //                {
            //                    x.DurumId,
            //                    x.DurumAd
            //                });
            //gridControl1.DataSource = durumlar.ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch(Exception)
            {
                XtraMessageBox.Show("Lütfen değerleri kontrol edip yeniden giriş yapın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void vazgeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
