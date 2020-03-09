namespace LibraryApp
{
    partial class UsersWithBorrowedBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsersWBooksBorrowedButton = new System.Windows.Forms.Button();
            this.WithBorrowedBackButton = new System.Windows.Forms.Button();
            this.UsersWBooksBorrowedListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users that have borrowed books";
            // 
            // UsersWBooksBorrowedButton
            // 
            this.UsersWBooksBorrowedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UsersWBooksBorrowedButton.Location = new System.Drawing.Point(226, 341);
            this.UsersWBooksBorrowedButton.Name = "UsersWBooksBorrowedButton";
            this.UsersWBooksBorrowedButton.Size = new System.Drawing.Size(138, 43);
            this.UsersWBooksBorrowedButton.TabIndex = 1;
            this.UsersWBooksBorrowedButton.Text = "Show users";
            this.UsersWBooksBorrowedButton.UseVisualStyleBackColor = true;
            this.UsersWBooksBorrowedButton.Click += new System.EventHandler(this.UsersWBooksBorrowedButton_Click);
            // 
            // WithBorrowedBackButton
            // 
            this.WithBorrowedBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WithBorrowedBackButton.Location = new System.Drawing.Point(226, 390);
            this.WithBorrowedBackButton.Name = "WithBorrowedBackButton";
            this.WithBorrowedBackButton.Size = new System.Drawing.Size(138, 39);
            this.WithBorrowedBackButton.TabIndex = 2;
            this.WithBorrowedBackButton.Text = "Back";
            this.WithBorrowedBackButton.UseVisualStyleBackColor = true;
            this.WithBorrowedBackButton.Click += new System.EventHandler(this.WithBorrowedBackButton_Click);
            // 
            // UsersWBooksBorrowedListBox
            // 
            this.UsersWBooksBorrowedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UsersWBooksBorrowedListBox.FormattingEnabled = true;
            this.UsersWBooksBorrowedListBox.ItemHeight = 20;
            this.UsersWBooksBorrowedListBox.Location = new System.Drawing.Point(90, 109);
            this.UsersWBooksBorrowedListBox.Name = "UsersWBooksBorrowedListBox";
            this.UsersWBooksBorrowedListBox.Size = new System.Drawing.Size(414, 204);
            this.UsersWBooksBorrowedListBox.TabIndex = 3;
            // 
            // UsersWithBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.UsersWBooksBorrowedListBox);
            this.Controls.Add(this.WithBorrowedBackButton);
            this.Controls.Add(this.UsersWBooksBorrowedButton);
            this.Controls.Add(this.label1);
            this.Name = "UsersWithBorrowedBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersWithBorrowedBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UsersWBooksBorrowedButton;
        private System.Windows.Forms.Button WithBorrowedBackButton;
        private System.Windows.Forms.ListBox UsersWBooksBorrowedListBox;
    }
}