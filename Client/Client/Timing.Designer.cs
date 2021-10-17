
namespace Client
{
    partial class Timing
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtServiceFee = new System.Windows.Forms.TextBox();
            this.txtUseTimeFee = new System.Windows.Forms.TextBox();
            this.txtRemainTime = new System.Windows.Forms.TextBox();
            this.txtUseTime = new System.Windows.Forms.TextBox();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.lblServiceFee = new System.Windows.Forms.Label();
            this.lblUseTimeFee = new System.Windows.Forms.Label();
            this.lblRemainTime = new System.Windows.Forms.Label();
            this.lblUseTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerProgram = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Chat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserName.Location = new System.Drawing.Point(10, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 15);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "UserName:";
            // 
            // txtServiceFee
            // 
            this.txtServiceFee.Location = new System.Drawing.Point(141, 146);
            this.txtServiceFee.Name = "txtServiceFee";
            this.txtServiceFee.ReadOnly = true;
            this.txtServiceFee.Size = new System.Drawing.Size(107, 20);
            this.txtServiceFee.TabIndex = 9;
            // 
            // txtUseTimeFee
            // 
            this.txtUseTimeFee.Location = new System.Drawing.Point(141, 116);
            this.txtUseTimeFee.Name = "txtUseTimeFee";
            this.txtUseTimeFee.ReadOnly = true;
            this.txtUseTimeFee.Size = new System.Drawing.Size(107, 20);
            this.txtUseTimeFee.TabIndex = 8;
            // 
            // txtRemainTime
            // 
            this.txtRemainTime.Location = new System.Drawing.Point(141, 87);
            this.txtRemainTime.Name = "txtRemainTime";
            this.txtRemainTime.ReadOnly = true;
            this.txtRemainTime.Size = new System.Drawing.Size(107, 20);
            this.txtRemainTime.TabIndex = 7;
            // 
            // txtUseTime
            // 
            this.txtUseTime.Location = new System.Drawing.Point(141, 58);
            this.txtUseTime.Name = "txtUseTime";
            this.txtUseTime.ReadOnly = true;
            this.txtUseTime.Size = new System.Drawing.Size(107, 20);
            this.txtUseTime.TabIndex = 6;
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(141, 26);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(107, 20);
            this.txtTotalTime.TabIndex = 5;
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblServiceFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceFee.Location = new System.Drawing.Point(30, 146);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(92, 15);
            this.lblServiceFee.TabIndex = 4;
            this.lblServiceFee.Text = "Chi phí dịch vụ:";
            // 
            // lblUseTimeFee
            // 
            this.lblUseTimeFee.AutoSize = true;
            this.lblUseTimeFee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUseTimeFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUseTimeFee.Location = new System.Drawing.Point(23, 116);
            this.lblUseTimeFee.Name = "lblUseTimeFee";
            this.lblUseTimeFee.Size = new System.Drawing.Size(99, 15);
            this.lblUseTimeFee.TabIndex = 3;
            this.lblUseTimeFee.Text = "Chi phí giờ chơi:";
            // 
            // lblRemainTime
            // 
            this.lblRemainTime.AutoSize = true;
            this.lblRemainTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRemainTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemainTime.Location = new System.Drawing.Point(19, 87);
            this.lblRemainTime.Name = "lblRemainTime";
            this.lblRemainTime.Size = new System.Drawing.Size(103, 15);
            this.lblRemainTime.TabIndex = 2;
            this.lblRemainTime.Text = "Thời gian còn lại:";
            // 
            // lblUseTime
            // 
            this.lblUseTime.AutoSize = true;
            this.lblUseTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUseTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUseTime.Location = new System.Drawing.Point(11, 58);
            this.lblUseTime.Name = "lblUseTime";
            this.lblUseTime.Size = new System.Drawing.Size(111, 15);
            this.lblUseTime.TabIndex = 1;
            this.lblUseTime.Text = "Thời gian sử dụng:";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalTime.Location = new System.Drawing.Point(31, 26);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(91, 15);
            this.lblTotalTime.TabIndex = 0;
            this.lblTotalTime.Text = "Tổng thời gian:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServiceFee);
            this.groupBox1.Controls.Add(this.txtUseTimeFee);
            this.groupBox1.Controls.Add(this.txtRemainTime);
            this.groupBox1.Controls.Add(this.txtUseTime);
            this.groupBox1.Controls.Add(this.txtTotalTime);
            this.groupBox1.Controls.Add(this.lblServiceFee);
            this.groupBox1.Controls.Add(this.lblUseTimeFee);
            this.groupBox1.Controls.Add(this.lblRemainTime);
            this.groupBox1.Controls.Add(this.lblUseTime);
            this.groupBox1.Controls.Add(this.lblTotalTime);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 184);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // timerProgram
            // 
            this.timerProgram.Tick += new System.EventHandler(this.timerProgram_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gửi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(2, 206);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(252, 54);
            this.txtMessage.TabIndex = 13;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.Location = new System.Drawing.Point(2, 2);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(252, 207);
            this.txtContent.TabIndex = 12;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Location = new System.Drawing.Point(12, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 333);
            this.panel1.TabIndex = 14;
            // 
            // button_Chat
            // 
            this.button_Chat.Location = new System.Drawing.Point(10, 197);
            this.button_Chat.Name = "button_Chat";
            this.button_Chat.Size = new System.Drawing.Size(75, 49);
            this.button_Chat.TabIndex = 14;
            this.button_Chat.Text = "Nhắn tin";
            this.button_Chat.UseVisualStyleBackColor = true;
            this.button_Chat.Click += new System.EventHandler(this.button2_Click);
            // 
            // Timing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 620);
            this.Controls.Add(this.button_Chat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Timing";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Timing_FormClosing);
            this.Load += new System.EventHandler(this.Timing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtServiceFee;
        private System.Windows.Forms.TextBox txtUseTimeFee;
        private System.Windows.Forms.TextBox txtRemainTime;
        private System.Windows.Forms.TextBox txtUseTime;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.Label lblServiceFee;
        private System.Windows.Forms.Label lblUseTimeFee;
        private System.Windows.Forms.Label lblRemainTime;
        private System.Windows.Forms.Label lblUseTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerProgram;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Chat;
    }
}

