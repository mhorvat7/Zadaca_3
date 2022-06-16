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
    public partial class FrmLogin : Form
    {
        public static Zaposlenik LoggedZaposlenik { get; set; }  
        public FrmLogin()
        {
            InitializeComponent();
            BtnLogin.Click += new EventHandler(BtnLogin_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(TxtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoggedZaposlenik = ZaposlenikRepository.GetZaposlenik(TxtUsername.Text);
                if (LoggedZaposlenik != null && LoggedZaposlenik.Password == TxtPassword.Text && LoggedZaposlenik.Status == 3)
                {
                    this.Hide();
                    FrmPocetna frmPocetna = new FrmPocetna();
                    frmPocetna.ShowDialog();
                    this.Close();
                }
                else if(LoggedZaposlenik != null && LoggedZaposlenik.Password == TxtPassword.Text && LoggedZaposlenik.Status == 2)
                {
                    this.Hide();
                    FrmPocetnaCIP frmpocetnaCIP = new FrmPocetnaCIP();
                    frmpocetnaCIP.ShowDialog();
                    this.Close();
                }
                else if(LoggedZaposlenik != null && LoggedZaposlenik.Password == TxtPassword.Text && LoggedZaposlenik.Status == 1)
                {
                    this.Hide();
                    FrmPocetnaOdobrenje frmpocetnaOdobrenje = new FrmPocetnaOdobrenje();
                    frmpocetnaOdobrenje.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
