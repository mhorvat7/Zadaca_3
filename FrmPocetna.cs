using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca_3.Models;
using Zadaca_3.Repositories;

namespace Zadaca_3
{
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }
        private void btnUnos_Click(object sender, EventArgs e)
        {
            FrmUnosZahtjeva frmUnosZahtjeva = new FrmUnosZahtjeva();
            frmUnosZahtjeva.ShowDialog();
            ShowZahtjev();
        }
        private void ShowZahtjev()
        {
            DB.SetConfiguration("mhorvat7_DB", "mhorvat7", "O8fBr=2#");
            DB.OpenConnection();
            var prikaz = ZahtjevRepository.GetZahtjev();
            dgvPopis.DataSource = prikaz;
            DB.CloseConnection();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            Zahtjev zahtjev = dgvPopis.CurrentRow.DataBoundItem as Zahtjev;
            ZahtjevRepository rep = new ZahtjevRepository();
            rep.DeleteZahtjev(zahtjev);
            ShowZahtjev();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            ShowZahtjev();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            FrmUnosZahtjeva frmUnosZahtjeva = new FrmUnosZahtjeva();
            if (!String.IsNullOrEmpty(frmUnosZahtjeva.txtBrProjekta.Text))
            {
                if (ZahtjevRepository.GetZahtjev(int.Parse(frmUnosZahtjeva.txtBrProjekta.Text)) != null)
                {
                    Zahtjev zahtjevi = new Zahtjev();
                    DB.SetConfiguration("mhorvat7_DB", "mhorvat7", "O8fBr=2#");
                    DB.OpenConnection();
                    string sql = $"SELECT * FROM Zahtjev WHERE BrProjekta = {zahtjevi.BrProjekta}";
                    DataTable data = new DataTable();
                    dgvPopis.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Zahtjev s tim brojem ne postoji");
                }
            }
        }
    }
}
