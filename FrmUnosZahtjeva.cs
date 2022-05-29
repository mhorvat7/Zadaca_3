using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_3
{
    public partial class FrmUnosZahtjeva : Form
    {
        public FrmUnosZahtjeva()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString();
        }
    }
}
