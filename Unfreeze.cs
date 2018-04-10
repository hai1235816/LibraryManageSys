using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class Unfreeze : Form
    {
        private User utemp;
        private bool FindUser;
        public Unfreeze()
        {
            InitializeComponent();
            FindUser = false;
        }

        private bool Check()
        {
            if (IDtxt.Text.Length == 0)
            {
                state.Text = "请输入账号";
                return false;
            }
            if (!FindUser)
            {
                state.Text = "请首先确认账号信息";
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
            if (!utemp.Valid)
            {
                //如果操作者权限大于被操作者，操作有效
                if (Main.priorityOver(utemp.Pri))
                {
                    if (utemp.Balance < 0)
                    {
                        MessageBox.Show("请帮TA充值后再尝试解冻", "账户余额不足", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        utemp.Valid = true;
                        FileDate.AlterInfo(utemp);
                        FileDate.MatchRecord(OptType.冻结, utemp.ID);
                        MessageBox.Show("账户解冻成功.", "通知");
                    }
                }
            }
            else
            {
                //如果账号正常那么就无需解冻
                MessageBox.Show("无效的操作！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void quit退出_Click(object sender, EventArgs e)
        {
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

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {
            FindUser = false;
        }
    }
}
