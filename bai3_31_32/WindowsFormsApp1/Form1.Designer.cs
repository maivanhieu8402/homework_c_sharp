
namespace WindowsFormsApp1
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
            this.sx = new System.Windows.Forms.Button();
            this.scxc = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.tst1 = new System.Windows.Forms.TextBox();
            this.tst2 = new System.Windows.Forms.TextBox();
            this.tkq = new System.Windows.Forms.TextBox();
            this.butto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sx
            // 
            this.sx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sx.Location = new System.Drawing.Point(139, 158);
            this.sx.Name = "sx";
            this.sx.Size = new System.Drawing.Size(75, 23);
            this.sx.TabIndex = 0;
            this.sx.Text = "Cộng";
            this.sx.UseVisualStyleBackColor = true;
            this.sx.Click += new System.EventHandler(this.button1_Click);
            // 
            // scxc
            // 
            this.scxc.AutoSize = true;
            this.scxc.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scxc.Location = new System.Drawing.Point(17, 52);
            this.scxc.Name = "scxc";
            this.scxc.Size = new System.Drawing.Size(102, 19);
            this.scxc.TabIndex = 1;
            this.scxc.Text = "Số Thứ Nhất";
            this.scxc.Click += new System.EventHandler(this.label1_Click);
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Location = new System.Drawing.Point(17, 95);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(89, 19);
            this.day.TabIndex = 2;
            this.day.Text = "Số Thứ Hai";
            // 
            // tst1
            // 
            this.tst1.Location = new System.Drawing.Point(139, 52);
            this.tst1.Multiline = true;
            this.tst1.Name = "tst1";
            this.tst1.Size = new System.Drawing.Size(208, 30);
            this.tst1.TabIndex = 3;
            this.tst1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tst2
            // 
            this.tst2.Location = new System.Drawing.Point(139, 95);
            this.tst2.Multiline = true;
            this.tst2.Name = "tst2";
            this.tst2.Size = new System.Drawing.Size(208, 32);
            this.tst2.TabIndex = 4;
            // 
            // tkq
            // 
            this.tkq.Location = new System.Drawing.Point(139, 273);
            this.tkq.Multiline = true;
            this.tkq.Name = "tkq";
            this.tkq.Size = new System.Drawing.Size(208, 33);
            this.tkq.TabIndex = 6;
            // 
            // butto
            // 
            this.butto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butto.Location = new System.Drawing.Point(243, 202);
            this.butto.Name = "butto";
            this.butto.Size = new System.Drawing.Size(104, 23);
            this.butto.TabIndex = 8;
            this.butto.Text = "Đóng";
            this.butto.UseVisualStyleBackColor = true;
            this.butto.Click += new System.EventHandler(this.butto_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Trừ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Nhân";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(31, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Chia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(21, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Kết Quả";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(243, 158);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Nhập mới";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Máy Tính Của Hiếu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(359, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butto);
            this.Controls.Add(this.tkq);
            this.Controls.Add(this.tst2);
            this.Controls.Add(this.tst1);
            this.Controls.Add(this.day);
            this.Controls.Add(this.scxc);
            this.Controls.Add(this.sx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sx;
        private System.Windows.Forms.Label scxc;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.TextBox tst1;
        private System.Windows.Forms.TextBox tst2;
        private System.Windows.Forms.TextBox tkq;
        private System.Windows.Forms.Button butto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

