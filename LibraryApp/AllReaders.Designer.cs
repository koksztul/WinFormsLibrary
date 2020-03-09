namespace LibraryApp
{
    partial class AllReaders
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
            this.AllReadersLabel = new System.Windows.Forms.Label();
            this.AllReadersListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AllReadesBackButton = new System.Windows.Forms.Button();
            this.AddReaderButton = new System.Windows.Forms.Button();
            this.DeleteReaderbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllReadersLabel
            // 
            this.AllReadersLabel.AutoSize = true;
            this.AllReadersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllReadersLabel.Location = new System.Drawing.Point(85, 39);
            this.AllReadersLabel.Name = "AllReadersLabel";
            this.AllReadersLabel.Size = new System.Drawing.Size(398, 37);
            this.AllReadersLabel.TabIndex = 0;
            this.AllReadersLabel.Text = "All readers in the database";
            // 
            // AllReadersListBox
            // 
            this.AllReadersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllReadersListBox.FormattingEnabled = true;
            this.AllReadersListBox.ItemHeight = 20;
            this.AllReadersListBox.Location = new System.Drawing.Point(103, 104);
            this.AllReadersListBox.Name = "AllReadersListBox";
            this.AllReadersListBox.Size = new System.Drawing.Size(362, 204);
            this.AllReadersListBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(103, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show all Readers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllReadesBackButton
            // 
            this.AllReadesBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllReadesBackButton.Location = new System.Drawing.Point(103, 386);
            this.AllReadesBackButton.Name = "AllReadesBackButton";
            this.AllReadesBackButton.Size = new System.Drawing.Size(155, 43);
            this.AllReadesBackButton.TabIndex = 3;
            this.AllReadesBackButton.Text = "Back";
            this.AllReadesBackButton.UseVisualStyleBackColor = true;
            this.AllReadesBackButton.Click += new System.EventHandler(this.AllReadesBackButton_Click);
            // 
            // AddReaderButton
            // 
            this.AddReaderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddReaderButton.Location = new System.Drawing.Point(310, 337);
            this.AddReaderButton.Name = "AddReaderButton";
            this.AddReaderButton.Size = new System.Drawing.Size(155, 43);
            this.AddReaderButton.TabIndex = 4;
            this.AddReaderButton.Text = "Add Reader";
            this.AddReaderButton.UseVisualStyleBackColor = true;
            // 
            // DeleteReaderbutton
            // 
            this.DeleteReaderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteReaderbutton.Location = new System.Drawing.Point(310, 384);
            this.DeleteReaderbutton.Name = "DeleteReaderbutton";
            this.DeleteReaderbutton.Size = new System.Drawing.Size(155, 43);
            this.DeleteReaderbutton.TabIndex = 5;
            this.DeleteReaderbutton.Text = "Delete Reader";
            this.DeleteReaderbutton.UseVisualStyleBackColor = true;
            this.DeleteReaderbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AllReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.DeleteReaderbutton);
            this.Controls.Add(this.AddReaderButton);
            this.Controls.Add(this.AllReadesBackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllReadersListBox);
            this.Controls.Add(this.AllReadersLabel);
            this.Name = "AllReaders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllReaders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllReadersLabel;
        private System.Windows.Forms.ListBox AllReadersListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AllReadesBackButton;
        private System.Windows.Forms.Button AddReaderButton;
        private System.Windows.Forms.Button DeleteReaderbutton;
    }
}