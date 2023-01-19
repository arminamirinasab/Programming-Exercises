namespace CarMovement
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
            this.components = new System.ComponentModel.Container();
            this.carPic = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.carSpeed = new System.Windows.Forms.TrackBar();
            this.carTimer = new System.Windows.Forms.Timer(this.components);
            this.chkAuto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // carPic
            // 
            this.carPic.Image = global::CarMovement.Properties.Resources.vecteezy_vintage_car_1193929;
            this.carPic.Location = new System.Drawing.Point(0, 200);
            this.carPic.Name = "carPic";
            this.carPic.Size = new System.Drawing.Size(200, 100);
            this.carPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPic.TabIndex = 0;
            this.carPic.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 74);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(123, 74);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(106, 35);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // carSpeed
            // 
            this.carSpeed.LargeChange = 1;
            this.carSpeed.Location = new System.Drawing.Point(12, 12);
            this.carSpeed.Maximum = 15;
            this.carSpeed.Minimum = -3;
            this.carSpeed.Name = "carSpeed";
            this.carSpeed.Size = new System.Drawing.Size(371, 56);
            this.carSpeed.TabIndex = 3;
            this.carSpeed.Value = 1;
            // 
            // carTimer
            // 
            this.carTimer.Interval = 10;
            this.carTimer.Tick += new System.EventHandler(this.carTimer_Tick);
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Checked = true;
            this.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuto.Location = new System.Drawing.Point(235, 80);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(135, 24);
            this.chkAuto.TabIndex = 4;
            this.chkAuto.Text = "Automatic Gear";
            this.chkAuto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 301);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.carSpeed);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.carPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Car Movement";
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox carPic;
        private Button btnStart;
        private Button btnStop;
        private TrackBar carSpeed;
        private System.Windows.Forms.Timer carTimer;
        private CheckBox chkAuto;
    }
}