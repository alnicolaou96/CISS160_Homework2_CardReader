namespace Homework2_CardIdentifier
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
            this.Hearts = new System.Windows.Forms.PictureBox();
            this.Diamonds = new System.Windows.Forms.PictureBox();
            this.Clubs = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YourCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diamonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clubs)).BeginInit();
            this.SuspendLayout();
            // 
            // Hearts
            // 
            this.Hearts.Image = global::Homework2_CardIdentifier.Properties.Resources._2_Hearts;
            this.Hearts.Location = new System.Drawing.Point(60, 12);
            this.Hearts.Name = "Hearts";
            this.Hearts.Size = new System.Drawing.Size(51, 72);
            this.Hearts.TabIndex = 0;
            this.Hearts.TabStop = false;
            this.Hearts.Click += new System.EventHandler(this.Hearts_Click);
            // 
            // Diamonds
            // 
            this.Diamonds.Image = global::Homework2_CardIdentifier.Properties.Resources._2_Diamonds;
            this.Diamonds.Location = new System.Drawing.Point(117, 12);
            this.Diamonds.Name = "Diamonds";
            this.Diamonds.Size = new System.Drawing.Size(52, 72);
            this.Diamonds.TabIndex = 1;
            this.Diamonds.TabStop = false;
            this.Diamonds.Click += new System.EventHandler(this.Diamonds_Click);
            // 
            // Clubs
            // 
            this.Clubs.Image = global::Homework2_CardIdentifier.Properties.Resources._2_Clubs;
            this.Clubs.Location = new System.Drawing.Point(175, 12);
            this.Clubs.Name = "Clubs";
            this.Clubs.Size = new System.Drawing.Size(53, 72);
            this.Clubs.TabIndex = 2;
            this.Clubs.TabStop = false;
            this.Clubs.Click += new System.EventHandler(this.Clubs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick A Card";
            // 
            // YourCard
            // 
            this.YourCard.AutoSize = true;
            this.YourCard.Location = new System.Drawing.Point(85, 144);
            this.YourCard.Name = "YourCard";
            this.YourCard.Size = new System.Drawing.Size(16, 13);
            this.YourCard.TabIndex = 4;
            this.YourCard.Text = "...";
            this.YourCard.Click += new System.EventHandler(this.YourCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 190);
            this.Controls.Add(this.YourCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clubs);
            this.Controls.Add(this.Diamonds);
            this.Controls.Add(this.Hearts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diamonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hearts;
        private System.Windows.Forms.PictureBox Diamonds;
        private System.Windows.Forms.PictureBox Clubs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YourCard;
    }
}

