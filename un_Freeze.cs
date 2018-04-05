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
    public partial class un_Freeze : Form
    {
        private bool v = false;
        private int alteredOne = 0;
        public un_Freeze()
        {
            InitializeComponent();
            opt.Visible = false;
            freezetiplb.Visible = false;
            Days.Visible = false;
        }
        private void FreezeShow()
        {
            opt.Visible = true;
            freezetiplb.Visible = true;
            Days.Visible = true;
        }
        private void quit退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string uid = IDtxt.Text;
            if (uid != "")
            {
                User utemp = new User();
                try
                {
                    for(int i=0; ; i++)
                    {
                        utemp = FileDate.ReadOne<User>(i);
                        if (utemp.ID == uid)
                        {
                            v = utemp.Valid;
                            alteredOne = i;
                            state.Text = v ? "正常" : "被冻结";
                            opt.Text = v ? "冻结账号" : "解除冻结";
                            FreezeShow();
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
            //---------------------
            User utemp = FileDate.ReadOne<User>(alteredOne);
            string tip = utemp.Valid ? "被冻结" : "解除冻结";
            DialogResult dr = MessageBox.Show(utemp.ID + "即将" + tip, "重要提示",MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (utemp.Pri > Main.user.Pri || (int)utemp.Pri == 3)
                {
                    MessageBox.Show("你没有足够的权限执行此操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (utemp.Valid)
                    {
                        int dur = Convert.ToInt32(Days.Text);
                        FileDate.WriteInfo<Record>(new Record(OptType.冻结, Main.user.ID, utemp.ID, dur));
                    }
                    utemp.Valid = !utemp.Valid;
                    FileDate.WriteInfo<User>(utemp, alteredOne);
                    MessageBox.Show("操作成功！");
                    this.Close();
                }
            }
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
    }
}
