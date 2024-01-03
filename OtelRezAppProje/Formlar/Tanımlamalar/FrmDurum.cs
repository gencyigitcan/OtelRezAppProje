using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezAppProje.Entity;

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
            var durumlar = (from x in db.TblDurum
                            select new
                            {
                                x.DurumId,
                                x.DurumAd
                            });
            gridControl1.DataSource = durumlar.ToList();
        }

       
    }
}
