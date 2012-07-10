namespace SynchroContext
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
            this.StartAButton = new System.Windows.Forms.Button();
            this.StartBButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update control on UI thread using SynchronizationContext";
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
            this.counterBTextbox.Location = new System.Drawing.Point(178, 29);
            this.counterBTextbox.Name = "counterBTextbox";
            this.counterBTextbox.ReadOnly = true;
            this.counterBTextbox.Size = new System.Drawing.Size(100, 20);
            this.counterBTextbox.TabIndex = 2;
            this.counterBTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartAButton
            // 
            this.StartAButton.Location = new System.Drawing.Point(16, 57);
            this.StartAButton.Name = "StartAButton";
            this.StartAButton.Size = new System.Drawing.Size(100, 23);
            this.StartAButton.TabIndex = 3;
            this.StartAButton.Text = "Start A";
            this.StartAButton.UseVisualStyleBackColor = true;
            this.StartAButton.Click += new System.EventHandler(this.StartAButton_Click);
            // 
            // StartBButton
            // 
            this.StartBButton.Location = new System.Drawing.Point(178, 56);
            this.StartBButton.Name = "StartBButton";
            this.StartBButton.Size = new System.Drawing.Size(100, 23);
            this.StartBButton.TabIndex = 4;
            this.StartBButton.Text = "Start B";
            this.StartBButton.UseVisualStyleBackColor = true;
            this.StartBButton.Click += new System.EventHandler(this.StartBButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 99);
            this.Controls.Add(this.StartBButton);
            this.Controls.Add(this.StartAButton);
            this.Controls.Add(this.counterBTextbox);
            this.Controls.Add(this.counterATextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Thread Tester - SynchronizationContext";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox counterATextbox;
        private System.Windows.Forms.TextBox counterBTextbox;
        private System.Windows.Forms.Button StartAButton;
        private System.Windows.Forms.Button StartBButton;
    }
}

