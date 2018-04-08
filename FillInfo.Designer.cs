namespace Lib_Mana_Sys
{
    partial class FillInfo
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
            this.tipslb = new System.Windows.Forms.Label();
            this.AccountIDtxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkPwdtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.stu = new System.Windows.Forms.RadioButton();
            this.worker = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.quit退出 = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号      ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码      ：";
            // 
            // tipslb
            // 
            this.tipslb.AutoSize = true;
            this.tipslb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipslb.Location = new System.Drawing.Point(13, 184);
            this.tipslb.Name = "tipslb";
            this.tipslb.Size = new System.Drawing.Size(176, 21);
            this.tipslb.TabIndex = 2;
            this.tipslb.Text = "-----选择用户身份-----";
            // 
            // AccountIDtxt
            // 
            this.AccountIDtxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountIDtxt.Location = new System.Drawing.Point(102, 28);
            this.AccountIDtxt.Name = "AccountIDtxt";
            this.AccountIDtxt.Size = new System.Drawing.Size(163, 23);
            this.AccountIDtxt.TabIndex = 1;
            this.AccountIDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountIDtxt_KeyPress);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Passwordtxt.Location = new System.Drawing.Point(102, 102);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(163, 23);
            this.Passwordtxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(51, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "完成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "用户名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "确认密码：";
            // 
            // checkPwdtxt
            // 
            this.checkPwdtxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkPwdtxt.Location = new System.Drawing.Point(102, 143);
            this.checkPwdtxt.Name = "checkPwdtxt";
            this.checkPwdtxt.PasswordChar = '*';
            this.checkPwdtxt.Size = new System.Drawing.Size(163, 23);
            this.checkPwdtxt.TabIndex = 4;
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nametxt.Location = new System.Drawing.Point(102, 67);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(163, 23);
            this.nametxt.TabIndex = 2;
            // 
            // stu
            // 
            this.stu.AutoSize = true;
            this.stu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stu.Location = new System.Drawing.Point(17, 225);
            this.stu.Name = "stu";
            this.stu.Size = new System.Drawing.Size(92, 25);
            this.stu.TabIndex = 12;
            this.stu.TabStop = true;
            this.stu.Text = "学生用户";
            this.stu.UseVisualStyleBackColor = true;
            this.stu.CheckedChanged += new System.EventHandler(this.stu_CheckedChanged);
            // 
            // worker
            // 
            this.worker.AutoSize = true;
            this.worker.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.worker.Location = new System.Drawing.Point(115, 225);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(92, 25);
            this.worker.TabIndex = 13;
            this.worker.TabStop = true;
            this.worker.Text = "职工人员";
            this.worker.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.admin.Location = new System.Drawing.Point(213, 225);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(76, 25);
            this.admin.TabIndex = 14;
            this.admin.TabStop = true;
            this.admin.Text = "管理员";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // quit退出
            // 
            this.quit退出.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quit退出.Location = new System.Drawing.Point(142, 282);
            this.quit退出.Name = "quit退出";
            this.quit退出.Size = new System.Drawing.Size(58, 30);
            this.quit退出.TabIndex = 6;
            this.quit退出.Text = "退出";
            this.quit退出.UseVisualStyleBackColor = true;
            this.quit退出.Click += new System.EventHandler(this.quit退出_Click);
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "女",
            "男"});
            this.gender.Location = new System.Drawing.Point(213, 188);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(76, 25);
            this.gender.TabIndex = 15;
            this.gender.Text = "男";
            this.gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gender_KeyPress);
            // 
            // FillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 337);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.quit退出);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.worker);
            this.Controls.Add(this.stu);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.checkPwdtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.AccountIDtxt);
            this.Controls.Add(this.tipslb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FillInfo";
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tipslb;
        private System.Windows.Forms.TextBox AccountIDtxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox checkPwdtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.RadioButton stu;
        private System.Windows.Forms.RadioButton worker;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.Button quit退出;
        private System.Windows.Forms.ComboBox gender;
    }
}