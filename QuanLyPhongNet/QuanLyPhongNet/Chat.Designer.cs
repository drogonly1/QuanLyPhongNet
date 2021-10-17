namespace QuanLyPhongNet
{
    partial class Chat
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
            this.components = new System.ComponentModel.Container();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.button_send_cbat = new System.Windows.Forms.Button();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.Enabled = false;
            this.txtContent.Location = new System.Drawing.Point(11, 11);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(612, 351);
            this.txtContent.TabIndex = 5;
            // 
            // button_send_cbat
            // 
            this.button_send_cbat.Location = new System.Drawing.Point(629, 367);
            this.button_send_cbat.Name = "button_send_cbat";
            this.button_send_cbat.Size = new System.Drawing.Size(75, 23);
            this.button_send_cbat.TabIndex = 6;
            this.button_send_cbat.Text = "Chat";
            this.button_send_cbat.UseVisualStyleBackColor = true;
            this.button_send_cbat.Click += new System.EventHandler(this.button_send_cbat_Click);
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(12, 367);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(611, 20);
            this.textBox_Message.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerContent_Tick);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 403);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.button_send_cbat);
            this.Controls.Add(this.txtContent);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button button_send_cbat;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Timer timer1;
    }
}