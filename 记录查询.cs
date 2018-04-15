using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Lib_Mana_Sys
{
    public partial class RecordSearch : Form
    {
        private DataTable table;
        private List<Record> reclist;
        private List<Record> RecordWithinSpan(int span)
        {
            List<Record> reclist = new List<Record>();
            int len = (int)FileDate.CountOf<Record>();
            int size = Marshal.SizeOf(typeof(Record));
            Record rec = new Record();
            for(int i = 1; i <= len ; i++)
            {
                rec = FileDate.ReadOne<Record>(len - i);
                if(rec.spanDaysToPresent() <= span)
                {
                    reclist.Add(rec);
                }
                else
                {
                    break;
                }
            }
            return reclist;
        }
        private void Add(Record rec)
        {
            string state = "";
            if (rec.Type == OptType.借阅)
            {
                state = rec.Unmatch ? "尚未归还" : "已经归还";
            }else if (rec.Type == OptType.冻结)
            {
                state = rec.Unmatch ? "尚未解冻" : "已经解冻";
            }else if (rec.Type == OptType.预约)
            {
                if (rec.Unmatch)
                {
                    state = rec.Dur > -1 ? "预约已生效" : "预约未开始";
                }
                else
                {
                    state = rec.Dur > -1 ? "预约成功" : "预约人未完成预约";
                }
            }
            table.Rows.Add(rec.Type, rec.Optor, rec.datetime, state, rec.Dur == -1 ? "..." : rec.Dur.ToString());
        }

        public RecordSearch()
        {
            InitializeComponent();
            table = new DataTable("Table_Record");
            table.Columns.Add("记录类型");
            table.Columns.Add("操作对象");
            table.Columns.Add("初始时间");
            table.Columns.Add("记录状态");
            table.Columns.Add("持续天数");
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewRec_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            int span = Int32.Parse(DurDaystxt.Text);
            if (span > ConstVar.MAX_RECORD_SEARCH_DAY)
            {
                MessageBox.Show("最多查询" + ConstVar.MAX_RECORD_SEARCH_DAY.ToString() + "天之内的记录", "提示", MessageBoxButtons.OK);
                return;
            }
            table.Clear();
            reclist = new List<Record>(RecordWithinSpan(span));
            foreach(Record rec in reclist)
            {
                if (rec.Unmatch)
                {
                    if (!HistoryRec.Checked) Add(rec);
                }
                else
                {
                    if (!NewRec.Checked) Add(rec);
                }
            }
        }

        private void DurDaystxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b')
            {
                if (c < '0' || c > '9')
                {
                    e.Handled = true;
                }else if (c == '0' && DurDaystxt.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
