
namespace WindowsFormsApp2
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
            this.tns = new System.Windows.Forms.TextBox();
            this.tkq = new System.Windows.Forms.ListBox();
            this.tsc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số";
            // 
            // tns
            // 
            this.tns.Location = new System.Drawing.Point(199, 22);
            this.tns.Name = "tns";
            this.tns.Size = new System.Drawing.Size(100, 20);
            this.tns.TabIndex = 1;
            // 
            // tkq
            // 
            this.tkq.FormattingEnabled = true;
            this.tkq.Location = new System.Drawing.Point(125, 87);
            this.tkq.Name = "tkq";
            this.tkq.Size = new System.Drawing.Size(120, 95);
            this.tkq.TabIndex = 2;
            this.tkq.SelectedIndexChanged += new System.EventHandler(this.tkq_SelectedIndexChanged);
            // 
            // tsc
            // 
            this.tsc.Location = new System.Drawing.Point(303, 87);
            this.tsc.Name = "tsc";
            this.tsc.Size = new System.Drawing.Size(100, 20);
            this.tsc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng các số chẵn trong dãy số nguyên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "dãy số nguyên tố";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "keets qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsc);
            this.Controls.Add(this.tkq);
            this.Controls.Add(this.tns);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tns;
        private System.Windows.Forms.ListBox tkq;
        private System.Windows.Forms.TextBox tsc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

