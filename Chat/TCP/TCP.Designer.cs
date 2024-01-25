
namespace TCP
{
    partial class TCPClient
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
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.Chattextbox = new System.Windows.Forms.TextBox();
            this.TNtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.Guibutton = new System.Windows.Forms.Button();
            this.Onlinelistbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rfbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sever:";
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(183, 28);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(362, 20);
            this.IPtextbox.TabIndex = 1;
            this.IPtextbox.Text = "192.168.1.4:1200";
            // 
            // Chattextbox
            // 
            this.Chattextbox.Location = new System.Drawing.Point(183, 54);
            this.Chattextbox.Multiline = true;
            this.Chattextbox.Name = "Chattextbox";
            this.Chattextbox.ReadOnly = true;
            this.Chattextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Chattextbox.Size = new System.Drawing.Size(362, 366);
            this.Chattextbox.TabIndex = 2;
            // 
            // TNtextbox
            // 
            this.TNtextbox.Location = new System.Drawing.Point(183, 448);
            this.TNtextbox.Multiline = true;
            this.TNtextbox.Name = "TNtextbox";
            this.TNtextbox.Size = new System.Drawing.Size(362, 31);
            this.TNtextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tin nhắn:";
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(470, 485);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(75, 23);
            this.Connectbutton.TabIndex = 5;
            this.Connectbutton.Text = "Kết nối";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // Guibutton
            // 
            this.Guibutton.Location = new System.Drawing.Point(389, 485);
            this.Guibutton.Name = "Guibutton";
            this.Guibutton.Size = new System.Drawing.Size(75, 23);
            this.Guibutton.TabIndex = 6;
            this.Guibutton.Text = "Gửi";
            this.Guibutton.UseVisualStyleBackColor = true;
            this.Guibutton.Click += new System.EventHandler(this.Guibutton_Click);
            // 
            // Onlinelistbox
            // 
            this.Onlinelistbox.FormattingEnabled = true;
            this.Onlinelistbox.Location = new System.Drawing.Point(12, 28);
            this.Onlinelistbox.Name = "Onlinelistbox";
            this.Onlinelistbox.Size = new System.Drawing.Size(165, 368);
            this.Onlinelistbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Online";
            // 
            // Rfbutton
            // 
            this.Rfbutton.Location = new System.Drawing.Point(12, 485);
            this.Rfbutton.Name = "Rfbutton";
            this.Rfbutton.Size = new System.Drawing.Size(75, 23);
            this.Rfbutton.TabIndex = 9;
            this.Rfbutton.Text = "Refresh";
            this.Rfbutton.UseVisualStyleBackColor = true;
            this.Rfbutton.Click += new System.EventHandler(this.Rfbutton_Click);
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 516);
            this.Controls.Add(this.Rfbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Onlinelistbox);
            this.Controls.Add(this.Guibutton);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.TNtextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chattextbox);
            this.Controls.Add(this.IPtextbox);
            this.Controls.Add(this.label1);
            this.Name = "TCPClient";
            this.Text = "TCP/IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPtextbox;
        private System.Windows.Forms.TextBox Chattextbox;
        private System.Windows.Forms.TextBox TNtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Button Guibutton;
        private System.Windows.Forms.ListBox Onlinelistbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Rfbutton;
    }
}

