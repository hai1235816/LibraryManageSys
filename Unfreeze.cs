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
        private int alteredOne;
        private bool FindUser;
        public Unfreeze()
        {
            InitializeComponent();
            FindUser = false;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string uid = IDtxt.Text;
            if (uid != "")
            {
                User utemp = new User();
                try
                {
                    for (int i = 0; ; i++)
                    {
                        utemp = FileDate.ReadOne<User>(i);
                        if (utemp.ID == uid)
                        {
                            alteredOne = i;
                            FindUser = true;
                            state.Text = utemp.Valid ? "正常" : "被冻结";
                            break;
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    state.Text = "未找到账号相关信息";
                }
            }
        }

        private void opt_Click(object sender, EventArgs e)
        {
            if (!FindUser)
            {
                state.Text = "请首先确认账号信息";
                return;
            }
            User utemp = FileDate.ReadOne<User>(alteredOne);
            if (!utemp.Valid)
            {
                //如果操作者权限大于被操作者，操作有效
                if (Main.priorityOver(utemp.Pri))
                {
                    FileDate.WriteInfo(utemp, alteredOne);
                    FileDate.MatchRecord(OptType.冻结, utemp.ID);
                    MessageBox.Show("账户解冻成功.", "通知");
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
