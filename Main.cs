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
            if (Main.user.Pri > pri) return true;
            else
            {
                MessageBox.Show("权限不足！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static User user;
        //更新当前用户数据
        public static void update()
        {
            FileDate.AlterInfo(Main.user);
        }
        public Login login;
        private SearchBooks searchBooks;
        private InfoCenter infocenter;
        private BookAdd bookAdd;
        private ChangePwd changePwd;
        private FillInfo fillInfo;
        private Freeze freeze;
        private Unfreeze unfreeze;
        private RecordSearch recordSearch;
        public Main()
        {
            InitializeComponent();
            if (File.Exists("Lib_Mana_Sys.User.dat"))
            {
                File.Delete("Lib_Mana_Sys.User.dat");
            }
            if (File.Exists("Lib_Mana_Sys.BookMaster.dat"))
            {
                File.Delete("Lib_Mana_Sys.BookMaster.dat");
            }
            if (File.Exists("Lib_Mana_Sys.Record.dat"))
            {
                File.Delete("Lib_Mana_Sys.Record.dat");
            }
            User u1 = new User(true, Privilege.学生, "16020031111", "OUCer", "123456");
            User u2 = new User(false, Privilege.职工, "16020031231", "玉良红", "987452");
            User u3 = new User(true, Privilege.学生, "16020031561", "梁园", "654123");
            User u4 = new User(true, Privilege.管理员, "123456", "Master", "123456");
            Book b1 = new Book("Java从入门到放弃", "6456516316416", "人民教育出版社", "Master", BookType.数理科学与化学);
            BookMaster master = new BookMaster(10, b1);
            FileDate.WriteInfo(master);
            Book b2 = new Book("C Plus从入门到入土", "1156416454652", "仁爱教育出版社", "Oh Yes", BookType.哲学宗教);
            master = new BookMaster(6, b2);
            FileDate.WriteInfo(master);
            FileDate.WriteInfo(u2);
            FileDate.WriteInfo(u3);
            FileDate.WriteInfo(u4);
            FileDate.WriteInfo(u1);
            login = new Login(this);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            login.ShowDialog();
        }
        
        public void updateStatus()
        {
            DateTimeStatus.Text = DateTime.Now.ToLongDateString();
            PrivilegeStatus.Text = user.Pri.ToString();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uint size = FileDate.CountOf<Record>();
            for (int i = 0; i < size ; i++)
            {
                FileDate.ReadOne<Record>(i).debug();
            }
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
            if (Main.user.Pri == Privilege.游客)
            {
                MessageBox.Show("游客止步", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        //actually this one should be "账号解冻"
        private void 删除图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Main.user.Pri == Privilege.游客)
            {
                MessageBox.Show("游客止步", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (unfreeze==null || unfreeze.IsDisposed)
            {
                unfreeze = new Unfreeze();
                unfreeze.MdiParent = this;
            }
            unfreeze.Show();
        }

        private void 冻结账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Main.user.Pri == Privilege.游客)
            {
                MessageBox.Show("游客止步", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (freeze == null || freeze.IsDisposed)
            {
                freeze = new Freeze();
                freeze.MdiParent = this;
            }
            freeze.Show();
        }

        private void 书籍查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(searchBooks==null || searchBooks.IsDisposed)
            {
                searchBooks = new SearchBooks();
                //searchBooks.MdiParent = this;
            }
            searchBooks.Show();
        }

        private void 添加图书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Main.priorityOver(Privilege.学生)) return;
            if(bookAdd==null || bookAdd.IsDisposed)
            {
                bookAdd = new BookAdd();
                bookAdd.MdiParent = this;
            }
            bookAdd.Show();
        }

        private void 个人中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (infocenter == null || infocenter.IsDisposed)
            {
                infocenter = new InfoCenter();
                infocenter.MdiParent = this;
            }
            infocenter.Show();
        }

        private void 书籍归还ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Main.user.Pri == Privilege.游客)
            {
                MessageBox.Show("游客止步", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void 记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(recordSearch==null || recordSearch.IsDisposed)
            {
                recordSearch = new RecordSearch();
                recordSearch.MdiParent = this;
            }
            recordSearch.Show();
        }
    }
}
