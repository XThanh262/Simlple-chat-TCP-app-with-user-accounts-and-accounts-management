
namespace Chat
{
    partial class QuanLytaikhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TKtextBox = new System.Windows.Forms.TextBox();
            this.MKtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mailtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Timkiem_button = new System.Windows.Forms.Button();
            this.Them_button = new System.Windows.Forms.Button();
            this.Xoa_button = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.QHcomboBox = new System.Windows.Forms.ComboBox();
            this.QHbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin các tài khoản";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(7, 20);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(515, 220);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // TKtextBox
            // 
            this.TKtextBox.Location = new System.Drawing.Point(82, 273);
            this.TKtextBox.Name = "TKtextBox";
            this.TKtextBox.Size = new System.Drawing.Size(140, 20);
            this.TKtextBox.TabIndex = 2;
            // 
            // MKtextBox
            // 
            this.MKtextBox.Location = new System.Drawing.Point(286, 273);
            this.MKtextBox.Name = "MKtextBox";
            this.MKtextBox.Size = new System.Drawing.Size(122, 20);
            this.MKtextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // mailtextBox
            // 
            this.mailtextBox.Location = new System.Drawing.Point(82, 299);
            this.mailtextBox.Name = "mailtextBox";
            this.mailtextBox.Size = new System.Drawing.Size(326, 20);
            this.mailtextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // Timkiem_button
            // 
            this.Timkiem_button.Location = new System.Drawing.Point(414, 273);
            this.Timkiem_button.Name = "Timkiem_button";
            this.Timkiem_button.Size = new System.Drawing.Size(121, 46);
            this.Timkiem_button.TabIndex = 7;
            this.Timkiem_button.Text = "Tìm kiếm";
            this.Timkiem_button.UseVisualStyleBackColor = true;
            this.Timkiem_button.Click += new System.EventHandler(this.Timkiem_button_Click);
            // 
            // Them_button
            // 
            this.Them_button.Location = new System.Drawing.Point(20, 375);
            this.Them_button.Name = "Them_button";
            this.Them_button.Size = new System.Drawing.Size(121, 37);
            this.Them_button.TabIndex = 8;
            this.Them_button.Text = "Thêm tài khoản";
            this.Them_button.UseVisualStyleBackColor = true;
            this.Them_button.Click += new System.EventHandler(this.Them_button_Click);
            // 
            // Xoa_button
            // 
            this.Xoa_button.Location = new System.Drawing.Point(414, 375);
            this.Xoa_button.Name = "Xoa_button";
            this.Xoa_button.Size = new System.Drawing.Size(121, 37);
            this.Xoa_button.TabIndex = 9;
            this.Xoa_button.Text = "Xóa tài khoản";
            this.Xoa_button.UseVisualStyleBackColor = true;
            this.Xoa_button.Click += new System.EventHandler(this.Xoa_button_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(209, 375);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(121, 37);
            this.Resetbutton.TabIndex = 10;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quyền hạn:";
            // 
            // QHcomboBox
            // 
            this.QHcomboBox.FormattingEnabled = true;
            this.QHcomboBox.Items.AddRange(new object[] {
            "Admin",
            "Nguoidung"});
            this.QHcomboBox.Location = new System.Drawing.Point(90, 333);
            this.QHcomboBox.Name = "QHcomboBox";
            this.QHcomboBox.Size = new System.Drawing.Size(121, 21);
            this.QHcomboBox.TabIndex = 12;
            // 
            // QHbutton
            // 
            this.QHbutton.Location = new System.Drawing.Point(218, 330);
            this.QHbutton.Name = "QHbutton";
            this.QHbutton.Size = new System.Drawing.Size(75, 23);
            this.QHbutton.TabIndex = 13;
            this.QHbutton.Text = "Đặt quyền";
            this.QHbutton.UseVisualStyleBackColor = true;
            this.QHbutton.Click += new System.EventHandler(this.QHbutton_Click);
            // 
            // QuanLytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.QHbutton);
            this.Controls.Add(this.QHcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Xoa_button);
            this.Controls.Add(this.Them_button);
            this.Controls.Add(this.Timkiem_button);
            this.Controls.Add(this.mailtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MKtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TKtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLytaikhoan";
            this.Text = "QuanLytaikhoan";
            this.Load += new System.EventHandler(this.QuanLytaikhoan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TKtextBox;
        private System.Windows.Forms.TextBox MKtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Timkiem_button;
        private System.Windows.Forms.Button Them_button;
        private System.Windows.Forms.Button Xoa_button;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox QHcomboBox;
        private System.Windows.Forms.Button QHbutton;
    }
}