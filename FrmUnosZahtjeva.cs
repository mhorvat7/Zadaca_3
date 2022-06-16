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
    public partial class FrmUnosZahtjeva : Form
    {
        public FrmUnosZahtjeva()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString();
        }
        private void btnPodnesi_Click(object sender, EventArgs e)
        {
            Zahtjev zahtjev = new Zahtjev
            {
                BrProjekta = int.Parse(txtBrProjekta.Text),
                ImePrezime = txtImePrez.Text,
                Opis = txtOpis.Text,
                Naziv = txtNaziv.Text,
                Voditelj = txtVoditelj.Text
            };
            ZahtjevRepository zahtjevUnos = new ZahtjevRepository();
            zahtjevUnos.InsertZahtjev(zahtjev);
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
