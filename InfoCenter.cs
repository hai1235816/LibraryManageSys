using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Mana_Sys
{
    public partial class InfoCenter : Form
    {
        private Charge charge;
        private DataTable table;
        private void update()
        {
            Statelb.Text = Main.user.Valid ? "正常" : "被冻结";
            bor_numlb.Text = Main.user.BorrowBook.Count.ToString();
            balancelb.Text = Main.user.Balance.ToString();
            table.Clear();
            foreach (uint bkid in Main.user.BorrowBook)
            {
                Book book = FileDate.FindObjByID<BookMaster>(bkid.ToString()).Info;
                table.Rows.Add(book.Name, book.Author, book.ISBN, book.Press, book.Type, "已借阅");
                table.AcceptChanges();
            }
        }
        public InfoCenter()
        {
            InitializeComponent();
            table = new DataTable("Table_State");
            table.Columns.Add("书名");
            table.Columns.Add("作者");
            table.Columns.Add("ISBN");
            table.Columns.Add("出版社");
            table.Columns.Add("书籍类型");
            table.Columns.Add("操作");
            update();
            dataGridView1.DataSource = table;
        }

        private void quit退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chargebtn_Click(object sender, EventArgs e)
        {
            if (charge == null || charge.IsDisposed)
            {
                charge = new Charge();
            }
            charge.ShowDialog();
        }

        private void InfoCenter_Load(object sender, EventArgs e)
        {
            this.Text = Main.user.Name + "的个人中心";
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].IsNewRow) return;
            DialogResult dr = MessageBox.Show("确定要归还这本书吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string isbn = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Main.user.givebackTo(FileDate.SearchByISBN(isbn)[0]);
            }
        }
    }
}
