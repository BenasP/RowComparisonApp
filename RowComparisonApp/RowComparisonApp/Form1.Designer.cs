namespace RowComparisonApp
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
            this.CompareFilePathTextBox = new System.Windows.Forms.TextBox();
            this.CompareButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompareFilePathTextBox
            // 
            this.CompareFilePathTextBox.Location = new System.Drawing.Point(13, 13);
            this.CompareFilePathTextBox.Name = "CompareFilePathTextBox";
            this.CompareFilePathTextBox.Size = new System.Drawing.Size(166, 20);
            this.CompareFilePathTextBox.TabIndex = 0;
            this.CompareFilePathTextBox.TextChanged += new System.EventHandler(this.CompareFilePathTextBox_TextChanged);
            // 
            // CompareButton
            // 
            this.CompareButton.Enabled = false;
            this.CompareButton.Location = new System.Drawing.Point(197, 64);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(75, 23);
            this.CompareButton.TabIndex = 1;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(197, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.CompareFilePathTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CompareFilePathTextBox;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.Button SearchButton;
    }
}

