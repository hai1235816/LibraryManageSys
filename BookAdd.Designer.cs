namespace Lib_Mana_Sys
{
    partial class BookAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bknametxt = new System.Windows.Forms.TextBox();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.NUMtxt = new System.Windows.Forms.TextBox();
            this.bkTypebox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.presstxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "书籍名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "出版社：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "作者：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN：";
            // 
            // bknametxt
            // 
            this.bknametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bknametxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bknametxt.Location = new System.Drawing.Point(107, 27);
            this.bknametxt.Name = "bknametxt";
            this.bknametxt.Size = new System.Drawing.Size(213, 26);
            this.bknametxt.TabIndex = 4;
            this.bknametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.bknametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bknametxt_KeyPress);
            // 
            // isbntxt
            // 
            this.isbntxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbntxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isbntxt.Location = new System.Drawing.Point(107, 163);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(213, 26);
            this.isbntxt.TabIndex = 7;
            this.isbntxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isbntxt_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "书籍数量：";
            // 
            // confirm
            // 
            this.confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Location = new System.Drawing.Point(245, 291);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 31);
            this.confirm.TabIndex = 9;
            this.confirm.Text = "确认添加";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // NUMtxt
            // 
            this.NUMtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NUMtxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NUMtxt.Location = new System.Drawing.Point(107, 250);
            this.NUMtxt.Name = "NUMtxt";
            this.NUMtxt.Size = new System.Drawing.Size(51, 29);
            this.NUMtxt.TabIndex = 10;
            this.NUMtxt.Text = "1";
            this.NUMtxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.NUMtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUMtxt_KeyPress);
            // 
            // bkTypebox
            // 
            this.bkTypebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bkTypebox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bkTypebox.FormattingEnabled = true;
            this.bkTypebox.Items.AddRange(new object[] {
            "政治理论与政治主义",
            "哲学宗教",
            "社会科学总论",
            "政治法律",
            "军事",
            "经济",
            "文化科学教育体育",
            "语言文字",
            "文学",
            "艺术",
            "历史地理",
            "自然科学总论",
            "数理科学与化学",
            "天文学与地球科学",
            "生物科学",
            "医药卫生",
            "农业科学",
            "工业技术",
            "交通运输",
            "航空航天",
            "环境科学与安全科学",
            "综合性图书"});
            this.bkTypebox.Location = new System.Drawing.Point(107, 210);
            this.bkTypebox.Name = "bkTypebox";
            this.bkTypebox.Size = new System.Drawing.Size(129, 28);
            this.bkTypebox.TabIndex = 11;
            this.bkTypebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bkTypebox_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "书籍种类：";
            // 
            // authortxt
            // 
            this.authortxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authortxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authortxt.Location = new System.Drawing.Point(107, 119);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(213, 26);
            this.authortxt.TabIndex = 13;
            this.authortxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authortxt_KeyPress);
            // 
            // presstxt
            // 
            this.presstxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presstxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.presstxt.Location = new System.Drawing.Point(107, 76);
            this.presstxt.Name = "presstxt";
            this.presstxt.Size = new System.Drawing.Size(213, 26);
            this.presstxt.TabIndex = 14;
            this.presstxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.presstxt_KeyPress);
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 334);
            this.Controls.Add(this.presstxt);
            this.Controls.Add(this.authortxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bkTypebox);
            this.Controls.Add(this.NUMtxt);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.bknametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookAdd";
            this.Text = "新添图书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bknametxt;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox NUMtxt;
        private System.Windows.Forms.ComboBox bkTypebox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.TextBox presstxt;
    }
}