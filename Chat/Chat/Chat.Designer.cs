
namespace Chat
{
    partial class Chat
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
            this.label2 = new System.Windows.Forms.Label();
            this.SeverIP_textBox = new System.Windows.Forms.TextBox();
            this.SeverPort_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientPort_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientIP_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Connect_button = new System.Windows.Forms.Button();
            this.Chat_textBox = new System.Windows.Forms.TextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.ChatScreen_textBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sever";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // SeverIP_textBox
            // 
            this.SeverIP_textBox.Location = new System.Drawing.Point(99, 12);
            this.SeverIP_textBox.Name = "SeverIP_textBox";
            this.SeverIP_textBox.Size = new System.Drawing.Size(138, 20);
            this.SeverIP_textBox.TabIndex = 2;
            // 
            // SeverPort_textBox
            // 
            this.SeverPort_textBox.Location = new System.Drawing.Point(281, 12);
            this.SeverPort_textBox.Name = "SeverPort_textBox";
            this.SeverPort_textBox.Size = new System.Drawing.Size(138, 20);
            this.SeverPort_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            // 
            // ClientPort_textBox
            // 
            this.ClientPort_textBox.Location = new System.Drawing.Point(281, 44);
            this.ClientPort_textBox.Name = "ClientPort_textBox";
            this.ClientPort_textBox.Size = new System.Drawing.Size(138, 20);
            this.ClientPort_textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port";
            // 
            // ClientIP_textBox
            // 
            this.ClientIP_textBox.Location = new System.Drawing.Point(99, 44);
            this.ClientIP_textBox.Name = "ClientIP_textBox";
            this.ClientIP_textBox.Size = new System.Drawing.Size(138, 20);
            this.ClientIP_textBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Client";
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(425, 12);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 23);
            this.Start_button.TabIndex = 10;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(425, 42);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(75, 23);
            this.Connect_button.TabIndex = 11;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // Chat_textBox
            // 
            this.Chat_textBox.Location = new System.Drawing.Point(13, 352);
            this.Chat_textBox.Multiline = true;
            this.Chat_textBox.Name = "Chat_textBox";
            this.Chat_textBox.Size = new System.Drawing.Size(422, 51);
            this.Chat_textBox.TabIndex = 13;
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(441, 352);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(59, 51);
            this.Send_button.TabIndex = 14;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // ChatScreen_textBox
            // 
            this.ChatScreen_textBox.Location = new System.Drawing.Point(12, 67);
            this.ChatScreen_textBox.Multiline = true;
            this.ChatScreen_textBox.Name = "ChatScreen_textBox";
            this.ChatScreen_textBox.Size = new System.Drawing.Size(488, 279);
            this.ChatScreen_textBox.TabIndex = 15;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChatScreen_textBox);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.Chat_textBox);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.ClientPort_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientIP_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SeverPort_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SeverIP_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SeverIP_textBox;
        private System.Windows.Forms.TextBox SeverPort_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientPort_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientIP_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.TextBox Chat_textBox;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.TextBox ChatScreen_textBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

