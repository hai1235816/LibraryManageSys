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
            if (keywordtxt.Text == "") return;
            table.Clear();
            List<Book> bklist;
            if (bkname_rbtn.Checked)
            {
                bklist = new List<Book>(FileDate.SearchByName(keywordtxt.Text));
            } else if (auth_rbtn.Checked)
            {
                bklist = new List<Book>(FileDate.SearchByAuthor(keywordtxt.Text));
            } else if (isbn_rbtn.Checked)
            {
                bklist = new List<Book>(FileDate.SearchByISBN(keywordtxt.Text));
            } else if (press_rbtn.Checked)
            {
                bklist = new List<Book>(FileDate.SearchByPress(keywordtxt.Text));
            }
            else
            {
                bklist = new List<Book>();
            }
            int i = bkTypebox.SelectedIndex;
            bool define_type = i > 0;
            BookType bookType = i > 1 ? (BookType)(i - 1) : 0;
            foreach (Book b in bklist)
            {
                if(!(define_type && b.Type != bookType))
                {
                    Add(b);
                }
            }
            table.AcceptChanges();
        }

        private void bkTypebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
