namespace LibraryApp
{
    partial class AllBooks
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
            this.AllBooksListBox = new System.Windows.Forms.ListBox();
            this.AllBooksLabel = new System.Windows.Forms.Label();
            this.ListAllButton = new System.Windows.Forms.Button();
            this.AllBooksBackButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllBooksListBox
            // 
            this.AllBooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllBooksListBox.FormattingEnabled = true;
            this.AllBooksListBox.ItemHeight = 20;
            this.AllBooksListBox.Location = new System.Drawing.Point(109, 111);
            this.AllBooksListBox.Name = "AllBooksListBox";
            this.AllBooksListBox.Size = new System.Drawing.Size(362, 204);
            this.AllBooksListBox.TabIndex = 0;
            // 
            // AllBooksLabel
            // 
            this.AllBooksLabel.AutoSize = true;
            this.AllBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllBooksLabel.Location = new System.Drawing.Point(120, 58);
            this.AllBooksLabel.Name = "AllBooksLabel";
            this.AllBooksLabel.Size = new System.Drawing.Size(331, 37);
            this.AllBooksLabel.TabIndex = 1;
            this.AllBooksLabel.Text = "All books in the library";
            // 
            // ListAllButton
            // 
            this.ListAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ListAllButton.Location = new System.Drawing.Point(109, 343);
            this.ListAllButton.Name = "ListAllButton";
            this.ListAllButton.Size = new System.Drawing.Size(167, 43);
            this.ListAllButton.TabIndex = 2;
            this.ListAllButton.Text = "List all books";
            this.ListAllButton.UseVisualStyleBackColor = true;
            this.ListAllButton.Click += new System.EventHandler(this.ListAllButton_Click);
            // 
            // AllBooksBackButton
            // 
            this.AllBooksBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllBooksBackButton.Location = new System.Drawing.Point(109, 392);
            this.AllBooksBackButton.Name = "AllBooksBackButton";
            this.AllBooksBackButton.Size = new System.Drawing.Size(167, 41);
            this.AllBooksBackButton.TabIndex = 3;
            this.AllBooksBackButton.Text = "Back";
            this.AllBooksBackButton.UseVisualStyleBackColor = true;
            this.AllBooksBackButton.Click += new System.EventHandler(this.AllBooksBackButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddBookButton.Location = new System.Drawing.Point(304, 343);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(167, 43);
            this.AddBookButton.TabIndex = 4;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteBookButton.Location = new System.Drawing.Point(304, 389);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(167, 43);
            this.DeleteBookButton.TabIndex = 5;
            this.DeleteBookButton.Text = "Delete Book";
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.AllBooksBackButton);
            this.Controls.Add(this.ListAllButton);
            this.Controls.Add(this.AllBooksLabel);
            this.Controls.Add(this.AllBooksListBox);
            this.Name = "AllBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AllBooksListBox;
        private System.Windows.Forms.Label AllBooksLabel;
        private System.Windows.Forms.Button ListAllButton;
        private System.Windows.Forms.Button AllBooksBackButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button DeleteBookButton;
    }
}