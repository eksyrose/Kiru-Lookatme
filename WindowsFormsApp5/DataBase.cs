using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp5
{
    public static class DataBase
    { 
        private static String DbServer = "127.0.0.1";
        private static String Port = "5432";
        private static String UserName = "postgres";
        private static String UserPass = "1234";
        private static String DbName = "postgres";
        private static NpgsqlConnection c = null;

        public static void SetConnectionData(string serv, string port, string usname, string pass, string dbname)
        {
            DbServer = serv;
            Port = port;
            UserName = usname;
            UserPass = pass;
            DbName = dbname;
        }

        public static NpgsqlCommand Start(string query) //
        {
            c = new Npgsql.NpgsqlConnection("Server=" + DbServer + ";Port=" + Port + ";User Id=" + UserName + ";Password=" + UserPass + ";Database=" + DbName + ";Encoding=UNICODE;");
            NpgsqlCommand com = new NpgsqlCommand(query, c);
            try
            {
                c.Open();
            }
            catch (Exception)
            {
                return null;
            }
            return com;
        }

        public static void End()
        {
            c.Close();
        }
        public static NpgsqlDataReader WorkWithResult(string query) //для извлечения данных
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=1234;Database=postgres;");
            NpgsqlCommand com = new NpgsqlCommand(query, con);
            con.Open();
            NpgsqlDataReader reader;
            //List<String> res = new List<string>();
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    //string result = reader.GetString(1);//Получаем значение из второго столбца! Первый это (0)!
                    
                    object[] val = new object[20];
                    reader.GetValues(val);
                }
                catch { }
            }
            con.Close();
            return reader;
        }
        public static void Work(string query) //для вставки данных
        {
            Npgsql.NpgsqlConnection NpgConn = null;
            Npgsql.NpgsqlCommand NpgCmd = null;
            NpgConn = new Npgsql.NpgsqlConnection("Server=" + DbServer + ";Port="+ Port + ";User Id=" + UserName + ";Password=" + UserPass + ";Database=" + DbName + ";Encoding=UNICODE;");
            NpgConn.Open();
            NpgCmd = new Npgsql.NpgsqlCommand(query, NpgConn);
            NpgCmd.ExecuteScalar(); //Выполняем нашу команду.
            NpgConn.Close(); //Закрываем соединение. 
        }

       /* public static void InsertTown()
        {
            String s = "";
        }*/
    }
}
