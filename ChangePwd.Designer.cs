namespace Lib_Mana_Sys
{
    partial class ChangePwd
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
            this.AccountIDtxt = new System.Windows.Forms.TextBox();
            this.OriPwdtxt = new System.Windows.Forms.TextBox();
            this.NewPwdtxt = new System.Windows.Forms.TextBox();
            this.RepeatPwdtxt = new System.Windows.Forms.TextBox();
            this.Confirmbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Tipslb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "原密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认密码：";
            // 
            // AccountIDtxt
            // 
            this.AccountIDtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountIDtxt.Location = new System.Drawing.Point(113, 30);
            this.AccountIDtxt.Name = "AccountIDtxt";
            this.AccountIDtxt.Size = new System.Drawing.Size(164, 26);
            this.AccountIDtxt.TabIndex = 4;
            this.AccountIDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountIDtxt_KeyPress);
            // 
            // OriPwdtxt
            // 
            this.OriPwdtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OriPwdtxt.Location = new System.Drawing.Point(113, 76);
            this.OriPwdtxt.Name = "OriPwdtxt";
            this.OriPwdtxt.PasswordChar = '*';
            this.OriPwdtxt.Size = new System.Drawing.Size(164, 26);
            this.OriPwdtxt.TabIndex = 5;
            this.OriPwdtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OriPwdtxt_KeyPress);
            // 
            // NewPwdtxt
            // 
            this.NewPwdtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPwdtxt.Location = new System.Drawing.Point(113, 120);
            this.NewPwdtxt.Name = "NewPwdtxt";
            this.NewPwdtxt.PasswordChar = '*';
            this.NewPwdtxt.Size = new System.Drawing.Size(164, 26);
            this.NewPwdtxt.TabIndex = 6;
            this.NewPwdtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewPwdtxt_KeyPress);
            // 
            // RepeatPwdtxt
            // 
            this.RepeatPwdtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RepeatPwdtxt.Location = new System.Drawing.Point(113, 163);
            this.RepeatPwdtxt.Name = "RepeatPwdtxt";
            this.RepeatPwdtxt.PasswordChar = '*';
            this.RepeatPwdtxt.Size = new System.Drawing.Size(164, 26);
            this.RepeatPwdtxt.TabIndex = 7;
            this.RepeatPwdtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepeatPwdtxt_KeyPress);
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirmbtn.Location = new System.Drawing.Point(39, 255);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.Size = new System.Drawing.Size(73, 28);
            this.Confirmbtn.TabIndex = 8;
            this.Confirmbtn.Text = "确认修改";
            this.Confirmbtn.UseVisualStyleBackColor = true;
            this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbtn.Location = new System.Drawing.Point(168, 255);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(76, 28);
            this.Cancelbtn.TabIndex = 9;
            this.Cancelbtn.Text = "取消";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Tipslb
            // 
            this.Tipslb.AutoSize = true;
            this.Tipslb.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tipslb.Location = new System.Drawing.Point(36, 216);
            this.Tipslb.Name = "Tipslb";
            this.Tipslb.Size = new System.Drawing.Size(216, 16);
            this.Tipslb.TabIndex = 10;
            this.Tipslb.Text = "建议新密码不要与原密码一致";
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 321);
            this.Controls.Add(this.Tipslb);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Confirmbtn);
            this.Controls.Add(this.RepeatPwdtxt);
            this.Controls.Add(this.NewPwdtxt);
            this.Controls.Add(this.OriPwdtxt);
            this.Controls.Add(this.AccountIDtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangePwd";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.ChangePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AccountIDtxt;
        private System.Windows.Forms.TextBox OriPwdtxt;
        private System.Windows.Forms.TextBox NewPwdtxt;
        private System.Windows.Forms.TextBox RepeatPwdtxt;
        private System.Windows.Forms.Button Confirmbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label Tipslb;
    }
}