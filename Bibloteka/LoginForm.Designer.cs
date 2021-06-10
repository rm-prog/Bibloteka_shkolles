
namespace Bibloteka
{
    partial class LoginForm
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
            this.uname_input = new System.Windows.Forms.TextBox();
            this.Fjalekalimi = new System.Windows.Forms.Label();
            this.pword_input = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulari i Kyçjes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emri i perdoruesit";
            // 
            // uname_input
            // 
            this.uname_input.Location = new System.Drawing.Point(166, 111);
            this.uname_input.Name = "uname_input";
            this.uname_input.Size = new System.Drawing.Size(110, 20);
            this.uname_input.TabIndex = 2;
            // 
            // Fjalekalimi
            // 
            this.Fjalekalimi.AutoSize = true;
            this.Fjalekalimi.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fjalekalimi.Location = new System.Drawing.Point(12, 180);
            this.Fjalekalimi.Name = "Fjalekalimi";
            this.Fjalekalimi.Size = new System.Drawing.Size(77, 18);
            this.Fjalekalimi.TabIndex = 3;
            this.Fjalekalimi.Text = "Fjalekalimi";
            // 
            // pword_input
            // 
            this.pword_input.Location = new System.Drawing.Point(165, 178);
            this.pword_input.Name = "pword_input";
            this.pword_input.Size = new System.Drawing.Size(111, 20);
            this.pword_input.TabIndex = 4;
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(114, 250);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(94, 32);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Kyçu";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 365);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pword_input);
            this.Controls.Add(this.Fjalekalimi);
            this.Controls.Add(this.uname_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uname_input;
        private System.Windows.Forms.Label Fjalekalimi;
        private System.Windows.Forms.TextBox pword_input;
        private System.Windows.Forms.Button login_button;
    }
}