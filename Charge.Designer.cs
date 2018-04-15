namespace Lib_Mana_Sys
{
    partial class Charge
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
            this.tipslb = new System.Windows.Forms.Label();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入缴费金额：";
            // 
            // tipslb
            // 
            this.tipslb.AutoSize = true;
            this.tipslb.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipslb.Location = new System.Drawing.Point(14, 80);
            this.tipslb.Name = "tipslb";
            this.tipslb.Size = new System.Drawing.Size(127, 16);
            this.tipslb.TabIndex = 1;
            this.tipslb.Text = "输入值不能为空";
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(156, 29);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(100, 21);
            this.amounttxt.TabIndex = 2;
            this.amounttxt.TextChanged += new System.EventHandler(this.amounttxt_TextChanged);
            this.amounttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amounttxt_KeyPress);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmbtn.Location = new System.Drawing.Point(181, 73);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(75, 30);
            this.confirmbtn.TabIndex = 3;
            this.confirmbtn.Text = "确认缴费";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // Charge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 148);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.tipslb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Charge";
            this.Text = "Charge";
            this.Load += new System.EventHandler(this.Charge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tipslb;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.Button confirmbtn;
    }
}