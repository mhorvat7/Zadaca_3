using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_3.Models
{
    public class Zahtjev
    {
        public DateTime Urbroj { get; set; }
        public string ImePrezime { get; set; }
        public string Opis { get; set; }
        public int BrProjekta { get; set; }
        public string Naziv { get; set; }
        public string Voditelj { get; set; }
    }
}
