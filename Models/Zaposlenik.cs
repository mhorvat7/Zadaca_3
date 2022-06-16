using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca_3.Repositories;

namespace Zadaca_3.Models
{
    public class Zaposlenik : Osoba
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
    }
}
