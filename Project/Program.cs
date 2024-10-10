using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Transactions;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ///////////////////////////////////////////////Ado.net/////////////////////////////////////////////////////////////////////////////////
            // it needs to install package Data.SqlClient to use ado.net 



            //var config = new ConfigurationBuilder()                    // to access appsetting.json file
            //    .AddJsonFile("appsetting.json")
            //    .Build();
            //var connection = config.GetSection("connectionstring").Value;


            //sql connection to database using connectionstring to database local
            var connectionString = "Server=. ; Database= DigitalCurrency ; Integrated Security = SSPI ; TrustServerCertificate = True";
            var connect = new SqlConnection(connectionString);


            ///////////////////////////////////////////////////////////////////////////
            #region sql connection and get method
            //var sql = "select * from wallets";                              // sql query
            //SqlCommand command = new SqlCommand(sql, connect);              // sqlcommand to be executed in database
            //command.CommandType = CommandType.Text;                         // type of sqlcommand 

            //connect.Open();                                                 // open connection with database

            //Wallet wallet;
            //SqlDataReader reader = command.ExecuteReader();                 // execute query using reader
            //while (reader.Read())
            //{
            //    wallet = new Wallet()
            //    {
            //        Id = reader.GetInt32("Id"),
            //        Holder = reader.GetString("Holder"),
            //        Balance = reader.GetDecimal("Balance"),
            //    };
            //    Console.WriteLine(wallet);
            //}
            //connect.Close();                                                        //close the connection with database
            #endregion


            ///////////////////////////////////////////////////////////////////////////
            #region sql connection and get byid
            //var sql = "select * from wallets where Id = @Id";

            //SqlParameter IdParameter = new SqlParameter()                // make parameter to add in query as variable 
            //{
            //    SqlDbType = SqlDbType.Int,                              // datatype of parameter
            //    Value = 1,                                              // the value of parameter
            //    Direction = ParameterDirection.Input,                  // input parameter 
            //    ParameterName = "@Id"                                  // name of variable in query to reference to it
            //};
            //SqlCommand command = new SqlCommand(sql, connect);          
            //command.Parameters.Add(IdParameter);                        // add parameter into query
            //command.CommandType = CommandType.Text;

            //connect.Open();

            //Wallet wallet;
            //SqlDataReader reader = command.ExecuteReader();
            //if (reader.Read())
            //{
            //    wallet = new Wallet()
            //    {
            //        Id = reader.GetInt32(reader.GetOrdinal("Id")),
            //        Holder = reader.GetString(reader.GetOrdinal("Holder")),
            //        Balance = reader.GetDecimal(reader.GetOrdinal("Balance"))
            //    };
            //    Console.WriteLine(wallet);
            //}
            //connect.Close();
            #endregion


            ////////////////////////////////////////////////////////////////////////////////////////////////
            #region insert into database

            //var wallettoinsert = new Wallet()
            //{
            //    Holder = "tamer",
            //    Balance = 13000
            //};
            //var sql2 = "insert into wallets (Holder,Balance) values (@Holder,@Balance)";
            //SqlParameter HoldParameter = new SqlParameter
            //{
            //    ParameterName = "@Holder",
            //    SqlDbType = SqlDbType.VarChar,
            //    Value = wallettoinsert.Holder,
            //    Direction = ParameterDirection.Input
            //};
            //SqlParameter balanceparameter = new SqlParameter
            //{
            //    ParameterName = "@Balance",
            //    DbType = DbType.Decimal,
            //    Value = wallettoinsert.Balance,
            //    Direction = ParameterDirection.Input
            //};
            //SqlCommand command2 = new SqlCommand(sql2, connect);
            //command2.Parameters.Add(HoldParameter);
            //command2.Parameters.Add(balanceparameter);
            //command2.CommandType = CommandType.Text;

            //connect.Open();
            //if (command2.ExecuteNonQuery() > 0)                   // whrn execute database it give lines of rows when successfully
            //{
            //    Console.WriteLine($"wallet for {wallettoinsert.Holder} added successully");
            //}
            //else
            //{
            //    Console.WriteLine($"ERROR: wallet for {wallettoinsert.Holder} was not added");
            //}
            //connect.Close();

            #endregion


            ////////////////////////////////////////////////////////////////////////////////////////////////////
            #region insert into database with scalar execute to return the first column from insert mainly is (id)

            //var wallettoinsert = new Wallet()
            //{
            //    Holder = "mohamed",
            //    Balance = 50000
            //};
            //var sql2 = "insert into wallets (Holder,Balance) values (@Holder,@Balance);"+
            //    $"select cast( scope_identity() as int )";                             // get identity id of record inserted
            //SqlParameter HoldParameter = new SqlParameter
            //{
            //    ParameterName = "@Holder",
            //    SqlDbType = SqlDbType.VarChar,
            //    Value = wallettoinsert.Holder,
            //    Direction = ParameterDirection.Input
            //};
            //SqlParameter balanceparameter = new SqlParameter
            //{
            //    ParameterName = "@Balance",
            //    DbType = DbType.Decimal,
            //    Value = wallettoinsert.Balance,
            //    Direction = ParameterDirection.Input
            //};
            //SqlCommand command2 = new SqlCommand(sql2, connect);
            //command2.Parameters.Add(HoldParameter);
            //command2.Parameters.Add(balanceparameter);
            //command2.CommandType = CommandType.Text;

            //connect.Open();
            //wallettoinsert.Id = (int)command2.ExecuteScalar();               // scalar to get the first column value 

            //Console.WriteLine($"wallet for {wallettoinsert.Holder} added successfully");
            //connect.Close();

            #endregion


            ////////////////////////////////////////////////////////////////////////////////////////////////
            #region insert into database with stored procedure
            //var wallettoinsert = new Wallet()
            //{
            //    Holder = "kamel",
            //    Balance = 40000
            //};
            //SqlParameter HoldParameter = new SqlParameter
            //{
            //    ParameterName = "@Holder",
            //    SqlDbType = SqlDbType.VarChar,
            //    Value = wallettoinsert.Holder,
            //    Direction = ParameterDirection.Input
            //};
            //SqlParameter balanceparameter = new SqlParameter
            //{
            //    ParameterName = "@Balance",
            //    DbType = DbType.Decimal,
            //    Value = wallettoinsert.Balance,
            //    Direction = ParameterDirection.Input
            //};
            //SqlCommand command2 = new SqlCommand("AddWallet", connect);            // execute using name of stored procedure in database
            //command2.Parameters.Add(HoldParameter);
            //command2.Parameters.Add(balanceparameter);
            //command2.CommandType = CommandType.StoredProcedure;

            //connect.Open();
            //if (command2.ExecuteNonQuery() > 0)
            //{
            //    Console.WriteLine($"wallet for {wallettoinsert.Holder} added successully");
            //}
            //else
            //{
            //    Console.WriteLine($"ERROR: wallet for {wallettoinsert.Holder} was not added");
            //}

            //connect.Close();

            #endregion


            ////////////////////////////////////////////////////////////////////////////////////////////////
            #region update into database 

            //var wallettoinsert = new Wallet()
            //{
            //    Id = 7,
            //    Holder = "adlesaad",
            //    Balance = 7000,
            //};
            //var sql4 = "update wallets set Holder = @Holder, Balance = @Balance where Id = @Id";
            //SqlParameter HoldParameter = new SqlParameter
            //{
            //    ParameterName = "@Holder",
            //    SqlDbType = SqlDbType.VarChar,
            //    Value = wallettoinsert.Holder,
            //    Direction = ParameterDirection.Input
            //};
            //SqlParameter balanceparameter = new SqlParameter
            //{
            //    ParameterName = "@Balance",
            //    SqlDbType = SqlDbType.Decimal,
            //    Value = wallettoinsert.Balance,
            //    Direction = ParameterDirection.Input
            //};
            //SqlParameter Idparameter = new SqlParameter
            //{
            //    ParameterName = "@Id",
            //    SqlDbType = SqlDbType.Int,
            //    Value = wallettoinsert.Id,
            //    Direction = ParameterDirection.Input
            //};
            //SqlCommand command2 = new SqlCommand(sql4, connect);
            //command2.Parameters.Add(HoldParameter);
            //command2.Parameters.Add(balanceparameter);
            //command2.Parameters.Add(Idparameter);
            //command2.CommandType = CommandType.Text;

            //connect.Open();
            //if (command2.ExecuteNonQuery() > 0)
            //{
            //    Console.WriteLine($"wallet for {wallettoinsert.Holder} edit successully");
            //}
            //else
            //{
            //    Console.WriteLine($"ERROR: wallet for {wallettoinsert.Holder} was not edit");
            //}

            //connect.Close();

            #endregion


            ///////////////////////////////////////////////////////////////////////////////
            #region delete into database 
            //var sql4 = "delete from wallets where Id = @Id";
            //SqlParameter Idparameter = new SqlParameter
            //{
            //    ParameterName = "@Id",
            //    SqlDbType = SqlDbType.Int,
            //    Value = 7,
            //    Direction = ParameterDirection.Input
            //};
            //SqlCommand command2 = new SqlCommand(sql4, connect);
            //command2.Parameters.Add(Idparameter);
            //command2.CommandType = CommandType.Text;

            //connect.Open();
            //if (command2.ExecuteNonQuery() > 0)
            //{
            //    Console.WriteLine($"wallet item deleted successully");
            //}
            //else
            //{
            //    Console.WriteLine($"ERROR: wallet item was not deleted");
            //}

            //connect.Close();
            #endregion


            ////////////////////////////////////////////////////////////////////////////
            #region data adapter 
            // The DataAdapter in ADO.NET acts as a bridge between a DataSet (or DataTable) and a data source (like SQL Server).
            // It is used to retrieve data from a database, store it in a DataSet or DataTable, and optionally, update the database using the DataSet after making changes to it.

            //Key Features of DataAdapter:
            //Fill: The DataAdapter populates a DataSet or DataTable with data from the database.
            //Update: It can apply updates(like INSERT, UPDATE, and DELETE commands) made to the DataSet or DataTable back to the database.
            //The DataAdapter works with disconnected data. Once the data is loaded into the DataSet or DataTable, you don’t need a persistent connection to the database.

            //ex:
            //var sql = "select * from wallets";
            //connect.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connect);
            //DataTable dt = new DataTable(); 
            //sqlDataAdapter.Fill(dt);
            //connect.Close();

            //foreach (DataRow dr in dt.Rows)
            //{
            //    var wallett = new Wallet()
            //    {
            //        Id = Convert.ToInt32(dr["Id"]),
            //        Holder = Convert.ToString(dr["Holder"]),
            //        Balance = Convert.ToDecimal(dr["Balance"])
            //    };
            //    Console.WriteLine(wallett);
            //}
            #endregion


            ///////////////////////////////////////////////////////////////////////////
            #region transiction 
            //SqlCommand command = connect.CreateCommand();
            //command.CommandType = CommandType.Text;

            //connect.Open();
            //SqlTransaction transaction = connect.BeginTransaction();   // make transiction
            //command.Transaction = transaction;

            //try
            //{
            //    command.CommandText = "update wallets set Balance = Balance-1000 where Id = 1";
            //    command.ExecuteNonQuery();

            //    command.CommandText = "update wallets set Balance = Balance+1000 where Id = 2";
            //    command.ExecuteNonQuery();

            //    transaction.Commit();
            //    Console.WriteLine("Transaction of transfer completed successfully");
            //}
            //catch (Exception)
            //{
            //    try
            //    {
            //        transaction.Rollback();
            //    }
            //    catch (Exception)
            //    {

            //        // logs
            //    }
            //}
            //finally
            //{
            //    try
            //    {
            //        connect.Close();
            //    }
            //    catch (Exception)
            //    {

            //        // log
            //    }
            //}
            #endregion











            ///////////////////////////////////////////////Dapper//////////////////////////////////////////////////////////////////////////////////
            // it needs to install dapper package with package Data.SqlClient to use dapper 

            IDbConnection Db = new SqlConnection(connectionString);


            /////////////////////////////////////////////////////////////
            #region GetData using dapper 

            //var sql = "SELECT * FROM WALLETS";

            //Console.WriteLine("---------------- using Dynamic Query -------------");
            //var resultAsDynamic = Db.Query(sql);                                             // query for return data
            //foreach (var item in resultAsDynamic)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------- using Typed Query -------------"); 
            //var wallets = Db.Query<Wallet>(sql);
            //foreach (var wallet in wallets)
            //{
            //    Console.WriteLine(wallet);
            //}
            #endregion


            //////////////////////////////////////////////////////////////

            #region GetData using dapper 
            //var sql0 = "SELECT * FROM WALLETS where Id = @Id";
            //var parameters = new { Id = 1 };

            //Console.WriteLine("---------------- using Typed Query -------------");
            //var wallet = Db.Query<Wallet>(sql0, parameters).Single();                                // single to return single data
            //Console.WriteLine(wallet);
            #endregion


            ///////////////////////////////////////////////////////////
            #region insert data using dapper 
            //var walletToInsert = new Wallet { Holder = "adham", Balance = 2000 };
            //var sql2 = "insert into wallets (Holder,Balance) values (@Holder,@Balance)";                    // execute not return data and take parameters
            //Db.Execute(sql2, 
            //    new 
            //    {
            //        Holder = walletToInsert.Holder,
            //        Balance = walletToInsert.Balance
            //    });
            #endregion


            ////////////////////////////////////////////////////////////
            #region insert data and return data using dapper 
            //var walletToInsert = new Wallet { Holder = "karim", Balance = 1000 };
            //var sql2 = "insert into wallets (Holder,Balance) values (@Holder,@Balance)  select CAST(SCOPE_IDENTITY() as int) ";

            //var parameters = new
            //{
            //    Holder = walletToInsert.Holder,
            //    Balance = walletToInsert.Balance
            //};
            //walletToInsert.Id =  Db.Query<int>(sql2, parameters).Single();                       // single to return single data
            //Console.WriteLine(walletToInsert); 
            #endregion


            //////////////////////////////////////////////////////////////
            #region update data using dapper 
            //var walletToInsert = new Wallet { Holder = "karimm", Balance = 10001 , Id = 16};
            //var sql3 = "update wallets set Holder = @Holder, Balance= @Balance where Id = @Id ";

            //var parameters = new
            //{
            //    Id = walletToInsert.Id,
            //    Holder = walletToInsert.Holder,
            //    Balance = walletToInsert.Balance,
            //};
            //Db.Execute(sql3, parameters);



            #endregion


            ///////////////////////////////////////////////////////////////
            #region update data using dapper 
            //var sql3 = "delete from wallets where Id = @Id ";
            //var parameters = new
            //{
            //    Id = 16
            //};
            //Db.Execute(sql3, parameters);
            #endregion


            ///////////////////////////////////////////////////////////////
            #region execute multiple queires using dapper 
            //var sql5 =
            //    "select max(Balance) from wallets;"+
            //    "select min(Balance) from wallets;";

            //var multiple = Db.QueryMultiple(sql5);

            //Console.WriteLine(                                    // it reads it as streams as once i read it i cannot reread it again
            //    $"Min = {multiple.ReadSingle<decimal>()}" +
            //    $"\nMax = {multiple.ReadSingle<decimal>()}");


            //Console.WriteLine(                        
            //  $"Min = {multiple.Read<decimal>().Single()}" +
            //  $"\nMax = {multiple.Read<decimal>().Single()}");

            #endregion


            //////////////////////////////////////////////////////////////
            #region dapper using transiction
            //decimal amountToTranfer = 2000;

            //using (var transactionScope = new TransactionScope())
            //{
            //       var walletFrom = Db.QuerySingle<Wallet>
            //      ("SELECT * FROM Wallets Where Id = @Id", new { Id = 8 });

            //    var walletTo = Db.QuerySingle<Wallet>
            //      ("SELECT * FROM Wallets Where Id = @Id", new { Id = 4 });

            //    Db.Execute("UPDATE Wallets Set Balance = @Balance Where Id = @Id",
            //        new
            //        {
            //            Id = walletFrom.Id,
            //            Balance = walletFrom.Balance - amountToTranfer
            //        }
            //    ); ;

            //    Db.Execute("UPDATE Wallets Set Balance = @Balance Where Id = @Id",
            //      new
            //      {
            //          Id = walletTo.Id,
            //          Balance = walletTo.Balance + amountToTranfer
            //      }
            //    );
            //    transactionScope.Complete();
            #endregion


        }

    }
}
