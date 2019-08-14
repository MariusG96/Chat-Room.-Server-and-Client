namespace ChatRoomClient
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
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.IpaddressTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 376);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(760, 20);
            this.MessageTextBox.TabIndex = 0;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(12, 118);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(760, 253);
            this.DisplayTextBox.TabIndex = 6;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(121, 44);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Connect";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 402);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(84, 29);
            this.SendButton.TabIndex = 10;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(139, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(121, 44);
            this.StopButton.TabIndex = 11;
            this.StopButton.Text = "Disconnect";
            this.StopButton.UseVisualStyleBackColor = true;
            //            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // IpaddressTextBox
            // 
            this.IpaddressTextBox.Location = new System.Drawing.Point(15, 92);
            this.IpaddressTextBox.Name = "IpaddressTextBox";
            this.IpaddressTextBox.Size = new System.Drawing.Size(89, 20);
            this.IpaddressTextBox.TabIndex = 12;
            this.IpaddressTextBox.Text = "192.168.0.6";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(110, 92);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(46, 20);
            this.PortTextBox.TabIndex = 13;
            this.PortTextBox.Text = "5555";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(162, 92);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 20);
            this.NameBox.TabIndex = 14;
            this.NameBox.Text = "Goblin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ip Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nick Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IpaddressTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox IpaddressTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

