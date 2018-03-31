using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class Main : Form
    {
        public static User user;
        public ChangePwd changePwd;
        public FillInfo fillInfo;
        public Login login;
        public Main()
        {
            InitializeComponent();
            login = new Login(this);
            User u1 = new User(Privilege.学生, "16020031111", "OUCer", "123456");
            User u2 = new User(Privilege.职工, "16020031111", "玉良红", "987452");
            User u3 = new User(Privilege.学生, "16020031111", "梁园", "654123");
            User u4 = new User(Privilege.管理员, "123456", "Master", "698547");
            FileDate.WriteInfo(u1);
            FileDate.WriteInfo(u2);
            FileDate.WriteInfo(u3);
            FileDate.WriteInfo(u4);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            login.ShowDialog();
            DateTimeStatus.Text = DateTime.Now.ToLongDateString();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.ID.ToString());
        }

        private void 注销登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定注销登录？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (login.IsDisposed || login == null )
                {
                    login = new Login(this);
                }
                login.ShowDialog();
            }
        }

        private void 添加职工ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(fillInfo==null || fillInfo.IsDisposed)
            {
                fillInfo = new FillInfo();
                fillInfo.MdiParent = this;
            }
            fillInfo.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changePwd == null || changePwd.IsDisposed)
            {
                if(login == null || login.IsDisposed)
                {
                    login = new Login(this);
                }
                changePwd = new ChangePwd(login);
            }
            changePwd.Show();
        }

        private void 添加职工ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
