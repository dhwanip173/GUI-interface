namespace Part_B
{

    /// <summary>
    /// krunal patel - 000826784
    /// 
    /// </summary>
    partial class frmMain
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
            this.cmbHairdressers = new System.Windows.Forms.ComboBox();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.lstChargedItems = new System.Windows.Forms.ListBox();
            this.lstPrices = new System.Windows.Forms.ListBox();
            this.lblHairdresser = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblChargedItems = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnService = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtCalculatedPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbHairdressers
            // 
            this.cmbHairdressers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHairdressers.FormattingEnabled = true;
            this.cmbHairdressers.Location = new System.Drawing.Point(12, 84);
            this.cmbHairdressers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHairdressers.Name = "cmbHairdressers";
            this.cmbHairdressers.Size = new System.Drawing.Size(160, 25);
            this.cmbHairdressers.TabIndex = 0;
            this.cmbHairdressers.SelectedIndexChanged += new System.EventHandler(this.cmbHairdressers_SelectedIndexChanged);
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 17;
            this.lstServices.Location = new System.Drawing.Point(189, 84);
            this.lstServices.Margin = new System.Windows.Forms.Padding(4);
            this.lstServices.Name = "lstServices";
            this.lstServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstServices.Size = new System.Drawing.Size(159, 191);
            this.lstServices.TabIndex = 1;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.listBoxService_SelectedIndexChanged);
            // 
            // lstChargedItems
            // 
            this.lstChargedItems.FormattingEnabled = true;
            this.lstChargedItems.ItemHeight = 17;
            this.lstChargedItems.Location = new System.Drawing.Point(372, 84);
            this.lstChargedItems.Margin = new System.Windows.Forms.Padding(4);
            this.lstChargedItems.Name = "lstChargedItems";
            this.lstChargedItems.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstChargedItems.Size = new System.Drawing.Size(211, 191);
            this.lstChargedItems.TabIndex = 2;
            // 
            // lstPrices
            // 
            this.lstPrices.FormattingEnabled = true;
            this.lstPrices.ItemHeight = 17;
            this.lstPrices.Location = new System.Drawing.Point(601, 84);
            this.lstPrices.Margin = new System.Windows.Forms.Padding(4);
            this.lstPrices.Name = "lstPrices";
            this.lstPrices.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstPrices.Size = new System.Drawing.Size(195, 191);
            this.lstPrices.TabIndex = 3;
            // 
            // lblHairdresser
            // 
            this.lblHairdresser.AutoSize = true;
            this.lblHairdresser.Location = new System.Drawing.Point(13, 56);
            this.lblHairdresser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHairdresser.Name = "lblHairdresser";
            this.lblHairdresser.Size = new System.Drawing.Size(117, 17);
            this.lblHairdresser.TabIndex = 4;
            this.lblHairdresser.Text = "Select HairDresser";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(185, 56);
            this.lblServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(90, 17);
            this.lblServices.TabIndex = 5;
            this.lblServices.Text = "Select Service";
            // 
            // lblChargedItems
            // 
            this.lblChargedItems.AutoSize = true;
            this.lblChargedItems.Location = new System.Drawing.Point(368, 56);
            this.lblChargedItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChargedItems.Name = "lblChargedItems";
            this.lblChargedItems.Size = new System.Drawing.Size(91, 17);
            this.lblChargedItems.TabIndex = 6;
            this.lblChargedItems.Text = "Charged Item";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(597, 56);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 17);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.IndianRed;
            this.btnService.Enabled = false;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.Location = new System.Drawing.Point(323, 371);
            this.btnService.Margin = new System.Windows.Forms.Padding(4);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(112, 38);
            this.btnService.TabIndex = 8;
            this.btnService.Text = "Add Service";
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.BackColor = System.Drawing.Color.IndianRed;
            this.btnResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetAll.ForeColor = System.Drawing.Color.White;
            this.btnResetAll.Location = new System.Drawing.Point(554, 371);
            this.btnResetAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(112, 38);
            this.btnResetAll.TabIndex = 9;
            this.btnResetAll.Text = "Reset";
            this.btnResetAll.UseVisualStyleBackColor = false;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.IndianRed;
            this.btnCalculate.Enabled = false;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(439, 371);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 38);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(669, 371);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 38);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(582, 298);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(70, 17);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // txtCalculatedPrice
            // 
            this.txtCalculatedPrice.Location = new System.Drawing.Point(664, 294);
            this.txtCalculatedPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalculatedPrice.Name = "txtCalculatedPrice";
            this.txtCalculatedPrice.Size = new System.Drawing.Size(132, 25);
            this.txtCalculatedPrice.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 443);
            this.Controls.Add(this.txtCalculatedPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblChargedItems);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblHairdresser);
            this.Controls.Add(this.lstPrices);
            this.Controls.Add(this.lstChargedItems);
            this.Controls.Add(this.lstServices);
            this.Controls.Add(this.cmbHairdressers);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfect Cut Hair Saloon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHairdressers;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.ListBox lstChargedItems;
        private System.Windows.Forms.ListBox lstPrices;
        private System.Windows.Forms.Label lblHairdresser;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblChargedItems;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtCalculatedPrice;
    }
}

