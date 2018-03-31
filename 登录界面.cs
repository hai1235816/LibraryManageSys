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
        public Login(Main m)
        {
            InitializeComponent();
            main = m;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            bool qual = false;
            if (Vis.Checked)
            {
                Main.user = new User("Visitor");
                qual = true;
            }
            else if (!(Stu.Checked || Worker.Checked || Admin.Checked))
            {
                MessageBox.Show("请选择你的登录身份！");
                return;
            }
            else
            {
                User utemp = new User();
                try
                {
                    for(int i = 0; ; i++)
                    {
                        utemp = FileDate.ReadOne<User>(i);
                        if (utemp.ID == IDtxt.Text && utemp.Pwd == PWDtxt.Text)
                        {
                            if (!utemp.Valid)
                            {
                                MessageBox.Show("账号已被冻结！请首先联系管理员解除冻结状态！");
                                return;
                            }
                            if ((Stu.Checked && utemp.Pri == Privilege.学生)
                                || (Worker.Checked && utemp.Pri == Privilege.职工)
                                || (Admin.Checked && utemp.Pri == Privilege.管理员))
                            {
                                qual = true;
                                Main.user = new User(utemp);
                                break;
                            }
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    //Console.WriteLine(e.Message);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            if (qual)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("未找到用户信息，用户名或密码或者登录身份错误.");
            }
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
