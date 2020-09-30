using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace Project8._8
{
    class MySQLite
    {
        /// <summary>
        /// 用户的用户名和密码(查询数据)
        /// </summary>
        private string user;
        private string pwd;
        public string User
        {
            get
            {
                return user;
            }
            set
            {
                if(value != "")
                {
                    user = value;
                }
                else
                {
                    user = "null";
                }
            }
        }
        public string Pwd
        {
            get
            {
                return pwd;
            }
            set
            {
                if (value != "")
                {
                    pwd = value;
                }
                else
                {
                    pwd = "null";
                }
            }
        }
        /// <summary>
        /// 新用户的用户名和密码(插入数据)
        /// </summary>
        private string ruser;
        private string rpwd;
        private string rpwd1;
        private string rpwd2;
        public string RPwd
        {
            get
            {
                return rpwd;
            }
            set
            {
                rpwd = value;
            }
        }
        public string RUser
        {
            get
            {
                return ruser;
            }
            set
            {
                ruser = value;
            }
        }
        public string RPwd1
        {
            get
            {
                return rpwd1;
            }
            set
            {
                rpwd1 = value;
            }
        }
        public string RPwd2
        {
            get
            {
                return rpwd2;
            }
            set
            {
                rpwd2 = value;
            }
        }
        /// <summary>
        /// MySQL链接串
        /// </summary>
        private String SQL_ConnectStr = "server=127.0.0.1;port=3306;user=root;password=123456;database=liuyu";
        public MySqlConnection MySqlConnection;
        /// <summary>
        /// 查询通道
        /// </summary>
        public void OpenMySQL()
        {
            MySqlConnection = new MySqlConnection(SQL_ConnectStr);
            if(MySqlConnection != null)
            {
                MySqlConnection.Open();//开启SQL查询通道
                Console.WriteLine("查询通道打开");
            }
            else
            {
                Console.WriteLine("查询通道打开失败!");
            }
        }
        /// <summary>
        ///  查询用户名(UName,UPwd)
        /// </summary>
        public void QueryUName(out string ShowL)
        {
            string A;
            string sql_select_user = "SELECT * FROM guser WHERE UName='" + User + "' and UPwd='" + Pwd + "';";
            MySqlCommand mySqlCommand = new MySqlCommand(sql_select_user, MySqlConnection);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                A = "登录成功!";
            }
            else
            {

                A = "用户名或者密码错误！";
            }
            ShowL = A;
            Disconnect();
        }
        /// <summary>
        /// 注册前验证二次输入密码
        /// </summary>
        public void Pwdverification()
        {
            if (rpwd1 == rpwd2)
            {
                RPwd = rpwd1;
                Console.WriteLine("注册密码验证完成");
            }
        }
        /// <summary>
        ///  插入用户(注册新用户)
        /// </summary>
        public void InsertUName(out string ShowR)
        {
            string A;
            string sql_insert_user = "INSERT INTO guser(UName,UPwd)VALUES('" + RUser + "','" + RPwd + "');";
            MySqlCommand mySqlCommand = new MySqlCommand(sql_insert_user, MySqlConnection);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                A = "注册失败,用户名或者密码无效!"; 
            }
            else
            {
                A = "注册成功!";
            }
            ShowR = A;
            Disconnect();
        }
        /// <summary>
        /// 中断连接MySQL
        /// </summary>
        public void Disconnect()
        {
            MySqlConnection.Close();
        }
        /// <summary>
        /// 登录失败计数器(Failurecheck|Failurecount)
        /// </summary>
        public void Failurecheck(out string ShowF)
        {
            string A;
            //User 用户名 计数
            string sql_select_user = "SELECT * FROM guser WHERE UName='" + User + "';";
            MySqlCommand mySqlCommand = new MySqlCommand(sql_select_user, MySqlConnection);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                Console.WriteLine("User存在");
                A = "User存在";
            }
            else
            {
                Console.WriteLine("User不存在");
                A = "User不存在";
            }
            ShowF = A;
            Disconnect();
        }
        public void Failurecount()
        {
            string sql_update_user = "UPDATE guser set login_failure_count=login_failure_count+1 WHERE UName='" + User + "';";
            MySqlCommand mySqlCommand = new MySqlCommand(sql_update_user, MySqlConnection);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                Console.WriteLine("User无效无法执行");
            }
            else
            {
                Console.WriteLine("已执行");
            }
        }
        /// <summary>
        /// 查询用户是否多次错误登录
        /// </summary>
        public void Queryfailure(out string ShowE)
        {
            string A;
            string sql_select_user = "SELECT * FROM guser WHERE UName='" + User + "' and login_failure_count>=3;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql_select_user, MySqlConnection);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                A = "多次错误登录,程序终止!";
            }
            else
            {
                A = "用户名或者密码错误！";
            }
            ShowE = A;
            Disconnect();
        }
        /// <summary>
        /// 在程序终止后重置登录失败的计数
        /// </summary>
        public void Resetcount()
        {
            string sql_update_user = "UPDATE guser SET login_failure_count=0 WHERE UName='" + User + "' and login_failure_count>=3;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql_update_user, MySqlConnection);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                Console.WriteLine("无法重置未知错误");
            }
            else
            {
                Console.WriteLine("已执行重置");
            }
            Disconnect();
        }
        /// <summary>
        /// MySQLite类多个构造函数
        /// </summary>
        public MySQLite()
        {
        }
        public MySQLite(string user,string pwd)
        {
            User = user;
            Pwd = pwd;
        }
        public MySQLite(string ruser, string rpwd1, string rpwd2)
        {
            RUser = ruser;
            RPwd1 = rpwd1;
            RPwd2 = rpwd2;
        }
    }
}