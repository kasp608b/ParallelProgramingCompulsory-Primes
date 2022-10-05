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
            this.CalculatePrimesSequential = new System.Windows.Forms.Button();
            this.PrimesList = new System.Windows.Forms.ListBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.CalculatePrimesParallel = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.fromInput = new System.Windows.Forms.NumericUpDown();
            this.toInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fromInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toInput)).BeginInit();
            this.SuspendLayout();
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(12, 9);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(43, 15);
            this.ListLabel.TabIndex = 0;
            this.ListLabel.Text = "Primes";
            // 
            // CalculatePrimesSequential
            // 
            this.CalculatePrimesSequential.Location = new System.Drawing.Point(235, 122);
            this.CalculatePrimesSequential.Name = "CalculatePrimesSequential";
            this.CalculatePrimesSequential.Size = new System.Drawing.Size(206, 23);
            this.CalculatePrimesSequential.TabIndex = 1;
            this.CalculatePrimesSequential.Text = "Calculate Primes sequential\r\n";
            this.CalculatePrimesSequential.UseVisualStyleBackColor = true;
            this.CalculatePrimesSequential.Click += new System.EventHandler(this.btnGetPrimesSequential_Click);
            // 
            // PrimesList
            // 
            this.PrimesList.FormattingEnabled = true;
            this.PrimesList.ItemHeight = 15;
            this.PrimesList.Location = new System.Drawing.Point(12, 26);
            this.PrimesList.Name = "PrimesList";
            this.PrimesList.Size = new System.Drawing.Size(217, 349);
            this.PrimesList.TabIndex = 2;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(235, 75);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(35, 15);
            this.FromLabel.TabIndex = 4;
            this.FromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(361, 75);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(19, 15);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "To";
            // 
            // CalculatePrimesParallel
            // 
            this.CalculatePrimesParallel.Location = new System.Drawing.Point(235, 151);
            this.CalculatePrimesParallel.Name = "CalculatePrimesParallel";
            this.CalculatePrimesParallel.Size = new System.Drawing.Size(206, 23);
            this.CalculatePrimesParallel.TabIndex = 7;
            this.CalculatePrimesParallel.Text = "Calculate Primes parallel";
            this.CalculatePrimesParallel.UseVisualStyleBackColor = true;
            this.CalculatePrimesParallel.Click += new System.EventHandler(this.btnGetPrimesParallel_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(235, 44);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(73, 23);
            this.timeTextBox.TabIndex = 9;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(235, 26);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(33, 15);
            this.TimerLabel.TabIndex = 8;
            this.TimerLabel.Text = "Time";
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(235, 93);
            this.fromInput.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(120, 23);
            this.fromInput.TabIndex = 10;
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(361, 93);
            this.toInput.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(120, 23);
            this.toInput.TabIndex = 11;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 381);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.CalculatePrimesParallel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.PrimesList);
            this.Controls.Add(this.CalculatePrimesSequential);
            this.Controls.Add(this.ListLabel);
            this.Name = "Form";
            this.Text = "PrimeGenerator";
            this.Click += new System.EventHandler(this.btnGetPrimesSequential_Click);
            ((System.ComponentModel.ISupportInitialize)(this.fromInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ListLabel;
        private Button CalculatePrimesSequential;
        private ListBox PrimesList;
        private Label FromLabel;
        private Label toLabel;
        private Button CalculatePrimesParallel;
        private TextBox timeTextBox;
        private Label TimerLabel;
        private NumericUpDown fromInput;
        private NumericUpDown toInput;
    }
}