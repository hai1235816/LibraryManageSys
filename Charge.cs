using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class Charge : Form
    {
        public Charge()
        {
            InitializeComponent();
        }

        private void amounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b')
            {
                if (c < '0' || c > '9' || amounttxt.Text.Length >= 3)
                {
                    e.Handled = true;
                }else if (c == '0' && amounttxt.TextLength == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            float amount;
            try
            {
                amount = Convert.ToSingle(amounttxt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("输入金额非法！", "提示");
                return;
            }
            if (amount > 200)
            {
                MessageBox.Show("每次缴纳金额不能大于200，请修改后重试", "提示");
            }
            else
            {
                Main.user.Balance += amount;
                Main.update();
                MessageBox.Show("缴费成功！", "通知");
                this.Close();
            }
        }

        private void Charge_Load(object sender, EventArgs e)
        {
            amounttxt.Text = "";
        }

        private void amounttxt_TextChanged(object sender, EventArgs e)
        {
            if (amounttxt.Text.Length == 0)
            {
                tipslb.Text = "充值金额不能为空";
            }
            else
            {
                tipslb.Text = "只支持充值整数金额";
            }
        }
    }
}
