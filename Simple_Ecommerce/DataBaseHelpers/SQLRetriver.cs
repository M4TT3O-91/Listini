using Listino.Models;
using System.Data.SqlClient;

namespace Simple_Ecommerce.DataBaseHelpers
{
    public class SQLRetriver
    {
        public IEnumerable<Product> GetAllProduct()
        {
            var sql = @"Select * from Prodotto";
            using var connection = new SqlConnection(@"Server=ACADEMYNETUD07\SQLEXPRESS;Database=ECommerce;Trusted_Connection=True;");
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                yield return new Product
                {
                    C8 = reader["C8"].ToString(),
                    Descrizione = reader["Descrizione"].ToString(),
                    Titolo = reader["Titolo"].ToString(),
                    Link = reader["Link"].ToString()
                };
            }

        }
    }
}
