using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MysqlConnection
{
    /// <summary>
    /// mysql data object, mysql数据操作对象
    /// </summary>
    class MDO
    {
        private string str_conn;

        private MySqlConnection mysql_conn;

        public MDO()
        {
            str_conn = "Database=db_chat_server;Data Source=localhost;User Id=root;Password=123456";
            mysql_conn = new MySqlConnection(str_conn);
            mysql_conn.Open();
        }

        public void SelectAll()
        {
            string sql = "select * from user";

            MySqlCommand mysql_cmd = new MySqlCommand(sql, mysql_conn);
            MySqlDataReader reader = mysql_cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine(reader.GetString(2));
                Console.WriteLine(reader.GetString(3));
                Console.WriteLine(reader.GetString(4));

                Console.WriteLine();
            }
        }

        public void Close()
        {
            if(mysql_conn.State != System.Data.ConnectionState.Closed)
            {
                mysql_conn.Close();
            }
        }
    }
}
