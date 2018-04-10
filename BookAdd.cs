using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class BookAdd : Form,ICheck
    {
        public BookAdd()
        {
            InitializeComponent();
        }

        public bool Check()
        {
            if (bkTypebox.SelectedIndex < 0)
            {
                MessageBox.Show("需要选择图书种类", "提示");
                return false;
            }
            else if (bknametxt.Text.Length > ConstVar.BOOK_NAME_SIZE)
            {
                MessageBox.Show("书名长度不符合要求！", "提示");
                return false;
            }
            else if (presstxt.Text.Length > ConstVar.BOOK_PRESS_SIZE)
            {
                MessageBox.Show("出版社长度不符合要求！", "提示");
                return false;
            }
            else if (isbntxt.Text.Length > ConstVar.ISBN_SIZE)
            {
                MessageBox.Show("ISBN长度不符合要求！", "提示");
                return false;
            }
            else if (authortxt.Text.Length > ConstVar.BOOK_AUTHOR_SIZE)
            {
                MessageBox.Show("作者名称长度不符合要求！", "提示");
                return false;
            }
            else if (Convert.ToUInt32(NUMtxt.Text) > 20)
            {
                MessageBox.Show("一次最多录入20本书籍", "提示");
                return false;
            }
            return true;
        }

        private void NUMtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b')
            {
                if (c < '0' || c > '9')
                {
                    e.Handled = true;
                }
                else if(c == '0' && NUMtxt.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                uint sum = Convert.ToUInt32(NUMtxt.Text);
                Book book = new Book(bknametxt.Text, isbntxt.Text, presstxt.Text, authortxt.Text, (BookType)bkTypebox.SelectedIndex);
                BookMaster master = new BookMaster(sum, book);
                if (FileDate.Exist<BookMaster>(master))
                {
                    DialogResult dr = MessageBox.Show("此书已经存在，要直接添加吗？", "重要提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        master.Total_num += sum;
                        FileDate.AlterInfo<BookMaster>(master);
                    }
                    else
                    {
                        return;
                    }
                }
                FileDate.WriteInfo(book);
                MessageBox.Show("书籍添加成功！", "通知");
            }
        }

        private void isbntxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b')
            {
                if (c < '0' || c > '9')
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bknametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断书名输入是否规范
        }

        private void authortxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断作者名输入是否规范
        }

        private void presstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断出版社名输入是否规范
        }

        private void bkTypebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
