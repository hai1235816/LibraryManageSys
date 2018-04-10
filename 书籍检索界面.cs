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
    public partial class SearchBooks : Form
    {
        DataTable table;
        private List<BookMaster> SearchByKeyword(Book book)
        {
            List<BookMaster> bklist = new List<BookMaster>();
            BookMaster master = new BookMaster();
            try
            {
                for (int i = 0; ; i++)
                {
                    master = FileDate.ReadOne<BookMaster>(i);
                    if (master.SimiliarTo(book))
                    {
                        bklist.Add(master);
                    }
                }
            }
            catch (ArgumentException)
            {

            }
            return bklist;
        }
        public SearchBooks()
        {
            InitializeComponent();
            table = new DataTable("Table_Book");
            table.Columns.Add("书名");
            table.Columns.Add("作者");
            table.Columns.Add("ISBN");
            table.Columns.Add("出版社");
            table.Columns.Add("书籍类型");
            dataGridView1.DataSource = table;
        }

        public void Add(Book book)
        {
            table.Rows.Add(book.Name, book.Author, book.ISBN, book.Press, book.Type);
        }

        private void search_Click(object sender, EventArgs e)
        {
            string key = keywordtxt.Text;
            if (key == "") return;
            if (key.Length < 4 && isbn_rbtn.Checked)
            {
                MessageBox.Show("ISBN检索至少要输入4位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            table.Clear();
            Book book = new Book();
            book.Name = bkname_rbtn.Checked ? key : "";
            book.Author = auth_rbtn.Checked ? key : "";
            book.ISBN = isbn_rbtn.Checked ? key : "";
            book.Press = press_rbtn.Checked ? key : "";
            List<BookMaster> bklist = SearchByKeyword(book);
            int i = bkTypebox.SelectedIndex;
            bool define_type = i > 0;
            BookType bookType = i > 1 ? (BookType)(i - 1) : 0;
            foreach (BookMaster b in bklist)
            {
                if(!(define_type && b.Info.Type != bookType))
                {
                    Add(b.Info);
                }
            }
            //table.AcceptChanges();
        }

        private void bkTypebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].IsNewRow) return;
            DialogResult dr = MessageBox.Show("确定要借阅这本书吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string isbn = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Main.user.borrowFrom(FileDate.SearchByISBN(isbn)[0]);
            }
            
        }
    }
}
