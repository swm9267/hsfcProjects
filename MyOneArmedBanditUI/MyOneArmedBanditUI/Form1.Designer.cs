namespace MyOneArmedBanditUI
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.nudgeText1 = new System.Windows.Forms.TextBox();
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.nudgeText2 = new System.Windows.Forms.TextBox();
            this.nudgeText3 = new System.Windows.Forms.TextBox();
            this.spinTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.titleTextBox.Location = new System.Drawing.Point(278, 24);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(194, 45);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.Text = "Spin To Win!";
            // 
            // nudgeText1
            // 
            this.nudgeText1.Location = new System.Drawing.Point(112, 280);
            this.nudgeText1.Name = "nudgeText1";
            this.nudgeText1.Size = new System.Drawing.Size(36, 20);
            this.nudgeText1.TabIndex = 1;
            this.nudgeText1.Text = "nudge";
            // 
            // slot1
            // 
            this.slot1.BackgroundImage = global::MyOneArmedBanditUI.Properties.Resources._7;
            this.slot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot1.InitialImage = global::MyOneArmedBanditUI.Properties.Resources._7;
            this.slot1.Location = new System.Drawing.Point(54, 124);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(163, 150);
            this.slot1.TabIndex = 2;
            this.slot1.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.BackgroundImage = global::MyOneArmedBanditUI.Properties.Resources._7;
            this.slot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot2.InitialImage = global::MyOneArmedBanditUI.Properties.Resources._7;
            this.slot2.Location = new System.Drawing.Point(293, 124);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(163, 150);
            this.slot2.TabIndex = 3;
            this.slot2.TabStop = false;
            // 
            // slot3
            // 
            this.slot3.BackgroundImage = global::MyOneArmedBanditUI.Properties.Resources._7;
            this.slot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot3.InitialImage = global::MyOneArmedBanditUI.Properties.Resources._7;
            this.slot3.Location = new System.Drawing.Point(548, 124);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(163, 150);
            this.slot3.TabIndex = 4;
            this.slot3.TabStop = false;
            // 
            // nudgeText2
            // 
            this.nudgeText2.Location = new System.Drawing.Point(353, 280);
            this.nudgeText2.Name = "nudgeText2";
            this.nudgeText2.Size = new System.Drawing.Size(36, 20);
            this.nudgeText2.TabIndex = 5;
            this.nudgeText2.Text = "nudge";
            // 
            // nudgeText3
            // 
            this.nudgeText3.Location = new System.Drawing.Point(610, 280);
            this.nudgeText3.Name = "nudgeText3";
            this.nudgeText3.Size = new System.Drawing.Size(36, 20);
            this.nudgeText3.TabIndex = 6;
            this.nudgeText3.Text = "nudge";
            // 
            // spinTextBox
            // 
            this.spinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.spinTextBox.Location = new System.Drawing.Point(317, 357);
            this.spinTextBox.Name = "spinTextBox";
            this.spinTextBox.Size = new System.Drawing.Size(102, 60);
            this.spinTextBox.TabIndex = 7;
            this.spinTextBox.Text = "Spin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spinTextBox);
            this.Controls.Add(this.nudgeText3);
            this.Controls.Add(this.nudgeText2);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.nudgeText1);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox nudgeText1;
        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.TextBox nudgeText2;
        private System.Windows.Forms.TextBox nudgeText3;
        private System.Windows.Forms.TextBox spinTextBox;
    }
}

