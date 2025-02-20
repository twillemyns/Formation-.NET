using Microsoft.Data.SqlClient;

namespace Exercice01;

internal static class BDDConnection
{
    const string connectionString = "Server=(localdb)\\demo1ado; Database=Exercice01;Integrated Security=true;";
    
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
