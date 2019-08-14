namespace ChatRoomServer
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
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(41, 466);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortTextBox.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 492);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(93, 492);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(11, 11);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(531, 446);
            this.DisplayTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 527);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PortTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox DisplayTextBox;
    }
}

