namespace Lib_Mana_Sys
{
    partial class BookAlter
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
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.showInfotxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.alteredInfotxt = new System.Windows.Forms.TextBox();
            this.nameAlter = new System.Windows.Forms.RadioButton();
            this.pressAlter = new System.Windows.Forms.RadioButton();
            this.authAlter = new System.Windows.Forms.RadioButton();
            this.isbnAlter = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.tipslb = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "书籍ISBN：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // isbntxt
            // 
            this.isbntxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbntxt.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isbntxt.Location = new System.Drawing.Point(16, 86);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(184, 26);
            this.isbntxt.TabIndex = 1;
            this.isbntxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isbntxt_KeyPress);
            // 
            // showInfotxt
            // 
            this.showInfotxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showInfotxt.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showInfotxt.ForeColor = System.Drawing.SystemColors.Info;
            this.showInfotxt.Location = new System.Drawing.Point(256, 12);
            this.showInfotxt.Multiline = true;
            this.showInfotxt.Name = "showInfotxt";
            this.showInfotxt.ReadOnly = true;
            this.showInfotxt.Size = new System.Drawing.Size(236, 211);
            this.showInfotxt.TabIndex = 2;
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchbtn.Location = new System.Drawing.Point(125, 39);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 31);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "查询";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // alteredInfotxt
            // 
            this.alteredInfotxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alteredInfotxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alteredInfotxt.Location = new System.Drawing.Point(124, 243);
            this.alteredInfotxt.Name = "alteredInfotxt";
            this.alteredInfotxt.Size = new System.Drawing.Size(177, 26);
            this.alteredInfotxt.TabIndex = 4;
            this.alteredInfotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alteredInfotxt_KeyPress);
            // 
            // nameAlter
            // 
            this.nameAlter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameAlter.AutoSize = true;
            this.nameAlter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameAlter.Location = new System.Drawing.Point(16, 126);
            this.nameAlter.Name = "nameAlter";
            this.nameAlter.Size = new System.Drawing.Size(92, 25);
            this.nameAlter.TabIndex = 5;
            this.nameAlter.TabStop = true;
            this.nameAlter.Text = "名称修改";
            this.nameAlter.UseVisualStyleBackColor = true;
            this.nameAlter.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.nameAlter.CursorChanged += new System.EventHandler(this.nameAlter_CursorChanged);
            // 
            // pressAlter
            // 
            this.pressAlter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pressAlter.AutoSize = true;
            this.pressAlter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pressAlter.Location = new System.Drawing.Point(16, 176);
            this.pressAlter.Name = "pressAlter";
            this.pressAlter.Size = new System.Drawing.Size(108, 25);
            this.pressAlter.TabIndex = 6;
            this.pressAlter.TabStop = true;
            this.pressAlter.Text = "出版社修改";
            this.pressAlter.UseVisualStyleBackColor = true;
            // 
            // authAlter
            // 
            this.authAlter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authAlter.AutoSize = true;
            this.authAlter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authAlter.Location = new System.Drawing.Point(136, 126);
            this.authAlter.Name = "authAlter";
            this.authAlter.Size = new System.Drawing.Size(92, 25);
            this.authAlter.TabIndex = 7;
            this.authAlter.TabStop = true;
            this.authAlter.Text = "作者修改";
            this.authAlter.UseVisualStyleBackColor = true;
            // 
            // isbnAlter
            // 
            this.isbnAlter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbnAlter.AutoSize = true;
            this.isbnAlter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isbnAlter.Location = new System.Drawing.Point(136, 176);
            this.isbnAlter.Name = "isbnAlter";
            this.isbnAlter.Size = new System.Drawing.Size(97, 25);
            this.isbnAlter.TabIndex = 8;
            this.isbnAlter.TabStop = true;
            this.isbnAlter.Text = "ISBN修改";
            this.isbnAlter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "修改后信息：";
            // 
            // confirmbtn
            // 
            this.confirmbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmbtn.Location = new System.Drawing.Point(325, 241);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(73, 32);
            this.confirmbtn.TabIndex = 10;
            this.confirmbtn.Text = "确认修改";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // tipslb
            // 
            this.tipslb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipslb.AutoSize = true;
            this.tipslb.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipslb.Location = new System.Drawing.Point(172, 284);
            this.tipslb.Name = "tipslb";
            this.tipslb.Size = new System.Drawing.Size(96, 16);
            this.tipslb.TabIndex = 11;
            this.tipslb.Text = "请首先查询~";
            this.tipslb.Click += new System.EventHandler(this.label3_Click);
            // 
            // delbtn
            // 
            this.delbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delbtn.Location = new System.Drawing.Point(417, 241);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 32);
            this.delbtn.TabIndex = 12;
            this.delbtn.Text = "删除书籍";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // BookAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 321);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.tipslb);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isbnAlter);
            this.Controls.Add(this.authAlter);
            this.Controls.Add(this.pressAlter);
            this.Controls.Add(this.nameAlter);
            this.Controls.Add(this.alteredInfotxt);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.showInfotxt);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BookAlter";
            this.Text = "图书修改界面";
            this.Load += new System.EventHandler(this.BookAlter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.TextBox showInfotxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox alteredInfotxt;
        private System.Windows.Forms.RadioButton nameAlter;
        private System.Windows.Forms.RadioButton pressAlter;
        private System.Windows.Forms.RadioButton authAlter;
        private System.Windows.Forms.RadioButton isbnAlter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Label tipslb;
        private System.Windows.Forms.Button delbtn;
    }
}