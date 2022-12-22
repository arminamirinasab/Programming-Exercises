namespace FontChange
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
            this.fontChange = new System.Windows.Forms.FontDialog();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(66, 127);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.PlaceholderText = "Type something to display the font mode";
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChange.Size = new System.Drawing.Size(350, 198);
            this.txtChange.TabIndex = 0;
            this.txtChange.Text = "Click On Form To Change My Font";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.txtChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Font Change";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontDialog fontChange;
        private TextBox txtChange;
    }
}