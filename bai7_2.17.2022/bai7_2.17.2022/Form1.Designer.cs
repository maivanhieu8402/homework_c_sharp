
namespace bai7_2._17._2022
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
            this.nguoiban = new System.Windows.Forms.TextBox();
            this.ngayban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cthit = new System.Windows.Forms.CheckBox();
            this.cca = new System.Windows.Forms.CheckBox();
            this.crx = new System.Windows.Forms.CheckBox();
            this.ccc = new System.Windows.Forms.CheckBox();
            this.cb = new System.Windows.Forms.CheckBox();
            this.cnk = new System.Windows.Forms.CheckBox();
            this.thit = new System.Windows.Forms.TextBox();
            this.ca = new System.Windows.Forms.TextBox();
            this.rauxanh = new System.Windows.Forms.TextBox();
            this.coca = new System.Windows.Forms.TextBox();
            this.bia = new System.Windows.Forms.TextBox();
            this.nuockhoang = new System.Windows.Forms.TextBox();
            this.rtt = new System.Windows.Forms.RadioButton();
            this.rt = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tinhtien = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tienkhachtra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bán";
            // 
            // nguoiban
            // 
            this.nguoiban.Location = new System.Drawing.Point(105, 56);
            this.nguoiban.Name = "nguoiban";
            this.nguoiban.Size = new System.Drawing.Size(100, 20);
            this.nguoiban.TabIndex = 2;
            this.nguoiban.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ngayban
            // 
            this.ngayban.Location = new System.Drawing.Point(105, 87);
            this.ngayban.Name = "ngayban";
            this.ngayban.Size = new System.Drawing.Size(100, 20);
            this.ngayban.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mặt Hàng";
            // 
            // cthit
            // 
            this.cthit.AutoSize = true;
            this.cthit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cthit.Location = new System.Drawing.Point(68, 171);
            this.cthit.Name = "cthit";
            this.cthit.Size = new System.Drawing.Size(48, 17);
            this.cthit.TabIndex = 5;
            this.cthit.Text = "Thịt";
            this.cthit.UseVisualStyleBackColor = true;
            this.cthit.CheckedChanged += new System.EventHandler(this.cthit_CheckedChanged);
            // 
            // cca
            // 
            this.cca.AutoSize = true;
            this.cca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cca.Location = new System.Drawing.Point(68, 195);
            this.cca.Name = "cca";
            this.cca.Size = new System.Drawing.Size(41, 17);
            this.cca.TabIndex = 6;
            this.cca.Text = "Cá";
            this.cca.UseVisualStyleBackColor = true;
            this.cca.CheckedChanged += new System.EventHandler(this.cca_CheckedChanged);
            // 
            // crx
            // 
            this.crx.AutoSize = true;
            this.crx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crx.Location = new System.Drawing.Point(68, 219);
            this.crx.Name = "crx";
            this.crx.Size = new System.Drawing.Size(82, 17);
            this.crx.TabIndex = 7;
            this.crx.Text = "Rau Xanh";
            this.crx.UseVisualStyleBackColor = true;
            this.crx.CheckedChanged += new System.EventHandler(this.crx_CheckedChanged);
            // 
            // ccc
            // 
            this.ccc.AutoSize = true;
            this.ccc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccc.Location = new System.Drawing.Point(68, 243);
            this.ccc.Name = "ccc";
            this.ccc.Size = new System.Drawing.Size(79, 17);
            this.ccc.TabIndex = 8;
            this.ccc.Text = "Cocacola";
            this.ccc.UseVisualStyleBackColor = true;
            this.ccc.CheckedChanged += new System.EventHandler(this.ccc_CheckedChanged);
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.Location = new System.Drawing.Point(68, 267);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(44, 17);
            this.cb.TabIndex = 9;
            this.cb.Text = "Bia";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cnk
            // 
            this.cnk.AutoSize = true;
            this.cnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnk.Location = new System.Drawing.Point(68, 291);
            this.cnk.Name = "cnk";
            this.cnk.Size = new System.Drawing.Size(103, 17);
            this.cnk.TabIndex = 10;
            this.cnk.Text = "Nước Khoáng";
            this.cnk.UseVisualStyleBackColor = true;
            // 
            // thit
            // 
            this.thit.Location = new System.Drawing.Point(197, 162);
            this.thit.Name = "thit";
            this.thit.Size = new System.Drawing.Size(36, 20);
            this.thit.TabIndex = 11;
            // 
            // ca
            // 
            this.ca.Location = new System.Drawing.Point(197, 188);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(36, 20);
            this.ca.TabIndex = 12;
            // 
            // rauxanh
            // 
            this.rauxanh.Location = new System.Drawing.Point(197, 214);
            this.rauxanh.Name = "rauxanh";
            this.rauxanh.Size = new System.Drawing.Size(36, 20);
            this.rauxanh.TabIndex = 13;
            // 
            // coca
            // 
            this.coca.Location = new System.Drawing.Point(197, 240);
            this.coca.Name = "coca";
            this.coca.Size = new System.Drawing.Size(36, 20);
            this.coca.TabIndex = 14;
            // 
            // bia
            // 
            this.bia.Location = new System.Drawing.Point(197, 266);
            this.bia.Name = "bia";
            this.bia.Size = new System.Drawing.Size(36, 20);
            this.bia.TabIndex = 15;
            // 
            // nuockhoang
            // 
            this.nuockhoang.Location = new System.Drawing.Point(197, 292);
            this.nuockhoang.Name = "nuockhoang";
            this.nuockhoang.Size = new System.Drawing.Size(36, 20);
            this.nuockhoang.TabIndex = 16;
            this.nuockhoang.TextChanged += new System.EventHandler(this.nuockhoang_TextChanged);
            // 
            // rtt
            // 
            this.rtt.AutoSize = true;
            this.rtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtt.Location = new System.Drawing.Point(68, 346);
            this.rtt.Name = "rtt";
            this.rtt.Size = new System.Drawing.Size(161, 17);
            this.rtt.TabIndex = 17;
            this.rtt.TabStop = true;
            this.rtt.Text = "Khách Hàng Thân Thiết";
            this.rtt.UseVisualStyleBackColor = true;
            // 
            // rt
            // 
            this.rt.AutoSize = true;
            this.rt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt.Location = new System.Drawing.Point(68, 370);
            this.rt.Name = "rt";
            this.rt.Size = new System.Drawing.Size(142, 17);
            this.rt.TabIndex = 18;
            this.rt.TabStop = true;
            this.rt.Text = "Khách Hàng Thường";
            this.rt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Loại Khách Hàng";
            // 
            // tinhtien
            // 
            this.tinhtien.FormattingEnabled = true;
            this.tinhtien.Location = new System.Drawing.Point(351, 56);
            this.tinhtien.Name = "tinhtien";
            this.tinhtien.Size = new System.Drawing.Size(384, 342);
            this.tinhtien.TabIndex = 20;
            this.tinhtien.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(270, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tính Tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(197, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 37);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hóa Đơn Bán Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "tiền Khách trả";
            // 
            // tienkhachtra
            // 
            this.tienkhachtra.Location = new System.Drawing.Point(134, 404);
            this.tienkhachtra.Name = "tienkhachtra";
            this.tienkhachtra.Size = new System.Drawing.Size(100, 20);
            this.tienkhachtra.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(270, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(270, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lll
            // 
            this.lll.AutoSize = true;
            this.lll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lll.Location = new System.Drawing.Point(183, 140);
            this.lll.Name = "lll";
            this.lll.Size = new System.Drawing.Size(61, 13);
            this.lll.TabIndex = 27;
            this.lll.Text = "Số Lượng";
            this.lll.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lll);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tienkhachtra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tinhtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rt);
            this.Controls.Add(this.rtt);
            this.Controls.Add(this.nuockhoang);
            this.Controls.Add(this.bia);
            this.Controls.Add(this.coca);
            this.Controls.Add(this.rauxanh);
            this.Controls.Add(this.ca);
            this.Controls.Add(this.thit);
            this.Controls.Add(this.cnk);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.ccc);
            this.Controls.Add(this.crx);
            this.Controls.Add(this.cca);
            this.Controls.Add(this.cthit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ngayban);
            this.Controls.Add(this.nguoiban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nguoiban;
        private System.Windows.Forms.TextBox ngayban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cthit;
        private System.Windows.Forms.CheckBox cca;
        private System.Windows.Forms.CheckBox crx;
        private System.Windows.Forms.CheckBox ccc;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.CheckBox cnk;
        private System.Windows.Forms.TextBox thit;
        private System.Windows.Forms.TextBox ca;
        private System.Windows.Forms.TextBox rauxanh;
        private System.Windows.Forms.TextBox coca;
        private System.Windows.Forms.TextBox bia;
        private System.Windows.Forms.TextBox nuockhoang;
        private System.Windows.Forms.RadioButton rtt;
        private System.Windows.Forms.RadioButton rt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox tinhtien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tienkhachtra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lll;
    }
}

