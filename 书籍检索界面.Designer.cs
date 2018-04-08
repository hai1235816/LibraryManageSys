namespace Lib_Mana_Sys
{
    partial class SearchBooks
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
            this.bkname_rbtn = new System.Windows.Forms.RadioButton();
            this.auth_rbtn = new System.Windows.Forms.RadioButton();
            this.keywordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.bkTypebox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isbn_rbtn = new System.Windows.Forms.RadioButton();
            this.press_rbtn = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bkname_rbtn
            // 
            this.bkname_rbtn.AutoSize = true;
            this.bkname_rbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bkname_rbtn.Location = new System.Drawing.Point(19, 86);
            this.bkname_rbtn.Name = "bkname_rbtn";
            this.bkname_rbtn.Size = new System.Drawing.Size(83, 24);
            this.bkname_rbtn.TabIndex = 0;
            this.bkname_rbtn.TabStop = true;
            this.bkname_rbtn.Text = "书名检索";
            this.bkname_rbtn.UseVisualStyleBackColor = true;
            // 
            // auth_rbtn
            // 
            this.auth_rbtn.AutoSize = true;
            this.auth_rbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.auth_rbtn.Location = new System.Drawing.Point(19, 133);
            this.auth_rbtn.Name = "auth_rbtn";
            this.auth_rbtn.Size = new System.Drawing.Size(83, 24);
            this.auth_rbtn.TabIndex = 1;
            this.auth_rbtn.TabStop = true;
            this.auth_rbtn.Text = "作者检索";
            this.auth_rbtn.UseVisualStyleBackColor = true;
            // 
            // keywordtxt
            // 
            this.keywordtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keywordtxt.Location = new System.Drawing.Point(462, 29);
            this.keywordtxt.Name = "keywordtxt";
            this.keywordtxt.Size = new System.Drawing.Size(174, 26);
            this.keywordtxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(351, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入关键字：";
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchbtn.Location = new System.Drawing.Point(671, 26);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 32);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "检索";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.search_Click);
            // 
            // bkTypebox
            // 
            this.bkTypebox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bkTypebox.FormattingEnabled = true;
            this.bkTypebox.Items.AddRange(new object[] {
            "所有类型",
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
            this.bkTypebox.Location = new System.Drawing.Point(127, 30);
            this.bkTypebox.Name = "bkTypebox";
            this.bkTypebox.Size = new System.Drawing.Size(129, 28);
            this.bkTypebox.TabIndex = 12;
            this.bkTypebox.Text = "所有类型";
            this.bkTypebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bkTypebox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "检索类型：";
            // 
            // isbn_rbtn
            // 
            this.isbn_rbtn.AutoSize = true;
            this.isbn_rbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isbn_rbtn.Location = new System.Drawing.Point(19, 180);
            this.isbn_rbtn.Name = "isbn_rbtn";
            this.isbn_rbtn.Size = new System.Drawing.Size(87, 24);
            this.isbn_rbtn.TabIndex = 14;
            this.isbn_rbtn.TabStop = true;
            this.isbn_rbtn.Text = "ISBN检索";
            this.isbn_rbtn.UseVisualStyleBackColor = true;
            // 
            // press_rbtn
            // 
            this.press_rbtn.AutoSize = true;
            this.press_rbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.press_rbtn.Location = new System.Drawing.Point(19, 224);
            this.press_rbtn.Name = "press_rbtn";
            this.press_rbtn.Size = new System.Drawing.Size(97, 24);
            this.press_rbtn.TabIndex = 15;
            this.press_rbtn.TabStop = true;
            this.press_rbtn.Text = "出版社检索";
            this.press_rbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(186, 104);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(592, 262);
            this.dataGridView1.TabIndex = 16;
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 378);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.press_rbtn);
            this.Controls.Add(this.isbn_rbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bkTypebox);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keywordtxt);
            this.Controls.Add(this.auth_rbtn);
            this.Controls.Add(this.bkname_rbtn);
            this.Name = "SearchBooks";
            this.Text = "书籍检索界面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton bkname_rbtn;
        private System.Windows.Forms.RadioButton auth_rbtn;
        private System.Windows.Forms.TextBox keywordtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.ComboBox bkTypebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton isbn_rbtn;
        private System.Windows.Forms.RadioButton press_rbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}