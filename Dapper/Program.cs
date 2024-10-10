using Microsoft.Data.SqlClient;
using System.Data;

namespace Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=. ; Database= DigitalCurrency ; Integrated Security = SSPI ; TrustServerCertificate = True";
            IDbConnection Db = new SqlConnection(connectionString);



            #region GetData using dapper 

            //var sql = "SELECT * FROM WALLETS";

            //Console.WriteLine("---------------- using Dynamic Query -------------");
            //var resultAsDynamic = Db.Query(sql);
            //foreach (var item in resultAsDynamic)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------- using Typed Query -------------");
            //var wallets = Db.Query<Wallet> (sql);
            //foreach (var wallet in wallets)
            //{
            //    Console.WriteLine(wallet);
            //}

            #endregion

        }
    }
}
