namespace Lib_Mana_Sys
{
    partial class RecordSearch
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
            this.DurDaystxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.AllRec = new System.Windows.Forms.RadioButton();
            this.HistoryRec = new System.Windows.Forms.RadioButton();
            this.NewRec = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询天数：";
            // 
            // DurDaystxt
            // 
            this.DurDaystxt.Location = new System.Drawing.Point(97, 21);
            this.DurDaystxt.Name = "DurDaystxt";
            this.DurDaystxt.Size = new System.Drawing.Size(75, 21);
            this.DurDaystxt.TabIndex = 1;
            this.DurDaystxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.DurDaystxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DurDaystxt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(443, 221);
            this.dataGridView1.TabIndex = 2;
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchbtn.Location = new System.Drawing.Point(33, 203);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 27);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "搜索";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // AllRec
            // 
            this.AllRec.AutoSize = true;
            this.AllRec.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllRec.Location = new System.Drawing.Point(33, 62);
            this.AllRec.Name = "AllRec";
            this.AllRec.Size = new System.Drawing.Size(111, 24);
            this.AllRec.TabIndex = 4;
            this.AllRec.TabStop = true;
            this.AllRec.Text = "显示所有记录";
            this.AllRec.UseVisualStyleBackColor = true;
            // 
            // HistoryRec
            // 
            this.HistoryRec.AutoSize = true;
            this.HistoryRec.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HistoryRec.Location = new System.Drawing.Point(33, 104);
            this.HistoryRec.Name = "HistoryRec";
            this.HistoryRec.Size = new System.Drawing.Size(111, 24);
            this.HistoryRec.TabIndex = 5;
            this.HistoryRec.TabStop = true;
            this.HistoryRec.Text = "只看历史记录";
            this.HistoryRec.UseVisualStyleBackColor = true;
            // 
            // NewRec
            // 
            this.NewRec.AutoSize = true;
            this.NewRec.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewRec.Location = new System.Drawing.Point(33, 146);
            this.NewRec.Name = "NewRec";
            this.NewRec.Size = new System.Drawing.Size(111, 24);
            this.NewRec.TabIndex = 6;
            this.NewRec.TabStop = true;
            this.NewRec.Text = "只看新的记录";
            this.NewRec.UseVisualStyleBackColor = true;
            this.NewRec.CheckedChanged += new System.EventHandler(this.NewRec_CheckedChanged);
            // 
            // RecordSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 271);
            this.Controls.Add(this.NewRec);
            this.Controls.Add(this.HistoryRec);
            this.Controls.Add(this.AllRec);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DurDaystxt);
            this.Controls.Add(this.label1);
            this.Name = "RecordSearch";
            this.Text = "记录查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DurDaystxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.RadioButton AllRec;
        private System.Windows.Forms.RadioButton HistoryRec;
        private System.Windows.Forms.RadioButton NewRec;
    }
}