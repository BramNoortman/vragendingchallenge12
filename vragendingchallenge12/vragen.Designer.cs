namespace vragendingchallenge12
{
    partial class vragen
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
            this.vraag1 = new System.Windows.Forms.Label();
            this.antwoord1 = new System.Windows.Forms.Label();
            this.antwoord2 = new System.Windows.Forms.Label();
            this.antwoord3 = new System.Windows.Forms.Label();
            this.antwoord4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vraag1
            // 
            this.vraag1.AutoSize = true;
            this.vraag1.Location = new System.Drawing.Point(368, 82);
            this.vraag1.Name = "vraag1";
            this.vraag1.Size = new System.Drawing.Size(40, 13);
            this.vraag1.TabIndex = 0;
            this.vraag1.Text = "vragen";
            // 
            // antwoord1
            // 
            this.antwoord1.AutoSize = true;
            this.antwoord1.Location = new System.Drawing.Point(151, 246);
            this.antwoord1.Name = "antwoord1";
            this.antwoord1.Size = new System.Drawing.Size(57, 13);
            this.antwoord1.TabIndex = 1;
            this.antwoord1.Text = "antwoord1";
            // 
            // antwoord2
            // 
            this.antwoord2.AutoSize = true;
            this.antwoord2.Location = new System.Drawing.Point(151, 357);
            this.antwoord2.Name = "antwoord2";
            this.antwoord2.Size = new System.Drawing.Size(57, 13);
            this.antwoord2.TabIndex = 2;
            this.antwoord2.Text = "antwoord2";
            // 
            // antwoord3
            // 
            this.antwoord3.AutoSize = true;
            this.antwoord3.Location = new System.Drawing.Point(585, 246);
            this.antwoord3.Name = "antwoord3";
            this.antwoord3.Size = new System.Drawing.Size(57, 13);
            this.antwoord3.TabIndex = 3;
            this.antwoord3.Text = "antwoord3";
            // 
            // antwoord4
            // 
            this.antwoord4.AutoSize = true;
            this.antwoord4.Location = new System.Drawing.Point(585, 357);
            this.antwoord4.Name = "antwoord4";
            this.antwoord4.Size = new System.Drawing.Size(57, 13);
            this.antwoord4.TabIndex = 4;
            this.antwoord4.Text = "antwoord4";
            // 
            // vragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.antwoord4);
            this.Controls.Add(this.antwoord3);
            this.Controls.Add(this.antwoord2);
            this.Controls.Add(this.antwoord1);
            this.Controls.Add(this.vraag1);
            this.Name = "vragen";
            this.Text = "vragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vraag1;
        private System.Windows.Forms.Label antwoord1;
        private System.Windows.Forms.Label antwoord2;
        private System.Windows.Forms.Label antwoord3;
        private System.Windows.Forms.Label antwoord4;
    }
}