
namespace Client
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserName.Location = new System.Drawing.Point(13, 9);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 19);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "UserName:";
            // 
            // txtServiceFee
            // 
            this.txtServiceFee.Location = new System.Drawing.Point(188, 180);
            this.txtServiceFee.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceFee.Name = "txtServiceFee";
            this.txtServiceFee.ReadOnly = true;
            this.txtServiceFee.Size = new System.Drawing.Size(141, 22);
            this.txtServiceFee.TabIndex = 9;
            // 
            // txtUseTimeFee
            // 
            this.txtUseTimeFee.Location = new System.Drawing.Point(188, 143);
            this.txtUseTimeFee.Margin = new System.Windows.Forms.Padding(4);
            this.txtUseTimeFee.Name = "txtUseTimeFee";
            this.txtUseTimeFee.ReadOnly = true;
            this.txtUseTimeFee.Size = new System.Drawing.Size(141, 22);
            this.txtUseTimeFee.TabIndex = 8;
            // 
            // txtRemainTime
            // 
            this.txtRemainTime.Location = new System.Drawing.Point(188, 107);
            this.txtRemainTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemainTime.Name = "txtRemainTime";
            this.txtRemainTime.ReadOnly = true;
            this.txtRemainTime.Size = new System.Drawing.Size(141, 22);
            this.txtRemainTime.TabIndex = 7;
            // 
            // txtUseTime
            // 
            this.txtUseTime.Location = new System.Drawing.Point(188, 71);
            this.txtUseTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtUseTime.Name = "txtUseTime";
            this.txtUseTime.ReadOnly = true;
            this.txtUseTime.Size = new System.Drawing.Size(141, 22);
            this.txtUseTime.TabIndex = 6;
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(188, 32);
            this.txtTotalTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(141, 22);
            this.txtTotalTime.TabIndex = 5;
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblServiceFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceFee.Location = new System.Drawing.Point(40, 180);
            this.lblServiceFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(127, 19);
            this.lblServiceFee.TabIndex = 4;
            this.lblServiceFee.Text = "Chi phí dịch vụ:";
            // 
            // lblUseTimeFee
            // 
            this.lblUseTimeFee.AutoSize = true;
            this.lblUseTimeFee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUseTimeFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUseTimeFee.Location = new System.Drawing.Point(31, 143);
            this.lblUseTimeFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUseTimeFee.Name = "lblUseTimeFee";
            this.lblUseTimeFee.Size = new System.Drawing.Size(134, 19);
            this.lblUseTimeFee.TabIndex = 3;
            this.lblUseTimeFee.Text = "Chi phí giờ chơi:";
            // 
            // lblRemainTime
            // 
            this.lblRemainTime.AutoSize = true;
            this.lblRemainTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRemainTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemainTime.Location = new System.Drawing.Point(25, 107);
            this.lblRemainTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemainTime.Name = "lblRemainTime";
            this.lblRemainTime.Size = new System.Drawing.Size(139, 19);
            this.lblRemainTime.TabIndex = 2;
            this.lblRemainTime.Text = "Thời gian còn lại:";
            // 
            // lblUseTime
            // 
            this.lblUseTime.AutoSize = true;
            this.lblUseTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUseTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUseTime.Location = new System.Drawing.Point(15, 71);
            this.lblUseTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUseTime.Name = "lblUseTime";
            this.lblUseTime.Size = new System.Drawing.Size(146, 19);
            this.lblUseTime.TabIndex = 1;
            this.lblUseTime.Text = "Thời gian sử dụng:";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalTime.Location = new System.Drawing.Point(41, 32);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(122, 19);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(339, 226);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 598);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

