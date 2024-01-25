
namespace Chat
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
            this.label2 = new System.Windows.Forms.Label();
            this.TKtextBox = new System.Windows.Forms.TextBox();
            this.MKextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DNbutton = new System.Windows.Forms.Button();
            this.DKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẮN TIN BẢO MẬT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // TKtextBox
            // 
            this.TKtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TKtextBox.Location = new System.Drawing.Point(16, 152);
            this.TKtextBox.Name = "TKtextBox";
            this.TKtextBox.Size = new System.Drawing.Size(303, 26);
            this.TKtextBox.TabIndex = 2;
            // 
            // MKextBox
            // 
            this.MKextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MKextBox.Location = new System.Drawing.Point(15, 218);
            this.MKextBox.Name = "MKextBox";
            this.MKextBox.Size = new System.Drawing.Size(303, 26);
            this.MKextBox.TabIndex = 4;
            this.MKextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // DNbutton
            // 
            this.DNbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNbutton.Location = new System.Drawing.Point(15, 250);
            this.DNbutton.Name = "DNbutton";
            this.DNbutton.Size = new System.Drawing.Size(303, 50);
            this.DNbutton.TabIndex = 5;
            this.DNbutton.Text = "Đăng nhập";
            this.DNbutton.UseVisualStyleBackColor = true;
            this.DNbutton.Click += new System.EventHandler(this.DNbutton_Click);
            // 
            // DKbutton
            // 
            this.DKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DKbutton.Location = new System.Drawing.Point(17, 306);
            this.DKbutton.Name = "DKbutton";
            this.DKbutton.Size = new System.Drawing.Size(301, 30);
            this.DKbutton.TabIndex = 6;
            this.DKbutton.Text = "Đăng ký";
            this.DKbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 367);
            this.Controls.Add(this.DKbutton);
            this.Controls.Add(this.DNbutton);
            this.Controls.Add(this.MKextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TKtextBox);
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
        private System.Windows.Forms.TextBox TKtextBox;
        private System.Windows.Forms.TextBox MKextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DNbutton;
        private System.Windows.Forms.Button DKbutton;
    }
}