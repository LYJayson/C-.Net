using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8._8
{
    public partial class FmLogin : Form
    {
        private FmRegister fmRegister;
        private FmHome fmHome;
        public FmLogin()
        {
            InitializeComponent();
        }

        private void BtnT2_Click(object sender, EventArgs e)
        {
            fmRegister = new FmRegister();
            this.Hide();
            fmRegister.Show();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (TxtBoxUser.Text != "" && TxtBoxPwd.Text != "")
            {   
                MySQLite mySQLite = new MySQLite(TxtBoxUser.Text, TxtBoxPwd.Text);
                mySQLite.OpenMySQL();
                mySQLite.Queryfailure(out string ShowE);
                if (ShowE == "多次错误登录,程序终止!")
                {
                    MessageBox.Show(ShowE);
                    mySQLite.OpenMySQL();
                    mySQLite.Resetcount();
                    System.Environment.Exit(0);
                }
                else
                {
                    mySQLite.OpenMySQL();
                    mySQLite.QueryUName(out string ShowL);
                    if (ShowL != "登录成功!")
                    {
                        MessageBox.Show(ShowL);
                        mySQLite.OpenMySQL();
                        mySQLite.Failurecheck(out string ShowF);//查询User是否存在
                        if (ShowF == "User不存在")
                        {
                            MessageBox.Show("用户名或者密码错误!");
                        }
                        else
                        {
                            mySQLite.OpenMySQL();
                            mySQLite.Failurecount();//失败计数插入对应用户
                        }
                    }
                    else
                    {
                        fmHome = new FmHome();
                        this.Hide();
                        fmHome.Show();
                        MessageBox.Show(ShowL);
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入用户名和密码!");
            }
        }
        private void FmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TxtBoxUser.Text = "";
            TxtBoxPwd.Text = "";
        }
    }
}
