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
    public partial class FmRegister : Form
    {
        private FmLogin FormLogin;
        public FmRegister()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (TxtBoxUser.Text != "" && TxtBoxUser.Text != "" && TxtBoxUser.Text != "")
            {
                MySQLite mySQLite = new MySQLite(TxtBoxUser.Text, TxtBoxPwd1.Text, TxtBoxPwd2.Text);
                mySQLite.Pwdverification();
                mySQLite.OpenMySQL();
                mySQLite.InsertUName(out string ShowR);
                MessageBox.Show(ShowR);
            }
            else
            {
                MessageBox.Show("用户名或者密码无效!");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TxtBoxUser.Text = ""; TxtBoxPwd1.Text = ""; TxtBoxPwd2.Text = "";
        }

        private void BtnT2_Click(object sender, EventArgs e)
        {
            FormLogin = new FmLogin();
            this.Hide();
            FormLogin.Show();
        }
    }
}
