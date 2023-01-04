namespace Ürün_KDV_Hesaplama_Aracı
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKDVliFiyat = new System.Windows.Forms.TextBox();
            this.txtKDVsizFiyat = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKDVOran = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "KDVHESAPLAMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "KDV li Ürün Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "KDV Oranı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "KDV Tutarı:";
            // 
            // txtKDVliFiyat
            // 
            this.txtKDVliFiyat.Location = new System.Drawing.Point(136, 95);
            this.txtKDVliFiyat.Name = "txtKDVliFiyat";
            this.txtKDVliFiyat.Size = new System.Drawing.Size(117, 22);
            this.txtKDVliFiyat.TabIndex = 5;
            // 
            // txtKDVsizFiyat
            // 
            this.txtKDVsizFiyat.Enabled = false;
            this.txtKDVsizFiyat.Location = new System.Drawing.Point(136, 162);
            this.txtKDVsizFiyat.Name = "txtKDVsizFiyat";
            this.txtKDVsizFiyat.Size = new System.Drawing.Size(117, 22);
            this.txtKDVsizFiyat.TabIndex = 7;
            // 
            // txtKDV
            // 
            this.txtKDV.Enabled = false;
            this.txtKDV.Location = new System.Drawing.Point(136, 199);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(117, 22);
            this.txtKDV.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "KDVsiz Fiyat:";
            // 
            // txtKDVOran
            // 
            this.txtKDVOran.Location = new System.Drawing.Point(136, 123);
            this.txtKDVOran.Name = "txtKDVOran";
            this.txtKDVOran.Size = new System.Drawing.Size(117, 22);
            this.txtKDVOran.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(283, 329);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.txtKDVsizFiyat);
            this.Controls.Add(this.txtKDVOran);
            this.Controls.Add(this.txtKDVliFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKDVliFiyat;
        private System.Windows.Forms.TextBox txtKDVsizFiyat;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKDVOran;
    }
}

