using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class FillInfo : Form /*,ICheck */
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
            if (stu.Checked || worker.Checked)
            {
                Privilege pri = Privilege.学生;
                if (worker.Checked) pri = Privilege.职工;
                bool ismale = Convert.ToBoolean(gender.SelectedIndex);
                User user = new User(ismale, pri, AccountIDtxt.Text, nametxt.Text, Passwordtxt.Text);
                if (FileDate.Exist<User>(user))
                {
                    MessageBox.Show("该用户已经存在！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
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
                if (c < '0' || c > '9' || AccountIDtxt.Text.Length >= ConstVar.USER_ID_SIZE)
                {
                    e.Handled = true;
                }
            }
        }

        private void gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || nametxt.Text.Length >= ConstVar.USER_NAME_SIZE)
            {
                e.Handled = true;
            }
        }

        private void Passwordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || Passwordtxt.Text.Length >= ConstVar.USER_PWD_SIZE)
            {
                e.Handled = true;
            }
        }

        private void checkPwdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || checkPwdtxt.Text.Length >= ConstVar.USER_PWD_SIZE)
            {
                e.Handled = true;
            }
        }
    }
}
