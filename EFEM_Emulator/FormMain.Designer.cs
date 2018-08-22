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
            this.Log_rt.Size = new System.Drawing.Size(1118, 667);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 738);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Log_rt);
            this.Name = "FormMain";
            this.Text = "EFEM_Emulator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ConnectStatus_lb;
        private System.Windows.Forms.RichTextBox Log_rt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

