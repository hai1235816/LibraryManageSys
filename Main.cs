using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class Main : Form
    {
        public static bool priorityOver(Privilege pri)
        {
            if (Main.user.Pri >= pri) return true;
            else
            {
                MessageBox.Show("权限不足！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static User user;
        public ChangePwd changePwd;
        public FillInfo fillInfo;
        public Login login;
        public un_Freeze freeze;
        public Main()
        {
            InitializeComponent();
            login = new Login(this);
            if (true)
            {
                /*User u1 = new User(true, Privilege.学生, "16020031111", "OUCer", "123456");
            User u2 = new User(false, Privilege.职工, "16020031231", "玉良红", "987452");
            User u3 = new User(true, Privilege.学生, "16020031561", "梁园", "654123");
            User u4 = new User(true, Privilege.管理员, "123456", "Master", "123456");
            BookMaster t = new BookMaster();
            FileDate.WriteInfo<BookMaster>(t);
            if (File.Exists("User.dat"))
            {
                File.Delete("User.dat");
            }
            FileDate.WriteInfo(u1);
            FileDate.WriteInfo(u2);
            FileDate.WriteInfo(u3);
            FileDate.WriteInfo(u4);*/
            }
            
        }
        private void Main_Load(object sender, EventArgs e)
        {
            login.ShowDialog();
        }
        //每次程序启动，都会调用这个函数把过时的预约记录清除（有效位作废）
        public void updateRecord()
        {
            int len = 0;
            using(FileStream fs = new FileStream("Record.dat", FileMode.Open))
            {
                len = (int)fs.Length / Marshal.SizeOf(typeof(Record));
            }
            Record rec = new Record();
            try
            {
                for(int i = 1; i < len / 2 ; i++)
                {
                    rec = FileDate.ReadOne<Record>(len - i);
                    if(rec.Type==OptType.预约 && rec.Unmatch && rec.spanDaysToPresent() > 3)
                    {
                        rec.Dur = -1;
                        rec.Unmatch = false;
                        FileDate.WriteInfo(rec, len - i);
                        break;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updateStatus()
        {
            DateTimeStatus.Text = DateTime.Now.ToLongDateString();
            PrivilegeStatus.Text = user.Pri.ToString();
        }
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.ID.ToString());
        }

        private void 注销登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定注销登录？", "提示", MessageBoxButtons.OK);
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
            if (!priorityOver(Privilege.职工)) return;
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
            if (freeze == null || freeze.IsDisposed)
            {
                freeze = new un_Freeze();
            }
            freeze.Show();
        }

        private void 冻结账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (freeze == null || freeze.IsDisposed)
            {
                freeze = new un_Freeze();
            }
            freeze.Show();
        }
    }
}
