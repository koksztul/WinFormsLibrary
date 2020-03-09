namespace LibraryApp
{
    partial class NeverBorrowed
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
            this.BookList = new System.Windows.Forms.ListBox();
            this.ShowBooksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBooksBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookList
            // 
            this.BookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BookList.FormattingEnabled = true;
            this.BookList.HorizontalScrollbar = true;
            this.BookList.ItemHeight = 20;
            this.BookList.Location = new System.Drawing.Point(103, 106);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(370, 224);
            this.BookList.TabIndex = 0;
            // 
            // ShowBooksButton
            // 
            this.ShowBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowBooksButton.Location = new System.Drawing.Point(213, 354);
            this.ShowBooksButton.Name = "ShowBooksButton";
            this.ShowBooksButton.Size = new System.Drawing.Size(146, 43);
            this.ShowBooksButton.TabIndex = 1;
            this.ShowBooksButton.Text = "Show books";
            this.ShowBooksButton.UseVisualStyleBackColor = true;
            this.ShowBooksButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Books that were never borrowed";
            // 
            // ListBooksBackButton
            // 
            this.ListBooksBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ListBooksBackButton.Location = new System.Drawing.Point(253, 403);
            this.ListBooksBackButton.Name = "ListBooksBackButton";
            this.ListBooksBackButton.Size = new System.Drawing.Size(75, 37);
            this.ListBooksBackButton.TabIndex = 3;
            this.ListBooksBackButton.Text = "Back";
            this.ListBooksBackButton.UseVisualStyleBackColor = true;
            this.ListBooksBackButton.Click += new System.EventHandler(this.ListBooksBackButton_Click);
            // 
            // NeverBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.ListBooksBackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowBooksButton);
            this.Controls.Add(this.BookList);
            this.Name = "NeverBorrowed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.Button ShowBooksButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ListBooksBackButton;
    }
}