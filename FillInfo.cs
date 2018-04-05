using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class FillInfo : Form
    {
        public FillInfo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountIDtxt.Text == "" || Passwordtxt.Text == "" || nametxt.Text == "")
            {
                MessageBox.Show("信息填写不能为空，请完善信息！", "温馨提示");
                return;
            }
            if (checkPwdtxt.Text != Passwordtxt.Text)
            {
                MessageBox.Show("两次密码输入不一致！","温馨提示");
                return;
            }
            if (stu.Checked || worker.Checked || admin.Checked)
            {
                Privilege pri = Privilege.学生;
                if (admin.Checked) pri = Privilege.管理员;
                else if (worker.Checked) pri = Privilege.职工;
                bool ismale = Convert.ToBoolean(gender.SelectedIndex);
                User user = new User(ismale, pri, AccountIDtxt.Text, nametxt.Text, Passwordtxt.Text);
                FileDate.WriteInfo(user);
                tipslb.Text = "用户信息添加成功！";
                AccountIDtxt.Text = nametxt.Text = Passwordtxt.Text = checkPwdtxt.Text = "";
            }
            else
            {
                MessageBox.Show("请选择用户身份！", "提示");
            }
        }

        private void quit退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AccountIDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b')
            {
                if (c < '0' || c > '9' || AccountIDtxt.Text.Length >= 12)
                {
                    e.Handled = true;
                }
            }
        }

        private void gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
