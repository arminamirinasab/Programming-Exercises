namespace FavouriteLanguage
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.lstSelect = new System.Windows.Forms.ListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("M PLUS 2", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Favoruite Programming Language And Move It To Your List";
            // 
            // cmbSelect
            // 
            this.cmbSelect.DropDownHeight = 150;
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.Font = new System.Drawing.Font("M PLUS 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.IntegralHeight = false;
            this.cmbSelect.ItemHeight = 26;
            this.cmbSelect.Items.AddRange(new object[] {
            "JavaScript",
            "PHP",
            "C#",
            "C++",
            "Go",
            "Python",
            "C",
            "HTML",
            "CSS",
            "Loa",
            "Assembly",
            "Java",
            "Delphi",
            "Kotlin",
            "Dart"});
            this.cmbSelect.Location = new System.Drawing.Point(23, 87);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(266, 34);
            this.cmbSelect.TabIndex = 1;
            // 
            // lstSelect
            // 
            this.lstSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSelect.Font = new System.Drawing.Font("M PLUS 2", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSelect.FormattingEnabled = true;
            this.lstSelect.ItemHeight = 25;
            this.lstSelect.Location = new System.Drawing.Point(533, 105);
            this.lstSelect.Name = "lstSelect";
            this.lstSelect.Size = new System.Drawing.Size(245, 202);
            this.lstSelect.TabIndex = 2;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(23, 127);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(110, 38);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(408, 269);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(110, 38);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "© Armin Amiri Nasab";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(408, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lstSelect);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Favourite Language";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbSelect;
        private ListBox lstSelect;
        private Button btnMove;
        private Button btnUndo;
        private Label label2;
        private Button btnClear;
    }
}