namespace CoachUI
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
            this.stopButton = new System.Windows.Forms.Button();
            this.coachbookingsLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.seatLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.seatTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Crimson;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.stopButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.stopButton.Location = new System.Drawing.Point(670, 375);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(118, 63);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // coachbookingsLabel
            // 
            this.coachbookingsLabel.AutoSize = true;
            this.coachbookingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.coachbookingsLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.coachbookingsLabel.Location = new System.Drawing.Point(284, 42);
            this.coachbookingsLabel.Name = "coachbookingsLabel";
            this.coachbookingsLabel.Size = new System.Drawing.Size(160, 26);
            this.coachbookingsLabel.TabIndex = 1;
            this.coachbookingsLabel.Text = "Coach Booking";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ageLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ageLabel.Location = new System.Drawing.Point(187, 180);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(38, 20);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age";
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.seatLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.seatLabel.Location = new System.Drawing.Point(387, 180);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(43, 20);
            this.seatLabel.TabIndex = 3;
            this.seatLabel.Text = "Seat";
            this.seatLabel.Click += new System.EventHandler(this.seatLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.nameLabel.Location = new System.Drawing.Point(174, 132);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(252, 132);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(258, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // seatTextBox
            // 
            this.seatTextBox.Location = new System.Drawing.Point(474, 180);
            this.seatTextBox.Name = "seatTextBox";
            this.seatTextBox.Size = new System.Drawing.Size(36, 20);
            this.seatTextBox.TabIndex = 6;
            this.seatTextBox.TextChanged += new System.EventHandler(this.seatTextBox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(252, 180);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(36, 20);
            this.ageTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addButton.Location = new System.Drawing.Point(141, 223);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 63);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add To Bus";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // getButton
            // 
            this.getButton.BackColor = System.Drawing.Color.Gainsboro;
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.getButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.getButton.Location = new System.Drawing.Point(302, 223);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(118, 63);
            this.getButton.TabIndex = 9;
            this.getButton.Text = "Get By Name";
            this.getButton.UseVisualStyleBackColor = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.removeButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.removeButton.Location = new System.Drawing.Point(465, 223);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(118, 63);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove By Name";
            this.removeButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Gainsboro;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.clearButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.clearButton.Location = new System.Drawing.Point(302, 306);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 63);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoachUI.Properties.Resources.burning_bus_big_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.seatTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.seatLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.coachbookingsLabel);
            this.Controls.Add(this.stopButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label coachbookingsLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox seatTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
    }
}

