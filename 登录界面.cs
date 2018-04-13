using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class Login : Form
    {
        public Main main;
        private bool qual;
        public Login(Main m)
        {
            InitializeComponent();
            main = m;
            qual = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (Vis.Checked)
            {
                Main.user = new User("Visitor");
                qual = true;
            }
            else if (!(Stu.Checked || Worker.Checked || Admin.Checked))
            {
                MessageBox.Show("请选择你的登录身份！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                User utemp = new User();
                uint size = FileDate.CountOf<User>();
                for (int i = 0; i < size ; i++)
                {
                    utemp = FileDate.ReadOne<User>(i);
                    if (utemp.ID == IDtxt.Text && utemp.Pwd == PWDtxt.Text)
                    {
                        if ((Stu.Checked && utemp.Pri == Privilege.学生)
                            || (Worker.Checked && utemp.Pri == Privilege.职工)
                            || (Admin.Checked && utemp.Pri == Privilege.管理员))
                        {
                            qual = true;
                            Main.user = new User(utemp);
                            main.updateStatus();
                            break;
                        }
                    }
                }
            }
            if (qual)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("未找到用户信息，用户名或密码或者登录身份错误.", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!qual)
            {
                MessageBox.Show("用户必须登录才能继续！(可以游客身份登录)", "提示");
                e.Cancel = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Main.user.Pri != Privilege.游客)
            {
                //每次程序启动，都会把过时的预约记录清除（有效位作废）
                Main.user.Syncr();
            }
        }

        private void IDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b')
            {
                if (c < '0' || c > '9' || IDtxt.Text.Length >= ConstVar.USER_ID_SIZE)
                {
                    e.Handled = true;
                }
            }
        }

        private void PWDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ' || PWDtxt.Text.Length >= ConstVar.USER_PWD_SIZE)
            {
                e.Handled = true;
            }
        }
    }
}