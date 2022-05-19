using Listino.Models;
using Simple_Ecommerce.Models;
using System.Data.SqlClient;

namespace Simple_Ecommerce.DataBaseHelpers
{
    public class SQLPersister
    {
        public int AddProduct(Product p) 
        {
            var sql = @"INSERT INTO [dbo].[Prodotto]
           ([C8] ,[Descrizione],[Titolo],[Link])
            VALUES
           (@C8, @Descrizione, @Titolo, @Link);SELECT @@IDENTITY AS 'Identity';";

            using var connection = new SqlConnection(@"Server = ACADEMYNETUD07\\SQLEXPRESS; Database = ECommerce; Trusted_Connection = True;");
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@C8", p.C8);
            command.Parameters.AddWithValue("@Descrizione", p.Descrizione);
            command.Parameters.AddWithValue("@Titolo", p.Titolo);
            command.Parameters.AddWithValue("@Link", p.Link);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public int AddCustomer(Customer p)
        {
            var sql = @"INSERT INTO [dbo].[Customer]
           ([Email]
           ,[Nome]
           ,[Cognome]
           ,[DataNascita])
     VALUES
           (@Email
           ,@Nome
           ,@Cognome
           ,@DataNascita);SELECT @@IDENTITY AS 'Identity';";

            using var connection = new SqlConnection(@"Server = ACADEMYNETUD07\\SQLEXPRESS; Database = ECommerce; Trusted_Connection = True;");
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Email", p.Email);
            command.Parameters.AddWithValue("@Nome", p.Nome);
            command.Parameters.AddWithValue("@Cognome", p.Cognome);
            command.Parameters.AddWithValue("@DataNascita", p.DataNascita);

            return Convert.ToInt32(command.ExecuteScalar());
        }        
        
        public int AddListino(ListinoProdotti p)
        {
            var sql = @"INSERT INTO [dbo].[ListinoProdotti]
           ([C8]
           ,[Costo]
           ,[Paese]
           ,[Currency])
     VALUES
           (@C8, @Costo, @Paese, @Currency);SELECT @@IDENTITY AS 'Identity';";

            using var connection = new SqlConnection(@"Server = ACADEMYNETUD07\\SQLEXPRESS; Database = ECommerce; Trusted_Connection = True;");
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@C8", p.C8);
            command.Parameters.AddWithValue("@Costo", p.Costo);
            command.Parameters.AddWithValue("@Paese", p.Paese);
            command.Parameters.AddWithValue("@Currency", p.Currency);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public int AddOrdine(Ordine p)
        {
            var sql = @"INSERT INTO [dbo].[Ordini]
           ([Email]
           ,[ProdID])
     VALUES
           (@Email, 
           ,@ProdID);SELECT @@IDENTITY AS 'Identity';";

            using var connection = new SqlConnection(@"Server = ACADEMYNETUD07\\SQLEXPRESS; Database = ECommerce; Trusted_Connection = True;");
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Email", p.Email);
            command.Parameters.AddWithValue("@ProdID", p.ProdID);

            return Convert.ToInt32(command.ExecuteScalar());
        }

    }
}
