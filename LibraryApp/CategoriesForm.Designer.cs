namespace LibraryApp
{
    partial class CategoriesForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriesListBox = new System.Windows.Forms.ListBox();
            this.CategoriesBackButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.DeleteCategorybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(105, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "List by categories";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(142, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books by categories";
            // 
            // CategoriesListBox
            // 
            this.CategoriesListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CategoriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CategoriesListBox.FormattingEnabled = true;
            this.CategoriesListBox.ItemHeight = 20;
            this.CategoriesListBox.Location = new System.Drawing.Point(105, 115);
            this.CategoriesListBox.Name = "CategoriesListBox";
            this.CategoriesListBox.Size = new System.Drawing.Size(384, 204);
            this.CategoriesListBox.TabIndex = 2;
            // 
            // CategoriesBackButton
            // 
            this.CategoriesBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CategoriesBackButton.Location = new System.Drawing.Point(105, 398);
            this.CategoriesBackButton.Name = "CategoriesBackButton";
            this.CategoriesBackButton.Size = new System.Drawing.Size(189, 42);
            this.CategoriesBackButton.TabIndex = 3;
            this.CategoriesBackButton.Text = "Back";
            this.CategoriesBackButton.UseVisualStyleBackColor = true;
            this.CategoriesBackButton.Click += new System.EventHandler(this.CategoriesBackButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddCategoryButton.Location = new System.Drawing.Point(300, 343);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(189, 42);
            this.AddCategoryButton.TabIndex = 4;
            this.AddCategoryButton.Text = "Add Category";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // DeleteCategorybutton
            // 
            this.DeleteCategorybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteCategorybutton.Location = new System.Drawing.Point(300, 398);
            this.DeleteCategorybutton.Name = "DeleteCategorybutton";
            this.DeleteCategorybutton.Size = new System.Drawing.Size(189, 42);
            this.DeleteCategorybutton.TabIndex = 5;
            this.DeleteCategorybutton.Text = "Delete Category";
            this.DeleteCategorybutton.UseVisualStyleBackColor = true;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.DeleteCategorybutton);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.CategoriesBackButton);
            this.Controls.Add(this.CategoriesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CategoriesListBox;
        private System.Windows.Forms.Button CategoriesBackButton;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button DeleteCategorybutton;
    }
}