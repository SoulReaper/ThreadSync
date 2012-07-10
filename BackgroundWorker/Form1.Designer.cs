namespace BackgroundWorkers
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
            this.label1 = new System.Windows.Forms.Label();
            this.counterATextbox = new System.Windows.Forms.TextBox();
            this.counterBTextbox = new System.Windows.Forms.TextBox();
            this.startAButton = new System.Windows.Forms.Button();
            this.startBButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use backgroundworker to update UI";
            // 
            // counterATextbox
            // 
            this.counterATextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterATextbox.Location = new System.Drawing.Point(16, 30);
            this.counterATextbox.Name = "counterATextbox";
            this.counterATextbox.ReadOnly = true;
            this.counterATextbox.Size = new System.Drawing.Size(100, 20);
            this.counterATextbox.TabIndex = 1;
            this.counterATextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // counterBTextbox
            // 
            this.counterBTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterBTextbox.Location = new System.Drawing.Point(123, 29);
            this.counterBTextbox.Name = "counterBTextbox";
            this.counterBTextbox.ReadOnly = true;
            this.counterBTextbox.Size = new System.Drawing.Size(100, 20);
            this.counterBTextbox.TabIndex = 2;
            this.counterBTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startAButton
            // 
            this.startAButton.Location = new System.Drawing.Point(16, 57);
            this.startAButton.Name = "startAButton";
            this.startAButton.Size = new System.Drawing.Size(100, 23);
            this.startAButton.TabIndex = 3;
            this.startAButton.Text = "Start A";
            this.startAButton.UseVisualStyleBackColor = true;
            this.startAButton.Click += new System.EventHandler(this.startAButton_Click);
            // 
            // startBButton
            // 
            this.startBButton.Location = new System.Drawing.Point(123, 56);
            this.startBButton.Name = "startBButton";
            this.startBButton.Size = new System.Drawing.Size(100, 23);
            this.startBButton.TabIndex = 4;
            this.startBButton.Text = "Start B";
            this.startBButton.UseVisualStyleBackColor = true;
            this.startBButton.Click += new System.EventHandler(this.startBButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(16, 87);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(207, 71);
            this.statusTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 170);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.startBButton);
            this.Controls.Add(this.startAButton);
            this.Controls.Add(this.counterBTextbox);
            this.Controls.Add(this.counterATextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Thread Test - BackgroundWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox counterATextbox;
        private System.Windows.Forms.TextBox counterBTextbox;
        private System.Windows.Forms.Button startAButton;
        private System.Windows.Forms.Button startBButton;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}

