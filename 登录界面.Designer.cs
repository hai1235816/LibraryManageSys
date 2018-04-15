namespace Lib_Mana_Sys
{
    partial class Login
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
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.PWDtxt = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.Worker = new System.Windows.Forms.RadioButton();
            this.Stu = new System.Windows.Forms.RadioButton();
            this.Vis = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号|学工号：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IDtxt
            // 
            this.IDtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDtxt.Location = new System.Drawing.Point(121, 33);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(157, 26);
            this.IDtxt.TabIndex = 2;
            this.IDtxt.Text = "16020031111";
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            this.IDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDtxt_KeyPress);
            // 
            // PWDtxt
            // 
            this.PWDtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PWDtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PWDtxt.Location = new System.Drawing.Point(121, 77);
            this.PWDtxt.Name = "PWDtxt";
            this.PWDtxt.PasswordChar = '*';
            this.PWDtxt.Size = new System.Drawing.Size(157, 26);
            this.PWDtxt.TabIndex = 3;
            this.PWDtxt.Text = "123456";
            this.PWDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWDtxt_KeyPress);
            // 
            // Admin
            // 
            this.Admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Admin.Location = new System.Drawing.Point(43, 145);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(74, 20);
            this.Admin.TabIndex = 4;
            this.Admin.TabStop = true;
            this.Admin.Text = "管理员";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Worker
            // 
            this.Worker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Worker.AutoSize = true;
            this.Worker.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Worker.Location = new System.Drawing.Point(43, 189);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(74, 20);
            this.Worker.TabIndex = 5;
            this.Worker.TabStop = true;
            this.Worker.Text = "教职工";
            this.Worker.UseVisualStyleBackColor = true;
            // 
            // Stu
            // 
            this.Stu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stu.AutoSize = true;
            this.Stu.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stu.Location = new System.Drawing.Point(149, 145);
            this.Stu.Name = "Stu";
            this.Stu.Size = new System.Drawing.Size(58, 20);
            this.Stu.TabIndex = 6;
            this.Stu.TabStop = true;
            this.Stu.Text = "学生";
            this.Stu.UseVisualStyleBackColor = true;
            // 
            // Vis
            // 
            this.Vis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vis.AutoSize = true;
            this.Vis.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Vis.Location = new System.Drawing.Point(149, 189);
            this.Vis.Name = "Vis";
            this.Vis.Size = new System.Drawing.Size(90, 20);
            this.Vis.TabIndex = 7;
            this.Vis.TabStop = true;
            this.Vis.Text = "游客登录";
            this.Vis.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirm.Location = new System.Drawing.Point(77, 256);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(92, 32);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "登录";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 331);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.Vis);
            this.Controls.Add(this.Stu);
            this.Controls.Add(this.Worker);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.PWDtxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox PWDtxt;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.RadioButton Worker;
        private System.Windows.Forms.RadioButton Stu;
        private System.Windows.Forms.RadioButton Vis;
        private System.Windows.Forms.Button confirm;
    }
}