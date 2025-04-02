namespace EsemkaVote.View
{
    partial class ReportForm
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
            this.VoteHeaderCombo = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.Label();
            this.EmployeePicture = new System.Windows.Forms.PictureBox();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VoteGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.EmployeeVoteLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalVoteLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FlowLayoutReason = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Vote Event";
            // 
            // VoteHeaderCombo
            // 
            this.VoteHeaderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoteHeaderCombo.FormattingEnabled = true;
            this.VoteHeaderCombo.Location = new System.Drawing.Point(27, 62);
            this.VoteHeaderCombo.Name = "VoteHeaderCombo";
            this.VoteHeaderCombo.Size = new System.Drawing.Size(228, 21);
            this.VoteHeaderCombo.TabIndex = 1;
            this.VoteHeaderCombo.SelectedIndexChanged += new System.EventHandler(this.VoteHeaderCombo_SelectedIndexChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(555, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 33);
            this.TitleLabel.TabIndex = 2;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionText.Location = new System.Drawing.Point(405, 79);
            this.DescriptionText.MinimumSize = new System.Drawing.Size(0, 15);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(590, 36);
            this.DescriptionText.TabIndex = 3;
            this.DescriptionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeePicture
            // 
            this.EmployeePicture.Location = new System.Drawing.Point(591, 160);
            this.EmployeePicture.Name = "EmployeePicture";
            this.EmployeePicture.Size = new System.Drawing.Size(218, 264);
            this.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePicture.TabIndex = 4;
            this.EmployeePicture.TabStop = false;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLabel.Location = new System.Drawing.Point(575, 456);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(251, 33);
            this.EmployeeNameLabel.TabIndex = 5;
            this.EmployeeNameLabel.Text = "Alexander Moore";
            this.EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(670, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "With";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentLabel.Location = new System.Drawing.Point(641, 550);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(119, 33);
            this.PercentLabel.TabIndex = 7;
            this.PercentLabel.Text = "62.46%";
            this.PercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "(";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VoteGridView
            // 
            this.VoteGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VoteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VoteGridView.Location = new System.Drawing.Point(33, 648);
            this.VoteGridView.Name = "VoteGridView";
            this.VoteGridView.Size = new System.Drawing.Size(1345, 174);
            this.VoteGridView.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 825);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reason";
            // 
            // EmployeeVoteLabel
            // 
            this.EmployeeVoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeVoteLabel.Location = new System.Drawing.Point(650, 586);
            this.EmployeeVoteLabel.Name = "EmployeeVoteLabel";
            this.EmployeeVoteLabel.Size = new System.Drawing.Size(49, 33);
            this.EmployeeVoteLabel.TabIndex = 11;
            this.EmployeeVoteLabel.Text = "31";
            this.EmployeeVoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "/";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalVoteLabel
            // 
            this.TotalVoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVoteLabel.Location = new System.Drawing.Point(703, 586);
            this.TotalVoteLabel.Name = "TotalVoteLabel";
            this.TotalVoteLabel.Size = new System.Drawing.Size(49, 33);
            this.TotalVoteLabel.TabIndex = 13;
            this.TotalVoteLabel.Text = "45";
            this.TotalVoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(744, 583);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = ")";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowLayoutReason
            // 
            this.FlowLayoutReason.AutoScroll = true;
            this.FlowLayoutReason.Location = new System.Drawing.Point(33, 854);
            this.FlowLayoutReason.Name = "FlowLayoutReason";
            this.FlowLayoutReason.Size = new System.Drawing.Size(1345, 195);
            this.FlowLayoutReason.TabIndex = 16;
            this.FlowLayoutReason.WrapContents = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 1061);
            this.Controls.Add(this.FlowLayoutReason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalVoteLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeeVoteLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VoteGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.EmployeePicture);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.VoteHeaderCombo);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VoteHeaderCombo;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionText;
        private System.Windows.Forms.PictureBox EmployeePicture;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView VoteGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EmployeeVoteLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalVoteLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutReason;
    }
}