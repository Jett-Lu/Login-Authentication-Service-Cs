namespace WinExercise
{
    partial class WinTracker
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
            this.tbMaster = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMaster
            // 
            this.tbMaster.Location = new System.Drawing.Point(18, 18);
            this.tbMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaster.Maximum = 100;
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.Size = new System.Drawing.Size(744, 69);
            this.tbMaster.TabIndex = 0;
            this.tbMaster.Scroll += new System.EventHandler(this.tbMaster_Scroll);
            // 
            // WinTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 111);
            this.Controls.Add(this.tbMaster);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WinTracker";
            this.Text = "Win Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.tbMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbMaster;
    }
}