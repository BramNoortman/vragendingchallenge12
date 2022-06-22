
namespace vragendingchallenge12
{
    partial class Resultaat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultaat));
            this.label1 = new System.Windows.Forms.Label();
            this.totalPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punten:";
            // 
            // totalPoints
            // 
            this.totalPoints.AutoSize = true;
            this.totalPoints.Location = new System.Drawing.Point(542, 467);
            this.totalPoints.Name = "totalPoints";
            this.totalPoints.Size = new System.Drawing.Size(35, 13);
            this.totalPoints.TabIndex = 1;
            this.totalPoints.Tag = "";
            this.totalPoints.Text = "label2";
            this.totalPoints.Click += new System.EventHandler(this.label2_Click);
            // 
            // Resultaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1199, 693);
            this.Controls.Add(this.totalPoints);
            this.Controls.Add(this.label1);
            this.Name = "Resultaat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultaat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPoints;
    }
}