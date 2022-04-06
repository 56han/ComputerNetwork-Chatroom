namespace _1
{
    partial class Form1
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
            this.connet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.receive = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connet
            // 
            this.connet.BackColor = System.Drawing.SystemColors.Control;
            this.connet.Location = new System.Drawing.Point(288, 138);
            this.connet.Margin = new System.Windows.Forms.Padding(4);
            this.connet.Name = "connet";
            this.connet.Size = new System.Drawing.Size(150, 60);
            this.connet.TabIndex = 0;
            this.connet.Text = "server on";
            this.connet.UseVisualStyleBackColor = false;
            this.connet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "status";
            // 
            // receive
            // 
            this.receive.BackColor = System.Drawing.SystemColors.Control;
            this.receive.Location = new System.Drawing.Point(288, 305);
            this.receive.Name = "receive";
            this.receive.Size = new System.Drawing.Size(150, 61);
            this.receive.TabIndex = 2;
            this.receive.Text = "receive";
            this.receive.UseVisualStyleBackColor = false;
            this.receive.Click += new System.EventHandler(this.receive_Click);
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.SystemColors.Control;
            this.off.Location = new System.Drawing.Point(288, 392);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(150, 59);
            this.off.TabIndex = 3;
            this.off.Text = "server off";
            this.off.UseVisualStyleBackColor = false;
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.SystemColors.Control;
            this.accept.Location = new System.Drawing.Point(288, 220);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(150, 60);
            this.accept.TabIndex = 4;
            this.accept.Text = "accept";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(801, 641);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.off);
            this.Controls.Add(this.receive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connet);
            this.Font = new System.Drawing.Font("標楷體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button receive;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button accept;
    }
}

