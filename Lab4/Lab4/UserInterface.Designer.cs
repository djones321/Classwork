namespace Lab4
{
    partial class UserInterface
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
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxNumber = new System.Windows.Forms.TextBox();
            this.uxFind = new System.Windows.Forms.Button();
            this.uxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Location = new System.Drawing.Point(24, 24);
            this.uxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(188, 24);
            this.uxLabel.TabIndex = 0;
            this.uxLabel.Text = "Enter positive bound:";
            // 
            // uxNumber
            // 
            this.uxNumber.Location = new System.Drawing.Point(224, 21);
            this.uxNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxNumber.Name = "uxNumber";
            this.uxNumber.Size = new System.Drawing.Size(180, 29);
            this.uxNumber.TabIndex = 1;
            // 
            // uxFind
            // 
            this.uxFind.Location = new System.Drawing.Point(152, 86);
            this.uxFind.Name = "uxFind";
            this.uxFind.Size = new System.Drawing.Size(134, 34);
            this.uxFind.TabIndex = 2;
            this.uxFind.Text = "Find Primes";
            this.uxFind.UseVisualStyleBackColor = true;
            this.uxFind.Click += new System.EventHandler(this.uxFind_Click);
            // 
            // uxResult
            // 
            this.uxResult.Location = new System.Drawing.Point(38, 155);
            this.uxResult.Multiline = true;
            this.uxResult.Name = "uxResult";
            this.uxResult.ReadOnly = true;
            this.uxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResult.Size = new System.Drawing.Size(366, 239);
            this.uxResult.TabIndex = 3;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 417);
            this.Controls.Add(this.uxResult);
            this.Controls.Add(this.uxFind);
            this.Controls.Add(this.uxNumber);
            this.Controls.Add(this.uxLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserInterface";
            this.Text = "Sieve of Eratosthenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.TextBox uxNumber;
        private System.Windows.Forms.Button uxFind;
        private System.Windows.Forms.TextBox uxResult;
    }
}

