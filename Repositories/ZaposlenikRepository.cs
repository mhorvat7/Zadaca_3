
using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca_3.Models;

namespace Zadaca_3.Repositories
{
    public class ZaposlenikRepository {
        public static Zaposlenik GetZaposlenik(string username)
        {
            string sql = $"SELECT * FROM Osoba WHERE Username = '{username}'";
            return FetchZaposlenik(sql);
        }


        public static Zaposlenik GetZaposlenik(int id)
        {
            string sql = $"SELECT * FROM Osoba WHERE Id = {id}";
            return FetchZaposlenik(sql);
        }

        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.SetConfiguration("mhorvat7_DB", "mhorvat7", "O8fBr=2#");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return zaposlenik;
        }

        private static Zaposlenik CreateObject(System.Data.SqlClient.SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            var zaposlenik = new Zaposlenik
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
            };
            return zaposlenik;
        }
    }
}
