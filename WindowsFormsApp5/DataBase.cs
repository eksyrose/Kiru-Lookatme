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
        public static List<String> Work()
        {
          /*  string conn_param = "Строка подключения к базе"; //Например: "Server=127.0.0.1;Port=5432;User Id=postgres;Password=mypass;Database=mybase;"
            string sql = "текст запроса к базе данных";
            NpgsqlConnection conn = new NpgsqlConnection(conn_param);
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            conn.Open(); //Открываем соединение.
            string res = comm.ExecuteScalar().ToString(); //Выполняем нашу команду.
            conn.Close(); //Закрываем соединение. */
            NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=1234;Database=postgres;");
            NpgsqlCommand com = new NpgsqlCommand("select * from public.towns order by \"town_id\"", con);
            con.Open();
            NpgsqlDataReader reader;
            List<String> res = new List<string>();
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    //string result = reader.GetString(1);//Получаем значение из второго столбца! Первый это (0)!
                    res.Add(reader.GetString(1));
                    object[] val = new object[20];
                    reader.GetValues(val);
                }
                catch { }
            }
            con.Close();
            return res;
        }
        public static void Work(string a)
        {
            Npgsql.NpgsqlConnection NpgConn = null;
            Npgsql.NpgsqlCommand NpgCmd = null;
            String DbServer = "";
            String Port = "";
            String UserName = "";
            String UserPass = "";
            String DbName = "";
            NpgConn = new Npgsql.NpgsqlConnection("Server=" + DbServer + ";Port="+ Port + ";User Id=" + UserName + ";Password=" + UserPass + ";Database=" + DbName + ";Encoding=UNICODE;");
            NpgConn.Open();
            NpgCmd = new Npgsql.NpgsqlCommand("SELECT....", NpgConn);
            //...как в первой
        }
    }
}
