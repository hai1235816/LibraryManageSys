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
    public partial class BookAlter : Form
    {
        private BookMaster master;
        private bool found;
        private void display()
        {
            Book book = master.Info;
            showInfotxt.Text = "书籍名称：" + book.Name +
                "\r\n作者：" + book.Author +
                "\r\nISBN：" + book.ISBN +
                "\r\n出版社：" + book.Press +
                "\r\n总数量" + master.Total_num.ToString() +
                "\r\n可借数量：" + master.Access_num.ToString();
        }
        public BookAlter()
        {
            InitializeComponent();
            master = new BookMaster();
            found = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BookAlter_Load(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string isbn = isbntxt.Text;
            //重复点击直接跳过
            if (master.Info.ISBN == isbn || "" == isbn)
            {
                if (isbn != "") display();
                else
                {
                    tipslb.Text = "ISBN不能为空";
                }
                return;
            }
            List<BookMaster> list = FileDate.SearchByISBN(isbn);
            if (list.Count > 0)
            {
                master = list[0];
                found = true;
                display();
            }
            else
            {
                showInfotxt.Text = "未找到相关信息，确认ISBN输入是否正确";
            }
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (found)
            {
                Book book = master.Info;
                if (nameAlter.Checked) book.Name = alteredInfotxt.Text;
                else if (authAlter.Checked) book.Author = alteredInfotxt.Text;
                else if (isbnAlter.Checked) book.ISBN = alteredInfotxt.Text;
                else if (pressAlter.Checked) book.Press = alteredInfotxt.Text;
                else
                {
                    tipslb.Text = "请选择要修改哪一项";
                    return;
                }
                master = new BookMaster(master.Total_num, book);
                MessageBox.Show("修改成功", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileDate.AlterInfo<BookMaster>(master);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (found)
            {
                DialogResult dr = MessageBox.Show("确定要删除这类书吗？", "重要提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    FileDate.Delete<BookMaster>(master);
                    master = new BookMaster();
                    showInfotxt.Text = "";
                }
            }
            else
            {
                tipslb.Text = "请先确认书籍信息再进行操作";
            }
        }

        private void isbntxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b')
            {
                if (c < '0' || c > '9' || isbntxt.Text.Length >= ConstVar.ISBN_SIZE)
                {
                    e.Handled = true;
                }
            }
        }

        private void alteredInfotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (isbnAlter.Checked && c != '\b')
            {
                if (c < '0' || c > '9' || alteredInfotxt.Text.Length >= ConstVar.ISBN_SIZE)
                {
                    e.Handled = true;
                }
            }
        }

        private void nameAlter_CursorChanged(object sender, EventArgs e)
        {
            alteredInfotxt.Text = "";
        }
    }
}
