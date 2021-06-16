
namespace Bibloteka
{
    partial class AddBookForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titulli_label = new System.Windows.Forms.TextBox();
            this.autori_label = new System.Windows.Forms.TextBox();
            this.zhaneri_label = new System.Windows.Forms.TextBox();
            this.faqe_numeric = new System.Windows.Forms.NumericUpDown();
            this.addLiberBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faqe_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pershendetje Admin!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shtoni nje Liber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Faqe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zhaneri";
            // 
            // titulli_label
            // 
            this.titulli_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulli_label.Location = new System.Drawing.Point(126, 140);
            this.titulli_label.Name = "titulli_label";
            this.titulli_label.Size = new System.Drawing.Size(136, 22);
            this.titulli_label.TabIndex = 7;
            // 
            // autori_label
            // 
            this.autori_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autori_label.Location = new System.Drawing.Point(126, 183);
            this.autori_label.Name = "autori_label";
            this.autori_label.Size = new System.Drawing.Size(136, 22);
            this.autori_label.TabIndex = 8;
            // 
            // zhaneri_label
            // 
            this.zhaneri_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zhaneri_label.Location = new System.Drawing.Point(126, 296);
            this.zhaneri_label.Name = "zhaneri_label";
            this.zhaneri_label.Size = new System.Drawing.Size(136, 22);
            this.zhaneri_label.TabIndex = 10;
            // 
            // faqe_numeric
            // 
            this.faqe_numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faqe_numeric.Location = new System.Drawing.Point(126, 241);
            this.faqe_numeric.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.faqe_numeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.faqe_numeric.Name = "faqe_numeric";
            this.faqe_numeric.Size = new System.Drawing.Size(58, 24);
            this.faqe_numeric.TabIndex = 11;
            this.faqe_numeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // addLiberBtn
            // 
            this.addLiberBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLiberBtn.Location = new System.Drawing.Point(140, 334);
            this.addLiberBtn.Name = "addLiberBtn";
            this.addLiberBtn.Size = new System.Drawing.Size(86, 37);
            this.addLiberBtn.TabIndex = 12;
            this.addLiberBtn.Text = "Shto";
            this.addLiberBtn.UseVisualStyleBackColor = true;
            this.addLiberBtn.Click += new System.EventHandler(this.addLiberBtn_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 383);
            this.Controls.Add(this.addLiberBtn);
            this.Controls.Add(this.faqe_numeric);
            this.Controls.Add(this.zhaneri_label);
            this.Controls.Add(this.autori_label);
            this.Controls.Add(this.titulli_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.faqe_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titulli_label;
        private System.Windows.Forms.TextBox autori_label;
        private System.Windows.Forms.TextBox zhaneri_label;
        private System.Windows.Forms.NumericUpDown faqe_numeric;
        private System.Windows.Forms.Button addLiberBtn;
    }
}