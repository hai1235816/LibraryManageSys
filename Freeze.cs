using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class Freeze : Form
    {
        private bool FindUser;
        private User utemp;
        public Freeze()
        {
            InitializeComponent();
            FindUser = false;
        }
        private void quit退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            if (!FindUser)
            {
                state.Text = "请首先确认账号信息";
                return false;
            }
            if (IDtxt.Text.Length == 0)
            {
                state.Text = "请输入账号";
                return false;
            }
            return true;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string uid = IDtxt.Text;
            FindUser = FileDate.Exist<User>(new User(uid));
            if (FindUser)
            {
                utemp = FileDate.FindObjByID<User>(uid);
                state.Text = utemp.Valid ? "正常" : "被冻结";
            }
            else
            {
                state.Text = "未找到账号相关信息";
            }
        }

        private void opt_Click(object sender, EventArgs e)
        {
            if (!Check()) return;
            bool firm = false;
            if (utemp.Valid)
            {
                //冻结自身账号
                if(Main.user.ID == utemp.ID)
                {
                    DialogResult dr = MessageBox.Show("确定要冻结自身账号？", "重要提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    firm = dr == DialogResult.Yes;
                }
                else
                {
                    //如果操作者权限高于被操作者，操作有效
                    if (Main.priorityOver(utemp.Pri)) firm = true;
                }
                if (firm)
                {
                    int dur = Convert.ToInt32(Days.Text);
                    utemp.Valid = false;
                    FileDate.AlterInfo<User>(utemp);
                    FileDate.WriteInfo<Record>(new Record(OptType.冻结, Main.user.ID, utemp.ID, dur));
                    MessageBox.Show("冻结账户成功.", "通知");
                }
            }
            else
            {
                //账号已经被冻结
                MessageBox.Show("无效的操作！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void IDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b')
            {
                if (c < '0' || c > '9' || IDtxt.Text.Length >= 12)
                {
                    e.Handled = true;
                }
            }
        }

        private void Days_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {
            FindUser = false;
            state.Text = "等待查询";
        }
    }
}
