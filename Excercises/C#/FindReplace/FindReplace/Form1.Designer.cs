namespace FindReplace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 41);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(532, 319);
            this.txtString.TabIndex = 0;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(12, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.PlaceholderText = "Find";
            this.txtFind.Size = new System.Drawing.Size(210, 23);
            this.txtFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(378, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(459, 12);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(85, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(228, 12);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.PlaceholderText = "Replace";
            this.txtReplace.Size = new System.Drawing.Size(144, 23);
            this.txtReplace.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 372);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.txtString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Find & Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtString;
        private TextBox txtFind;
        private Button btnFind;
        private Button btnReplace;
        private TextBox txtReplace;
    }
}