using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SecurityServer;
using SecurityServer.DbOperation;
using System.IO;

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
            str_conn = "Database=db_chat_server;Data Source=localhost;User Id=root;Password=123456;Charset=utf8";
        }

        internal User Login(string username, string password)
        {
            try
            {
                string sql = "SELECT username, nickname, signature from user WHERE username='"
                    + username
                    + "' AND userpw='"
                    + password + "';";

                Log(sql);



                MySqlConnection mysql_conn = new MySqlConnection(str_conn);
                mysql_conn.Open();

                MySqlCommand mysql_cmd = new MySqlCommand(sql, mysql_conn);
                MySqlDataReader mysql_reader = mysql_cmd.ExecuteReader();

                ///////////////////////////
                // 参数绑定测试 删除 2017/5/19

                //mysql_cmd.CommandText = sql;
                //mysql_cmd.Parameters.Add();


                ///////////////////////////

                User user = new User();
                if (mysql_reader.Read())
                {
                    user.Username = mysql_reader.GetString(0);
                    user.Nickname = mysql_reader.GetString(1);
                    user.Signature = mysql_reader.GetString(2);
                    Log(user.Username);
                }
                else
                {
                    user = null;
                }
                mysql_conn.Close();

                return user;
            }
            catch (Exception ex)
            {
                Log(ex.ToString());

                

                return null;
            }
        }

        public static void Log(string source)
        {
            string path = "C:\\log.txt";
            FileStream f = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(f);
            sw.WriteLine(source);
            sw.Flush();
            sw.Close();
            f.Close();
        }

        internal Friend[] GetFriendList(string username)
        {
            string sql_num = "SELECT COUNT(*) FROM user INNER JOIN friends " 
                + "ON user.username = friends.friendname WHERE friends.username = '"
                + username + "'";
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
            string sql = "SELECT user.username, friends.notename, user.signature FROM user INNER JOIN friends " 
                + "ON user.username = friends.friendname WHERE friends.username = '"
                + username + "'";

            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            Friend[] friends = new Friend[result_num];

            int index = 0;
            while (reader.Read())
            {
                friends[index] = new Friend(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2)
                    ) ;
                ++index;
            }
            conn.Close();

            return friends;
        }

        internal bool UpdateUser(string username, string nickname, string signature)
        {
            string sql = "UPDATE user SET nickname='"
                + nickname + "', signature = '" 
                + signature + "' WHERE username = '" 
                + username +"'";
            MySqlConnection conn = new MySqlConnection(str_conn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        internal bool UpdateNote(string username, string friendname, string notename)
        {
            string sql = "UPDATE friends SET notename = '"
                + notename + "' WHERE username = '" 
                + username + "' AND friendname = '" 
                + friendname + "'";

            MySqlConnection conn = new MySqlConnection(str_conn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        internal bool DeleteFriend(string username, string friend_username)
        {
            string sql = "DELETE FROM friends where friendname = '"
                + friend_username + "' AND username = '" 
                + username + "'";
            MySqlConnection conn = new MySqlConnection(str_conn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        internal bool UpdatePw(string username, string password, string new_password)
        {
            string sql = "UPDATE user SET userpw='"
                + new_password + "' WHERE username = '"
                + username + "' AND userpw='"
                + password + "'";
            MySqlConnection conn = new MySqlConnection(str_conn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal User SearchFriend(string username)
        {
            try
            {
                string sql = "SELECT username, nickname, signature from user WHERE username='"
                    + username
                    + "';";
                MySqlConnection mysql_conn = new MySqlConnection(str_conn);
                mysql_conn.Open();

                MySqlCommand mysql_cmd = new MySqlCommand(sql, mysql_conn);
                MySqlDataReader mysql_reader = mysql_cmd.ExecuteReader();

                User user = new User();
                if (mysql_reader.Read())
                {
                    user.Username = mysql_reader.GetString(0);
                    user.Nickname = mysql_reader.GetString(1);
                    user.Signature = mysql_reader.GetString(2);
                }
                else
                {
                    user = null;
                }
                mysql_conn.Close();

                return user;
            }
            catch (Exception ex)
            {
                Log(ex.ToString());



                return null;
            }
        }

        internal bool AddFriend(string username, string frined_username, string frind_notename)
        {
            string sql = "INSERT INTO friends VALUES('" 
                + frined_username + "', '" 
                + username + "', '" 
                + frind_notename + "')";
            MySqlConnection conn = new MySqlConnection(str_conn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
