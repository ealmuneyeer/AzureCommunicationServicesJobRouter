namespace AzureCommunicationServicesJobRouter
{
    partial class frmRespondToJobOffer
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
            rdoAccept = new RadioButton();
            rdoDecline = new RadioButton();
            grpDeclineOffer = new GroupBox();
            label4 = new Label();
            numRetryAfterSeconds = new NumericUpDown();
            chkDeclineRetryAfter = new CheckBox();
            btnRespond = new Button();
            dgOffers = new DataGridView();
            colOfferId = new DataGridViewTextBoxColumn();
            colJobId = new DataGridViewTextBoxColumn();
            colCapacityCost = new DataGridViewTextBoxColumn();
            colOfferedAt = new DataGridViewTextBoxColumn();
            colExpiresAt = new DataGridViewTextBoxColumn();
            grpDeclineOffer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRetryAfterSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgOffers).BeginInit();
            SuspendLayout();
            // 
            // rdoAccept
            // 
            rdoAccept.AutoSize = true;
            rdoAccept.Checked = true;
            rdoAccept.Location = new Point(12, 177);
            rdoAccept.Name = "rdoAccept";
            rdoAccept.Size = new Size(110, 19);
            rdoAccept.TabIndex = 0;
            rdoAccept.TabStop = true;
            rdoAccept.Text = "Accept job offer";
            rdoAccept.UseVisualStyleBackColor = true;
            // 
            // rdoDecline
            // 
            rdoDecline.AutoSize = true;
            rdoDecline.Location = new Point(12, 202);
            rdoDecline.Name = "rdoDecline";
            rdoDecline.Size = new Size(118, 19);
            rdoDecline.TabIndex = 1;
            rdoDecline.Text = "Deceline job offer";
            rdoDecline.UseVisualStyleBackColor = true;
            rdoDecline.CheckedChanged += rdoDecline_CheckedChanged;
            // 
            // grpDeclineOffer
            // 
            grpDeclineOffer.Controls.Add(label4);
            grpDeclineOffer.Controls.Add(numRetryAfterSeconds);
            grpDeclineOffer.Controls.Add(chkDeclineRetryAfter);
            grpDeclineOffer.Enabled = false;
            grpDeclineOffer.Location = new Point(12, 227);
            grpDeclineOffer.Name = "grpDeclineOffer";
            grpDeclineOffer.Size = new Size(291, 67);
            grpDeclineOffer.TabIndex = 8;
            grpDeclineOffer.TabStop = false;
            grpDeclineOffer.Text = "Decline offer options";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 23);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Second(s)";
            // 
            // numRetryAfterSeconds
            // 
            numRetryAfterSeconds.Location = new Point(92, 21);
            numRetryAfterSeconds.Name = "numRetryAfterSeconds";
            numRetryAfterSeconds.Size = new Size(120, 23);
            numRetryAfterSeconds.TabIndex = 1;
            // 
            // chkDeclineRetryAfter
            // 
            chkDeclineRetryAfter.AutoSize = true;
            chkDeclineRetryAfter.Location = new Point(6, 22);
            chkDeclineRetryAfter.Name = "chkDeclineRetryAfter";
            chkDeclineRetryAfter.Size = new Size(80, 19);
            chkDeclineRetryAfter.TabIndex = 0;
            chkDeclineRetryAfter.Text = "Retry after";
            chkDeclineRetryAfter.UseVisualStyleBackColor = true;
            chkDeclineRetryAfter.CheckedChanged += chkDeclineRetryAfter_CheckedChanged;
            // 
            // btnRespond
            // 
            btnRespond.Location = new Point(12, 304);
            btnRespond.Name = "btnRespond";
            btnRespond.Size = new Size(75, 23);
            btnRespond.TabIndex = 9;
            btnRespond.Text = "Respond";
            btnRespond.UseVisualStyleBackColor = true;
            btnRespond.Click += btnRespond_Click;
            // 
            // dgOffers
            // 
            dgOffers.AllowUserToAddRows = false;
            dgOffers.AllowUserToDeleteRows = false;
            dgOffers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOffers.Columns.AddRange(new DataGridViewColumn[] { colOfferId, colJobId, colCapacityCost, colOfferedAt, colExpiresAt });
            dgOffers.Location = new Point(12, 12);
            dgOffers.Name = "dgOffers";
            dgOffers.ReadOnly = true;
            dgOffers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOffers.Size = new Size(1028, 150);
            dgOffers.TabIndex = 14;
            // 
            // colOfferId
            // 
            colOfferId.HeaderText = "Offer Id";
            colOfferId.Name = "colOfferId";
            colOfferId.ReadOnly = true;
            colOfferId.Width = 250;
            // 
            // colJobId
            // 
            colJobId.HeaderText = "Job Id";
            colJobId.Name = "colJobId";
            colJobId.ReadOnly = true;
            colJobId.Width = 200;
            // 
            // colCapacityCost
            // 
            colCapacityCost.HeaderText = "Capacity cost";
            colCapacityCost.Name = "colCapacityCost";
            colCapacityCost.ReadOnly = true;
            colCapacityCost.Width = 120;
            // 
            // colOfferedAt
            // 
            colOfferedAt.HeaderText = "Offered at UTC";
            colOfferedAt.Name = "colOfferedAt";
            colOfferedAt.ReadOnly = true;
            colOfferedAt.Width = 200;
            // 
            // colExpiresAt
            // 
            colExpiresAt.HeaderText = "Expires at UTC";
            colExpiresAt.Name = "colExpiresAt";
            colExpiresAt.ReadOnly = true;
            colExpiresAt.Width = 200;
            // 
            // frmRespondToJobOffer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1049, 339);
            Controls.Add(grpDeclineOffer);
            Controls.Add(rdoDecline);
            Controls.Add(dgOffers);
            Controls.Add(rdoAccept);
            Controls.Add(btnRespond);
            Name = "frmRespondToJobOffer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Respond to Job Offer";
            grpDeclineOffer.ResumeLayout(false);
            grpDeclineOffer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRetryAfterSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgOffers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdoAccept;
        private RadioButton rdoDecline;
        private GroupBox grpDeclineOffer;
        private Label label4;
        private NumericUpDown numRetryAfterSeconds;
        private CheckBox chkDeclineRetryAfter;
        private Button btnRespond;
        private DataGridView dgOffers;
        private DataGridViewTextBoxColumn colOfferId;
        private DataGridViewTextBoxColumn colJobId;
        private DataGridViewTextBoxColumn colCapacityCost;
        private DataGridViewTextBoxColumn colOfferedAt;
        private DataGridViewTextBoxColumn colExpiresAt;
    }
}