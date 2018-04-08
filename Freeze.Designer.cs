namespace Lib_Mana_Sys
{
    partial class Freeze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.quit退出 = new System.Windows.Forms.Button();
            this.opt = new System.Windows.Forms.Button();
            this.Days = new System.Windows.Forms.ComboBox();
            this.freezetiplb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入学号/工号：";
            // 
            // IDtxt
            // 
            this.IDtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDtxt.Location = new System.Drawing.Point(16, 66);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(200, 26);
            this.IDtxt.TabIndex = 1;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            this.IDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDtxt_KeyPress);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(16, 215);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(74, 27);
            this.search.TabIndex = 2;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "账号状态：";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.state.Location = new System.Drawing.Point(123, 123);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(103, 16);
            this.state.TabIndex = 4;
            this.state.Text = "等待查询...";
            // 
            // quit退出
            // 
            this.quit退出.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quit退出.Location = new System.Drawing.Point(82, 273);
            this.quit退出.Name = "quit退出";
            this.quit退出.Size = new System.Drawing.Size(75, 28);
            this.quit退出.TabIndex = 5;
            this.quit退出.Text = "退出";
            this.quit退出.UseVisualStyleBackColor = true;
            this.quit退出.Click += new System.EventHandler(this.quit退出_Click);
            // 
            // opt
            // 
            this.opt.Location = new System.Drawing.Point(132, 218);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(75, 23);
            this.opt.TabIndex = 6;
            this.opt.Text = "冻结账号";
            this.opt.UseVisualStyleBackColor = true;
            this.opt.Click += new System.EventHandler(this.opt_Click);
            // 
            // Days
            // 
            this.Days.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Days.FormattingEnabled = true;
            this.Days.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "30"});
            this.Days.Location = new System.Drawing.Point(158, 164);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(49, 29);
            this.Days.TabIndex = 7;
            this.Days.Text = "1";
            this.Days.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Days_KeyPress);
            // 
            // freezetiplb
            // 
            this.freezetiplb.AutoSize = true;
            this.freezetiplb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.freezetiplb.Location = new System.Drawing.Point(12, 167);
            this.freezetiplb.Name = "freezetiplb";
            this.freezetiplb.Size = new System.Drawing.Size(122, 21);
            this.freezetiplb.TabIndex = 8;
            this.freezetiplb.Text = "选择冻结天数：";
            // 
            // Freeze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 337);
            this.Controls.Add(this.freezetiplb);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.opt);
            this.Controls.Add(this.quit退出);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label1);
            this.Name = "Freeze";
            this.Text = "冻结账号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Button quit退出;
        private System.Windows.Forms.Button opt;
        private System.Windows.Forms.ComboBox Days;
        private System.Windows.Forms.Label freezetiplb;
    }
}