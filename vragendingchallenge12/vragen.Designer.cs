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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vragen));
            this.vraag1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vraag1
            // 
            this.vraag1.AutoSize = true;
            this.vraag1.Location = new System.Drawing.Point(560, 190);
            this.vraag1.Name = "vraag1";
            this.vraag1.Size = new System.Drawing.Size(40, 13);
            this.vraag1.TabIndex = 0;
            this.vraag1.Text = "vragen";
            this.vraag1.Click += new System.EventHandler(this.vraag1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "v1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "v2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 85);
            this.button3.TabIndex = 3;
            this.button3.Text = "v3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(677, 485);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 85);
            this.button4.TabIndex = 4;
            this.button4.Text = "v4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // vragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1199, 693);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vraag1);
            this.Name = "vragen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vraag1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}