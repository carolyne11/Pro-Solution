using MySql.Data.MySqlClient;

public class Conexao
{
    private const string connStr = "server=localhost;user=root;password=senacJBQ;database=trabalho;port=3307";

    public static MySqlConnection obterConexao()
    {
        var conn = new MySqlConnection(connStr);
        conn.Open();
        return conn;
    }

}

