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
            this.button = new System.Windows.Forms.Button();
            this.frstNames = new System.Windows.Forms.ListBox();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.toInput = new System.Windows.Forms.TextBox();
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
            this.ListLabel.Click += new System.EventHandler(this.label_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(235, 55);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(120, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Calculate Primes";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frstNames
            // 
            this.frstNames.FormattingEnabled = true;
            this.frstNames.ItemHeight = 15;
            this.frstNames.Location = new System.Drawing.Point(12, 26);
            this.frstNames.Name = "frstNames";
            this.frstNames.Size = new System.Drawing.Size(217, 349);
            this.frstNames.TabIndex = 2;
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(235, 26);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(100, 23);
            this.fromInput.TabIndex = 3;
            this.fromInput.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(235, 8);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(35, 15);
            this.FromLabel.TabIndex = 4;
            this.FromLabel.Text = "From";
            this.FromLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(341, 8);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(19, 15);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "To";
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(341, 26);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(100, 23);
            this.toInput.TabIndex = 6;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 381);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.frstNames);
            this.Controls.Add(this.button);
            this.Controls.Add(this.ListLabel);
            this.Name = "Form";
            this.Text = "PrimeGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ListLabel;
        private Button button;
        private ListBox frstNames;
        private TextBox fromInput;
        private Label FromLabel;
        private Label toLabel;
        private TextBox toInput;
    }
}