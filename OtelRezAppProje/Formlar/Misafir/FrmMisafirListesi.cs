using OtelRezAppProje.Entity;
using OtelRezAppProje.Formlar.Personel;
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
    public partial class FrmMisafirListesi : Form
    {
        public FrmMisafirListesi()
        {
            InitializeComponent();
        }

        Db_OtelRezAppEntities db = new Db_OtelRezAppEntities();

        private void FrmMisafirListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblMisafir
                                       select new
                                       {
                                           x.MisafirId,
                                           x.AdSoyad,
                                           x.TCKimlikNo,
                                           x.TelefonNo,
                                           x.MailAdresi
                                          // x.Sehir,
                                          // x.Ilce
                                       }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMisafirKarti fr = new FrmMisafirKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("MisafirId").ToString());
            fr.Show();
        }
    }
}
