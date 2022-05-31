using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void ShowZahtjev()
        {
            var zahtjevi = ZahtjevRepository.GetZahtjev();
            dgvPopis.DataSource = zahtjevi;
            dgvPopis.Columns["UrBroj"].DisplayIndex = 0;
            dgvPopis.Columns["ImePrezime"].DisplayIndex = 1;
            dgvPopis.Columns["Opis"].DisplayIndex = 2;
            dgvPopis.Columns["BrProjekta"].DisplayIndex = 3;
            dgvPopis.Columns["Naziv"].DisplayIndex = 4;
            dgvPopis.Columns["Voditelj"].DisplayIndex = 5;
        }
    }
}
