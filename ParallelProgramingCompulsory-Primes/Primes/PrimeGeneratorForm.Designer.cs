namespace Primes
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListLabel = new System.Windows.Forms.Label();
            this.CalculatePrimesParallel = new System.Windows.Forms.Button();
            this.PrimesList = new System.Windows.Forms.ListBox();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.toInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(14, 12);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(53, 20);
            this.ListLabel.TabIndex = 0;
            this.ListLabel.Text = "Primes";
            this.ListLabel.Click += new System.EventHandler(this.label_Click);
            // 
            // CalculatePrimesParallel
            // 
            this.CalculatePrimesParallel.Location = new System.Drawing.Point(269, 73);
            this.CalculatePrimesParallel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CalculatePrimesParallel.Name = "CalculatePrimesParallel";
            this.CalculatePrimesParallel.Size = new System.Drawing.Size(235, 31);
            this.CalculatePrimesParallel.TabIndex = 1;
            this.CalculatePrimesParallel.Text = "Calculate Primes sequential\r\n";
            this.CalculatePrimesParallel.UseVisualStyleBackColor = true;
            this.CalculatePrimesParallel.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PrimesList
            // 
            this.PrimesList.FormattingEnabled = true;
            this.PrimesList.ItemHeight = 20;
            this.PrimesList.Location = new System.Drawing.Point(14, 35);
            this.PrimesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrimesList.Name = "PrimesList";
            this.PrimesList.Size = new System.Drawing.Size(247, 464);
            this.PrimesList.TabIndex = 2;
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(269, 35);
            this.fromInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(114, 27);
            this.fromInput.TabIndex = 3;
            this.fromInput.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(269, 11);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(43, 20);
            this.FromLabel.TabIndex = 4;
            this.FromLabel.Text = "From";
            this.FromLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(390, 11);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(25, 20);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "To";
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(390, 35);
            this.toInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(114, 27);
            this.toInput.TabIndex = 6;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 508);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.PrimesList);
            this.Controls.Add(this.CalculatePrimesParallel);
            this.Controls.Add(this.ListLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form";
            this.Text = "PrimeGenerator";
            this.Click += new System.EventHandler(this.btnGetPrimesSequential_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ListLabel;
        private Button CalculatePrimesParallel;
        private ListBox PrimesList;
        private TextBox fromInput;
        private Label FromLabel;
        private Label toLabel;
        private TextBox toInput;
    }
}