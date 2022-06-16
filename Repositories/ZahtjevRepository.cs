using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca_3.Models;

namespace Zadaca_3.Repositories
{
    public class ZahtjevRepository
    {
        public static Zahtjev GetZahtjev(int zahtjev)
        {
            Zahtjev zahtjevi = new Zahtjev();
            DB.SetConfiguration("mhorvat7_DB", "mhorvat7", "O8fBr=2#");
            DB.OpenConnection();
            Zahtjev unos = null;
            string sql = $"SELECT * FROM Zahtjev WHERE BrProjekta = {zahtjevi.BrProjekta}";
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                unos = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return unos;
        }

        public static List<Zahtjev> GetZahtjev()
        {
            DB.SetConfiguration("mhorvat7_DB", "mhorvat7", "O8fBr=2#");
            DB.OpenConnection();
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = "SELECT * FROM Zahtjev";
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }

        private static Zahtjev CreateObject(System.Data.SqlClient.SqlDataReader reader)
        {
            DateTime urBroj = DateTime.Parse(reader["UrBroj"].ToString());
            string imePrezime = reader["ImePrezime"].ToString();
            string opis = reader["Opis"].ToString();
            int brProjekta = int.Parse(reader["BrProjekta"].ToString());
            string naziv = reader["Naziv"].ToString();
            string voditelj = reader["Voditelj"].ToString();
            var zahtjev = new Zahtjev
            {
                Urbroj = urBroj,
                ImePrezime = imePrezime,
                Opis = opis,    
                BrProjekta = brProjekta,
                Naziv = naziv,
                Voditelj = voditelj
            };
            return zahtjev;
        }

        public int InsertZahtjev(Zahtjev zahtjev)
        {
            DB.SetConfiguration("mhorvat7_DB", "mhorvat7", "O8fBr=2#");
            DB.OpenConnection();
            string sql = $"INSERT INTO Zahtjev (Urbroj, ImePrezime, Opis, BrProjekta, Naziv, Voditelj) VALUES (GETDATE(), '{zahtjev.ImePrezime}', '{zahtjev.Opis}', '{zahtjev.BrProjekta}', '{zahtjev.Naziv}', '{zahtjev.Voditelj}')";
            int izvrsi = DB.ExecuteCommand(sql);
            DB.CloseConnection();
            return izvrsi;
        }
        public int DeleteZahtjev(Zahtjev zahtjev)
        {
            DB.SetConfiguration("mhorvat7_DB", "mhorvat7", "O8fBr=2#");
            DB.OpenConnection();
            string sql = "DELETE FROM Zahtjev Where BrProjekta = '" + zahtjev.BrProjekta + "'";
            int izvrsi = DB.ExecuteCommand(sql);
            DB.CloseConnection();
            return izvrsi;
        }
    }
}
