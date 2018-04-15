namespace Lib_Mana_Sys
{
    partial class Unfreeze
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
            this.opt = new System.Windows.Forms.Button();
            this.quit退出 = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opt
            // 
            this.opt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt.Location = new System.Drawing.Point(114, 175);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(75, 27);
            this.opt.TabIndex = 13;
            this.opt.Text = "账号解冻";
            this.opt.UseVisualStyleBackColor = true;
            this.opt.Click += new System.EventHandler(this.opt_Click);
            // 
            // quit退出
            // 
            this.quit退出.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quit退出.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quit退出.Location = new System.Drawing.Point(62, 238);
            this.quit退出.Name = "quit退出";
            this.quit退出.Size = new System.Drawing.Size(75, 28);
            this.quit退出.TabIndex = 12;
            this.quit退出.Text = "退出";
            this.quit退出.UseVisualStyleBackColor = true;
            this.quit退出.Click += new System.EventHandler(this.quit退出_Click);
            // 
            // state
            // 
            this.state.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.state.Location = new System.Drawing.Point(111, 119);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(103, 16);
            this.state.TabIndex = 11;
            this.state.Text = "等待查询...";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "账号状态：";
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(19, 175);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(74, 27);
            this.search.TabIndex = 9;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // IDtxt
            // 
            this.IDtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDtxt.Location = new System.Drawing.Point(16, 61);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(200, 26);
            this.IDtxt.TabIndex = 8;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            this.IDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDtxt_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "请输入学号/工号：";
            // 
            // Unfreeze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 302);
            this.Controls.Add(this.opt);
            this.Controls.Add(this.quit退出);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label1);
            this.Name = "Unfreeze";
            this.Text = "Unfreeze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opt;
        private System.Windows.Forms.Button quit退出;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label label1;
    }
}