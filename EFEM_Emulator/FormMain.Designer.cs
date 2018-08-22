namespace EFEM_Emulator
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectStatus_lb = new System.Windows.Forms.Label();
            this.Log_rt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EVTSend_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectStatus_lb
            // 
            this.ConnectStatus_lb.AutoSize = true;
            this.ConnectStatus_lb.BackColor = System.Drawing.Color.Red;
            this.ConnectStatus_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectStatus_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectStatus_lb.Location = new System.Drawing.Point(6, 18);
            this.ConnectStatus_lb.MinimumSize = new System.Drawing.Size(120, 9);
            this.ConnectStatus_lb.Name = "ConnectStatus_lb";
            this.ConnectStatus_lb.Size = new System.Drawing.Size(120, 14);
            this.ConnectStatus_lb.TabIndex = 1;
            // 
            // Log_rt
            // 
            this.Log_rt.Location = new System.Drawing.Point(12, 59);
            this.Log_rt.Name = "Log_rt";
            this.Log_rt.Size = new System.Drawing.Size(532, 667);
            this.Log_rt.TabIndex = 2;
            this.Log_rt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectStatus_lb);
            this.groupBox1.Location = new System.Drawing.Point(1004, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 41);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "上位系統連線";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MAPDT",
            "TRANSREQ ",
            "SIGSTAT"});
            this.comboBox1.Location = new System.Drawing.Point(767, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // EVTSend_btn
            // 
            this.EVTSend_btn.Location = new System.Drawing.Point(894, 237);
            this.EVTSend_btn.Name = "EVTSend_btn";
            this.EVTSend_btn.Size = new System.Drawing.Size(75, 23);
            this.EVTSend_btn.TabIndex = 5;
            this.EVTSend_btn.Text = "Send";
            this.EVTSend_btn.UseVisualStyleBackColor = true;
            this.EVTSend_btn.Click += new System.EventHandler(this.EVTSend_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "EVT";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 738);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EVTSend_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Log_rt);
            this.Name = "FormMain";
            this.Text = "EFEM_Emulator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ConnectStatus_lb;
        private System.Windows.Forms.RichTextBox Log_rt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button EVTSend_btn;
        private System.Windows.Forms.Label label1;
    }
}

