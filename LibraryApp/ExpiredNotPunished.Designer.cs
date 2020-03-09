namespace LibraryApp
{
    partial class ExpiredNotPunished
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
            this.ExpiredLabel = new System.Windows.Forms.Label();
            this.ExpiredBooksListBox = new System.Windows.Forms.ListBox();
            this.ShowExpiredButton = new System.Windows.Forms.Button();
            this.ExpiredBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExpiredLabel
            // 
            this.ExpiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExpiredLabel.Location = new System.Drawing.Point(86, 30);
            this.ExpiredLabel.Name = "ExpiredLabel";
            this.ExpiredLabel.Size = new System.Drawing.Size(390, 80);
            this.ExpiredLabel.TabIndex = 0;
            this.ExpiredLabel.Text = "Books with expired return date.Not punished yet.";
            this.ExpiredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpiredBooksListBox
            // 
            this.ExpiredBooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExpiredBooksListBox.FormattingEnabled = true;
            this.ExpiredBooksListBox.ItemHeight = 20;
            this.ExpiredBooksListBox.Location = new System.Drawing.Point(119, 123);
            this.ExpiredBooksListBox.Name = "ExpiredBooksListBox";
            this.ExpiredBooksListBox.Size = new System.Drawing.Size(318, 164);
            this.ExpiredBooksListBox.TabIndex = 1;
            // 
            // ShowExpiredButton
            // 
            this.ShowExpiredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowExpiredButton.Location = new System.Drawing.Point(211, 321);
            this.ShowExpiredButton.Name = "ShowExpiredButton";
            this.ShowExpiredButton.Size = new System.Drawing.Size(121, 66);
            this.ShowExpiredButton.TabIndex = 2;
            this.ShowExpiredButton.Text = "Show Expired";
            this.ShowExpiredButton.UseVisualStyleBackColor = true;
            this.ShowExpiredButton.Click += new System.EventHandler(this.ShowExpiredButton_Click);
            // 
            // ExpiredBackButton
            // 
            this.ExpiredBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExpiredBackButton.Location = new System.Drawing.Point(211, 393);
            this.ExpiredBackButton.Name = "ExpiredBackButton";
            this.ExpiredBackButton.Size = new System.Drawing.Size(121, 40);
            this.ExpiredBackButton.TabIndex = 3;
            this.ExpiredBackButton.Text = "Back";
            this.ExpiredBackButton.UseVisualStyleBackColor = true;
            this.ExpiredBackButton.Click += new System.EventHandler(this.ExpiredBackButton_Click);
            // 
            // ExpiredNotPunished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.ExpiredBackButton);
            this.Controls.Add(this.ShowExpiredButton);
            this.Controls.Add(this.ExpiredBooksListBox);
            this.Controls.Add(this.ExpiredLabel);
            this.Name = "ExpiredNotPunished";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpiredNotPunished";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ExpiredLabel;
        private System.Windows.Forms.ListBox ExpiredBooksListBox;
        private System.Windows.Forms.Button ShowExpiredButton;
        private System.Windows.Forms.Button ExpiredBackButton;
    }
}