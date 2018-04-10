using System;
using System.IO;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class ChangePwd : Form
    {
        private Login relog;
        public ChangePwd(Login log)
        {
            InitializeComponent();
            relog = log;
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            bool done = false;
            if(AccountIDtxt.Text == "" || OriPwdtxt.Text == "" || NewPwdtxt.Text == "")
            {
                Tipslb.Text = "信息不能为空！请首先完善信息";
            }else if (RepeatPwdtxt.Text != NewPwdtxt.Text)
            {
                Tipslb.Text = "两次输入新密码不一致！请确认密码一致";
            }
            else
            {
                User utemp = new User(OriPwdtxt.Text.Trim());
                if (FileDate.Exist<User>(utemp))
                {
                    if (utemp.Valid)
                    {
                        utemp.Pwd = NewPwdtxt.Text;
                        FileDate.AlterInfo(utemp);
                        done = true;
                    }
                    else
                    {
                        Tipslb.Text = "账号已被冻结！请首先联系管理员解除冻结状态！";
                    }
                }
                else
                {
                    Tipslb.Text = "未找到用户信息！请确认是否输入了正确的信息";
                }
            }
            if (done)
            {
                DialogResult dr = MessageBox.Show("修改密码成功！需要重新登录你的账号,是否愿意？", "提示信息:", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                this.Close();
                if (dr == DialogResult.OK)
                {
                    relog.ShowDialog();
                }
                else
                {
                    Main.user = new User("匿名游客");
                }
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePwd_Load(object sender, EventArgs e)
        {
            AccountIDtxt.Text = OriPwdtxt.Text = NewPwdtxt.Text = RepeatPwdtxt.Text = "";
            Tipslb.Text = "建议新密码不要与原密码一致";
        }
    }
}
