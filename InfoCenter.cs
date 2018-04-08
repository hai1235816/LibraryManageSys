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
    public partial class InfoCenter : Form
    {
        private Charge charge;
        private void update()
        {
            Statelb.Text = Main.user.Valid ? "正常" : "被冻结";
            bor_numlb.Text = Main.user.Borrownum.ToString();
            Balancelb.Text = Main.user.Balance.ToString();
        }
        public InfoCenter()
        {
            InitializeComponent();
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
    }
}
