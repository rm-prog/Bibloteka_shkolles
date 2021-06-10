
namespace Bibloteka
{
    partial class RegisterForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.lastname_input = new System.Windows.Forms.TextBox();
            this.uname_input = new System.Windows.Forms.TextBox();
            this.pword_input = new System.Windows.Forms.TextBox();
            this.form2_registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulari i Regjistrimit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mbiemer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emri i Perdoruesit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fjalekalim";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(138, 90);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(100, 20);
            this.name_input.TabIndex = 5;
            // 
            // lastname_input
            // 
            this.lastname_input.Location = new System.Drawing.Point(138, 146);
            this.lastname_input.Name = "lastname_input";
            this.lastname_input.Size = new System.Drawing.Size(100, 20);
            this.lastname_input.TabIndex = 6;
            // 
            // uname_input
            // 
            this.uname_input.Location = new System.Drawing.Point(186, 205);
            this.uname_input.Name = "uname_input";
            this.uname_input.Size = new System.Drawing.Size(100, 20);
            this.uname_input.TabIndex = 7;
            // 
            // pword_input
            // 
            this.pword_input.Location = new System.Drawing.Point(138, 266);
            this.pword_input.Name = "pword_input";
            this.pword_input.Size = new System.Drawing.Size(100, 20);
            this.pword_input.TabIndex = 8;
            // 
            // form2_registerBtn
            // 
            this.form2_registerBtn.Location = new System.Drawing.Point(150, 329);
            this.form2_registerBtn.Name = "form2_registerBtn";
            this.form2_registerBtn.Size = new System.Drawing.Size(75, 23);
            this.form2_registerBtn.TabIndex = 9;
            this.form2_registerBtn.Text = "Regjistrohu";
            this.form2_registerBtn.UseVisualStyleBackColor = true;
            this.form2_registerBtn.Click += new System.EventHandler(this.form2_registerBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 403);
            this.Controls.Add(this.form2_registerBtn);
            this.Controls.Add(this.pword_input);
            this.Controls.Add(this.uname_input);
            this.Controls.Add(this.lastname_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox lastname_input;
        private System.Windows.Forms.TextBox uname_input;
        private System.Windows.Forms.TextBox pword_input;
        private System.Windows.Forms.Button form2_registerBtn;
    }
}