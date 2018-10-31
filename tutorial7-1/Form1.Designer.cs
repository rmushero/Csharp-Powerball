namespace tutorial7_1
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
            this.generateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.fourthLabel = new System.Windows.Forms.Label();
            this.fifthLabel = new System.Windows.Forms.Label();
            this.powerBall = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(107, 48);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 46);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate Numbers";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(216, 48);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 46);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // firstLabel
            // 
            this.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstLabel.Location = new System.Drawing.Point(33, 9);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(45, 23);
            this.firstLabel.TabIndex = 2;
            // 
            // secondLabel
            // 
            this.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondLabel.Location = new System.Drawing.Point(84, 9);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(45, 23);
            this.secondLabel.TabIndex = 3;
            // 
            // thirdLabel
            // 
            this.thirdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdLabel.Location = new System.Drawing.Point(135, 9);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(45, 23);
            this.thirdLabel.TabIndex = 4;
            // 
            // fourthLabel
            // 
            this.fourthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fourthLabel.Location = new System.Drawing.Point(186, 9);
            this.fourthLabel.Name = "fourthLabel";
            this.fourthLabel.Size = new System.Drawing.Size(45, 23);
            this.fourthLabel.TabIndex = 5;
            // 
            // fifthLabel
            // 
            this.fifthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fifthLabel.Location = new System.Drawing.Point(237, 9);
            this.fifthLabel.Name = "fifthLabel";
            this.fifthLabel.Size = new System.Drawing.Size(45, 23);
            this.fifthLabel.TabIndex = 6;
            // 
            // powerBall
            // 
            this.powerBall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.powerBall.Location = new System.Drawing.Point(308, 9);
            this.powerBall.Name = "powerBall";
            this.powerBall.Size = new System.Drawing.Size(52, 23);
            this.powerBall.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 105);
            this.Controls.Add(this.powerBall);
            this.Controls.Add(this.fifthLabel);
            this.Controls.Add(this.fourthLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateButton);
            this.Name = "Form1";
            this.Text = "Power Ball";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label fourthLabel;
        private System.Windows.Forms.Label fifthLabel;
        private System.Windows.Forms.Label powerBall;
    }
}

