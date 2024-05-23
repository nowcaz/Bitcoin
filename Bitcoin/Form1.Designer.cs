namespace Bitcoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultsLabel = new System.Windows.Forms.Label();
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates_Click = new System.Windows.Forms.Button();
            this.amountOfCoinBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultsLabel.Location = new System.Drawing.Point(78, 305);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(66, 20);
            this.resultsLabel.TabIndex = 5;
            this.resultsLabel.Text = "Results";
            this.resultsLabel.Visible = false;
            this.resultsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // currencyCombo
            // 
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyCombo.Location = new System.Drawing.Point(78, 75);
            this.currencyCombo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(199, 28);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.Text = "Select Currency";
            // 
            // btnGetRates_Click
            // 
            this.btnGetRates_Click.Location = new System.Drawing.Point(357, 72);
            this.btnGetRates_Click.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetRates_Click.Name = "btnGetRates_Click";
            this.btnGetRates_Click.Size = new System.Drawing.Size(125, 35);
            this.btnGetRates_Click.TabIndex = 1;
            this.btnGetRates_Click.Text = "Convert";
            this.btnGetRates_Click.UseVisualStyleBackColor = true;
            this.btnGetRates_Click.Click += new System.EventHandler(this.BtcGetRates_Click);
            // 
            // amountOfCoinBox
            // 
            this.amountOfCoinBox.Location = new System.Drawing.Point(78, 214);
            this.amountOfCoinBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.amountOfCoinBox.Name = "amountOfCoinBox";
            this.amountOfCoinBox.Size = new System.Drawing.Size(199, 27);
            this.amountOfCoinBox.TabIndex = 2;
            this.amountOfCoinBox.TextChanged += new System.EventHandler(this.amountOfCoinBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(73, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of BTC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(78, 334);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(199, 27);
            this.resultTextBox.TabIndex = 4;
            this.resultTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1243, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountOfCoinBox);
            this.Controls.Add(this.btnGetRates_Click);
            this.Controls.Add(this.currencyCombo);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Button btnGetRates_Click;
        private System.Windows.Forms.TextBox amountOfCoinBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

