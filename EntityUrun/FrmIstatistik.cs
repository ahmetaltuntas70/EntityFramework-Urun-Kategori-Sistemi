using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUrun
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lbltks.Text = db.TBLKATEGORI.Count().ToString();
            lbltus.Text = db.TBLURUN.Count().ToString();
            lblams.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            lblpms.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            lblts.Text = db.TBLURUN.Sum(y => y.STOK).ToString();
            lblkt.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString() +"TL";
            lbleyfu.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            lbledfu.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            lblbes.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            lbltbs.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            lblss.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            lblefum.Text = db.MARKAGETIR().FirstOrDefault();

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
