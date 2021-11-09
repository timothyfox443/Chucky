namespace ChuckDoesNotPlay
{
    partial class Form1
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
            this.btnGenerateJoke = new System.Windows.Forms.Button();
            this.lblDisplayJoke = new System.Windows.Forms.Label();
            this.cmbJokeCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerateJoke
            // 
            this.btnGenerateJoke.Location = new System.Drawing.Point(40, 144);
            this.btnGenerateJoke.Name = "btnGenerateJoke";
            this.btnGenerateJoke.Size = new System.Drawing.Size(121, 23);
            this.btnGenerateJoke.TabIndex = 1;
            this.btnGenerateJoke.Text = "Use at your peril";
            this.btnGenerateJoke.UseVisualStyleBackColor = true;
            this.btnGenerateJoke.Click += new System.EventHandler(this.btnGenerateJoke_Click);
            // 
            // lblDisplayJoke
            // 
            this.lblDisplayJoke.AutoSize = true;
            this.lblDisplayJoke.Location = new System.Drawing.Point(40, 75);
            this.lblDisplayJoke.Name = "lblDisplayJoke";
            this.lblDisplayJoke.Size = new System.Drawing.Size(150, 15);
            this.lblDisplayJoke.TabIndex = 2;
            this.lblDisplayJoke.Text = "Mr. Norris will see you now";
            // 
            // cmbJokeCategories
            // 
            this.cmbJokeCategories.FormattingEnabled = true;
            this.cmbJokeCategories.Location = new System.Drawing.Point(40, 22);
            this.cmbJokeCategories.Name = "cmbJokeCategories";
            this.cmbJokeCategories.Size = new System.Drawing.Size(121, 23);
            this.cmbJokeCategories.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.cmbJokeCategories);
            this.Controls.Add(this.lblDisplayJoke);
            this.Controls.Add(this.btnGenerateJoke);
            this.Name = "Form1";
            this.Text = "Chuck Norris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerateJoke;
        private Label lblDisplayJoke;
        private ComboBox cmbJokeCategories;
    }
}