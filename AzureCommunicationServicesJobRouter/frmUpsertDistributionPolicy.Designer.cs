namespace AzureCommunicationServicesJobRouter
{
    partial class frmUpsertDistributionPolicy
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
            label1 = new Label();
            label2 = new Label();
            numOfferExpiry = new NumericUpDown();
            txtPolicyId = new TextBox();
            label3 = new Label();
            drpMode = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numMin = new NumericUpDown();
            numMax = new NumericUpDown();
            chkByPassSelector = new CheckBox();
            btnUpsert = new Button();
            label7 = new Label();
            txtPolicyName = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numOfferExpiry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMax).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 15);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 100);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Offers expires after:";
            // 
            // numOfferExpiry
            // 
            numOfferExpiry.Location = new Point(156, 98);
            numOfferExpiry.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            numOfferExpiry.Name = "numOfferExpiry";
            numOfferExpiry.Size = new Size(87, 23);
            numOfferExpiry.TabIndex = 3;
            numOfferExpiry.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // txtPolicyId
            // 
            txtPolicyId.Location = new Point(156, 12);
            txtPolicyId.Name = "txtPolicyId";
            txtPolicyId.Size = new Size(230, 23);
            txtPolicyId.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 72);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Mode:";
            // 
            // drpMode
            // 
            drpMode.DropDownStyle = ComboBoxStyle.DropDownList;
            drpMode.FormattingEnabled = true;
            drpMode.ItemHeight = 15;
            drpMode.Location = new Point(156, 69);
            drpMode.Name = "drpMode";
            drpMode.Size = new Size(230, 23);
            drpMode.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 129);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 6;
            label4.Text = "Min. concurrent offers:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 158);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 7;
            label5.Text = "Max. concurrent offers:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 191);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 8;
            label6.Text = "By pass Selector:";
            // 
            // numMin
            // 
            numMin.Location = new Point(158, 127);
            numMin.Name = "numMin";
            numMin.Size = new Size(85, 23);
            numMin.TabIndex = 4;
            numMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numMax
            // 
            numMax.Location = new Point(158, 156);
            numMax.Name = "numMax";
            numMax.Size = new Size(85, 23);
            numMax.TabIndex = 5;
            numMax.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkByPassSelector
            // 
            chkByPassSelector.AutoSize = true;
            chkByPassSelector.Location = new Point(158, 191);
            chkByPassSelector.Name = "chkByPassSelector";
            chkByPassSelector.Size = new Size(15, 14);
            chkByPassSelector.TabIndex = 6;
            chkByPassSelector.UseVisualStyleBackColor = true;
            // 
            // btnUpsert
            // 
            btnUpsert.Location = new Point(311, 208);
            btnUpsert.Name = "btnUpsert";
            btnUpsert.Size = new Size(75, 23);
            btnUpsert.TabIndex = 7;
            btnUpsert.Text = "Create";
            btnUpsert.UseVisualStyleBackColor = true;
            btnUpsert.Click += btnUpsert_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 44);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 13;
            label7.Text = "Name:";
            // 
            // txtPolicyName
            // 
            txtPolicyName.Location = new Point(158, 41);
            txtPolicyName.Name = "txtPolicyName";
            txtPolicyName.Size = new Size(228, 23);
            txtPolicyName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 100);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 15;
            label8.Text = "second(s)";
            // 
            // frmUpsertDistributionPolicy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(398, 243);
            Controls.Add(label8);
            Controls.Add(txtPolicyName);
            Controls.Add(label7);
            Controls.Add(btnUpsert);
            Controls.Add(chkByPassSelector);
            Controls.Add(numMax);
            Controls.Add(numMin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(drpMode);
            Controls.Add(label3);
            Controls.Add(txtPolicyId);
            Controls.Add(numOfferExpiry);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpsertDistributionPolicy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Distribution Policy";
            ((System.ComponentModel.ISupportInitialize)numOfferExpiry).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numOfferExpiry;
        private TextBox txtPolicyId;
        private Label label3;
        private ComboBox drpMode;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numMin;
        private NumericUpDown numMax;
        private CheckBox chkByPassSelector;
        private Button btnUpsert;
        private Label label7;
        private TextBox txtPolicyName;
        private Label label8;
    }
}