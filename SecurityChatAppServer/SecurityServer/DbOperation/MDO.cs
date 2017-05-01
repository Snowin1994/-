using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SecurityServer;
using SecurityServer.DbOperation;

namespace MysqlConnection
{
    /// <summary>
    /// mysql data object, mysql数据操作对象
    /// </summary>
    class MDO
    {
        private string str_conn;

        //private MySqlConnection mysql_conn;
        //private MySqlCommand mysql_cmd;
        //private MySqlDataReader mysql_reader;

        public MDO()
        {
            str_conn = "Database=db_chat_server;Data Source=localhost;User Id=root;Password=123456";
        }

        public void SelectAll()
        {
            string sql = "select * from user";

            //mysql_cmd = new MySqlCommand(sql, mysql_conn);
            //mysql_reader = mysql_cmd.ExecuteReader();
            //while (mysql_reader.Read())
            //{
            //    Console.WriteLine(mysql_reader.GetString(0));
            //    Console.WriteLine(mysql_reader.GetString(1));
            //    Console.WriteLine(mysql_reader.GetString(2));
            //    Console.WriteLine(mysql_reader.GetString(3));
            //    Console.WriteLine(mysql_reader.GetString(4));

            //    Console.WriteLine();
            //}
        }

        internal ExecuteResult Login(string username, string password)
        {
            string sql = "SELECT username from user WHERE username='" 
                + username
                + "' AND userpw='"
                + password + "';";
            MySqlConnection mysql_conn = new MySqlConnection(str_conn);
            mysql_conn.Open();

            MySqlCommand mysql_cmd = new MySqlCommand(sql, mysql_conn);
            MySqlDataReader mysql_reader = mysql_cmd.ExecuteReader();
            var result = mysql_reader.Read();
            mysql_conn.Close();

            if (result)
            {
                return ExecuteResult.Success;
            }
            else
            {
                return ExecuteResult.Failure;
            }

        }

        internal Friend[] GetFriendList(string username)
        {
            string sql_num = "SELECT COUNT(*) FROM user WHERE username IN ( SELECT friendname FROM friends WHERE username='" 
                + username
                + "')";
            MySqlConnection conn = new MySqlConnection(str_conn);
            conn.Open();
            // 查询结果数目
            MySqlCommand cmd = new MySqlCommand(sql_num, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int result_num = 0;
            if(reader.Read())
            {
                result_num = reader.GetInt32(0);
            }
            conn.Close();

            // 查询结果
            string sql = "SELECT nickname, signature FROM user WHERE username IN ( SELECT friendname FROM friends WHERE username='" 
                + username
                + "')";
            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            Friend[] friends = new Friend[result_num];

            int index = 0;
            while (reader.Read())
            {
                friends[index] = new Friend(reader.GetString(0), reader.GetString(1)) ;
                ++index;
            }

            return friends;
        }
    }
}
