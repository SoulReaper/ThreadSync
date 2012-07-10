namespace ThreadSync
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.counterBTextbox = new System.Windows.Forms.TextBox();
            this.counterAStartButton = new System.Windows.Forms.Button();
            this.counterBStartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calling the control\'s invoke method.";
            // 
            // counterATextbox
            // 
            this.counterATextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterATextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.counterATextbox.Location = new System.Drawing.Point(48, 53);
            this.counterATextbox.Multiline = true;
            this.counterATextbox.Name = "counterATextbox";
            this.counterATextbox.ReadOnly = true;
            this.counterATextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.counterATextbox.ShortcutsEnabled = false;
            this.counterATextbox.Size = new System.Drawing.Size(51, 116);
            this.counterATextbox.TabIndex = 1;
            this.counterATextbox.TabStop = false;
            this.counterATextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.counterATextbox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Counter A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Counter B";
            // 
            // counterBTextbox
            // 
            this.counterBTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterBTextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.counterBTextbox.Location = new System.Drawing.Point(155, 53);
            this.counterBTextbox.Multiline = true;
            this.counterBTextbox.Name = "counterBTextbox";
            this.counterBTextbox.ReadOnly = true;
            this.counterBTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.counterBTextbox.ShortcutsEnabled = false;
            this.counterBTextbox.Size = new System.Drawing.Size(51, 116);
            this.counterBTextbox.TabIndex = 4;
            this.counterBTextbox.TabStop = false;
            this.counterBTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.counterBTextbox.WordWrap = false;
            // 
            // counterAStartButton
            // 
            this.counterAStartButton.Location = new System.Drawing.Point(48, 176);
            this.counterAStartButton.Name = "counterAStartButton";
            this.counterAStartButton.Size = new System.Drawing.Size(51, 23);
            this.counterAStartButton.TabIndex = 5;
            this.counterAStartButton.Text = "Start";
            this.counterAStartButton.UseVisualStyleBackColor = true;
            this.counterAStartButton.Click += new System.EventHandler(this.counterAStartButton_Click);
            // 
            // counterBStartButton
            // 
            this.counterBStartButton.Location = new System.Drawing.Point(155, 175);
            this.counterBStartButton.Name = "counterBStartButton";
            this.counterBStartButton.Size = new System.Drawing.Size(51, 23);
            this.counterBStartButton.TabIndex = 6;
            this.counterBStartButton.Text = "Start";
            this.counterBStartButton.UseVisualStyleBackColor = true;
            this.counterBStartButton.Click += new System.EventHandler(this.counterBStartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(48, 215);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(158, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(248, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.counterBStartButton);
            this.Controls.Add(this.counterAStartButton);
            this.Controls.Add(this.counterBTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.counterATextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Thread Tester - Call Control\'s Invoke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox counterATextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox counterBTextbox;
        private System.Windows.Forms.Button counterAStartButton;
        private System.Windows.Forms.Button counterBStartButton;
        private System.Windows.Forms.Button exitButton;
    }
}

