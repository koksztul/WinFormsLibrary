namespace LibraryApp
{
    partial class ExpiringReturnDateForm
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
            this.ExpiringBooksLabel = new System.Windows.Forms.Label();
            this.ExpiringBooksListBox = new System.Windows.Forms.ListBox();
            this.ShowExpiringButton = new System.Windows.Forms.Button();
            this.ExpiringBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExpiringBooksLabel
            // 
            this.ExpiringBooksLabel.AutoSize = true;
            this.ExpiringBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExpiringBooksLabel.Location = new System.Drawing.Point(55, 54);
            this.ExpiringBooksLabel.Name = "ExpiringBooksLabel";
            this.ExpiringBooksLabel.Size = new System.Drawing.Size(456, 37);
            this.ExpiringBooksLabel.TabIndex = 0;
            this.ExpiringBooksLabel.Text = "Books with expiring return date";
            // 
            // ExpiringBooksListBox
            // 
            this.ExpiringBooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExpiringBooksListBox.FormattingEnabled = true;
            this.ExpiringBooksListBox.ItemHeight = 20;
            this.ExpiringBooksListBox.Location = new System.Drawing.Point(124, 124);
            this.ExpiringBooksListBox.Name = "ExpiringBooksListBox";
            this.ExpiringBooksListBox.Size = new System.Drawing.Size(308, 144);
            this.ExpiringBooksListBox.TabIndex = 1;
            // 
            // ShowExpiringButton
            // 
            this.ShowExpiringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowExpiringButton.Location = new System.Drawing.Point(192, 319);
            this.ShowExpiringButton.Name = "ShowExpiringButton";
            this.ShowExpiringButton.Size = new System.Drawing.Size(176, 77);
            this.ShowExpiringButton.TabIndex = 2;
            this.ShowExpiringButton.Text = "Show expiring books";
            this.ShowExpiringButton.UseVisualStyleBackColor = true;
            this.ShowExpiringButton.Click += new System.EventHandler(this.ShowExpiringButton_Click);
            // 
            // ExpiringBackButton
            // 
            this.ExpiringBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExpiringBackButton.Location = new System.Drawing.Point(236, 402);
            this.ExpiringBackButton.Name = "ExpiringBackButton";
            this.ExpiringBackButton.Size = new System.Drawing.Size(89, 37);
            this.ExpiringBackButton.TabIndex = 3;
            this.ExpiringBackButton.Text = "Back";
            this.ExpiringBackButton.UseVisualStyleBackColor = true;
            this.ExpiringBackButton.Click += new System.EventHandler(this.ExpiringBackButton_Click);
            // 
            // ExpiringReturnDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.ExpiringBackButton);
            this.Controls.Add(this.ShowExpiringButton);
            this.Controls.Add(this.ExpiringBooksListBox);
            this.Controls.Add(this.ExpiringBooksLabel);
            this.Name = "ExpiringReturnDateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpiringReturnDateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExpiringBooksLabel;
        private System.Windows.Forms.ListBox ExpiringBooksListBox;
        private System.Windows.Forms.Button ShowExpiringButton;
        private System.Windows.Forms.Button ExpiringBackButton;
    }
}