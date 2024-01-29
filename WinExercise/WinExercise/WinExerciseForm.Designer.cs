namespace WinExercise
{
    partial class WinExerciseForm
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
            this.pbEcho = new System.Windows.Forms.ProgressBar();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblSquareValue = new System.Windows.Forms.Label();
            this.lblCubeValue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnShowTracker = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSquare = new System.Windows.Forms.Label();
            this.lblCube = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbEcho
            // 
            this.pbEcho.Location = new System.Drawing.Point(18, 63);
            this.pbEcho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbEcho.Name = "pbEcho";
            this.pbEcho.Size = new System.Drawing.Size(752, 35);
            this.pbEcho.TabIndex = 1;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(14, 154);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(50, 20);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "&Value";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(18, 178);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(148, 26);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // lblSquareValue
            // 
            this.lblSquareValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSquareValue.Location = new System.Drawing.Point(440, 177);
            this.lblSquareValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSquareValue.Name = "lblSquareValue";
            this.lblSquareValue.Size = new System.Drawing.Size(149, 30);
            this.lblSquareValue.TabIndex = 6;
            this.lblSquareValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCubeValue
            // 
            this.lblCubeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCubeValue.Location = new System.Drawing.Point(616, 177);
            this.lblCubeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCubeValue.Name = "lblCubeValue";
            this.lblCubeValue.Size = new System.Drawing.Size(149, 30);
            this.lblCubeValue.TabIndex = 8;
            this.lblCubeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(208, 172);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(202, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnShowTracker
            // 
            this.btnShowTracker.Location = new System.Drawing.Point(18, 18);
            this.btnShowTracker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowTracker.Name = "btnShowTracker";
            this.btnShowTracker.Size = new System.Drawing.Size(202, 35);
            this.btnShowTracker.TabIndex = 0;
            this.btnShowTracker.Text = "Show &Tracker";
            this.btnShowTracker.UseVisualStyleBackColor = true;
            this.btnShowTracker.Click += new System.EventHandler(this.btnShowSlider_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 234);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "&First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(228, 234);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "&Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(18, 258);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(148, 26);
            this.txtFirstName.TabIndex = 10;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(232, 258);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(148, 26);
            this.txtLastName.TabIndex = 12;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(14, 312);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(753, 35);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSquare
            // 
            this.lblSquare.AutoSize = true;
            this.lblSquare.Location = new System.Drawing.Point(435, 154);
            this.lblSquare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSquare.Name = "lblSquare";
            this.lblSquare.Size = new System.Drawing.Size(115, 20);
            this.lblSquare.TabIndex = 5;
            this.lblSquare.Text = "Value Squared";
            // 
            // lblCube
            // 
            this.lblCube.AutoSize = true;
            this.lblCube.Location = new System.Drawing.Point(612, 154);
            this.lblCube.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCube.Name = "lblCube";
            this.lblCube.Size = new System.Drawing.Size(101, 20);
            this.lblCube.TabIndex = 7;
            this.lblCube.Text = "Value Cubed";
            // 
            // WinExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 372);
            this.Controls.Add(this.lblCube);
            this.Controls.Add(this.lblSquare);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnShowTracker);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCubeValue);
            this.Controls.Add(this.lblSquareValue);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.pbEcho);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WinExerciseForm";
            this.Text = "Win Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbEcho;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblSquareValue;
        private System.Windows.Forms.Label lblCubeValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnShowTracker;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSquare;
        private System.Windows.Forms.Label lblCube;
    }
}

