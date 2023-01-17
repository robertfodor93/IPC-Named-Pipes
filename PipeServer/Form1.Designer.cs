namespace PipeServer
{
    partial class Form1
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
            this.tbPipeName = new System.Windows.Forms.TextBox();
            this.lblPipeName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblReceived = new System.Windows.Forms.Label();
            this.tbReceived = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPipeName
            // 
            this.tbPipeName.Location = new System.Drawing.Point(16, 45);
            this.tbPipeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPipeName.Name = "tbPipeName";
            this.tbPipeName.Size = new System.Drawing.Size(288, 27);
            this.tbPipeName.TabIndex = 0;
            this.tbPipeName.Text = "\\\\.\\pipe\\myNamedPipe";
            // 
            // lblPipeName
            // 
            this.lblPipeName.AutoSize = true;
            this.lblPipeName.Location = new System.Drawing.Point(16, 20);
            this.lblPipeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPipeName.Name = "lblPipeName";
            this.lblPipeName.Size = new System.Drawing.Size(85, 20);
            this.lblPipeName.TabIndex = 1;
            this.lblPipeName.Text = "Pipe Name:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(313, 42);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(16, 135);
            this.tbSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(396, 130);
            this.tbSend.TabIndex = 3;
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(16, 111);
            this.lblSend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(107, 20);
            this.lblSend.TabIndex = 4;
            this.lblSend.Text = "Send Message:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(313, 277);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 35);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Location = new System.Drawing.Point(16, 306);
            this.lblReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(140, 20);
            this.lblReceived.TabIndex = 7;
            this.lblReceived.Text = "Received Messages:";
            // 
            // tbReceived
            // 
            this.tbReceived.Location = new System.Drawing.Point(16, 331);
            this.tbReceived.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbReceived.Multiline = true;
            this.tbReceived.Name = "tbReceived";
            this.tbReceived.ReadOnly = true;
            this.tbReceived.Size = new System.Drawing.Size(396, 130);
            this.tbReceived.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 486);
            this.Controls.Add(this.lblReceived);
            this.Controls.Add(this.tbReceived);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPipeName);
            this.Controls.Add(this.tbPipeName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPipeName;
        private System.Windows.Forms.Label lblPipeName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.TextBox tbReceived;
    }
}