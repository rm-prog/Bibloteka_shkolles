
namespace Bibloteka
{
    partial class Bibloteka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bibloteka));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hello_label = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.librat_grid = new System.Windows.Forms.DataGridView();
            this.ID_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULLI_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTORI_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAQE_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZHANERI_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_dorezimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lista_group = new System.Windows.Forms.GroupBox();
            this.adv_search_button = new System.Windows.Forms.Button();
            this.zhaneri_input = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nrFaqe = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.autori_input = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_rezervo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.rezervo_groupBox = new System.Windows.Forms.GroupBox();
            this.rezervo_librinBtn = new System.Windows.Forms.Button();
            this.llogari_gjendje_group = new System.Windows.Forms.GroupBox();
            this.rezervuar_label = new System.Windows.Forms.Label();
            this.liber_gjendje_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librat_grid)).BeginInit();
            this.lista_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrFaqe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_rezervo)).BeginInit();
            this.rezervo_groupBox.SuspendLayout();
            this.llogari_gjendje_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.hello_label);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 70);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(722, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello_label.Location = new System.Drawing.Point(821, 12);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(122, 24);
            this.hello_label.TabIndex = 5;
            this.hello_label.Text = "Pershendetje";
            this.hello_label.Click += new System.EventHandler(this.hello_label_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRegister.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(383, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 50);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Regjistrohu";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(281, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Kyçu";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bibloteka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gjimnazi \"Arben Broci\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 193);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 172);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ne  kete bibloteke do gjeni titujt me te fundit te librave, si dhe libra klasik. " +
    "Regjistrimi dhe marrja e librave jane falas";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(278, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 77);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Kerko Libra";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.Aqua;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(435, 95);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(91, 77);
            this.btnReserve.TabIndex = 3;
            this.btnReserve.Text = "Rezervo Libra";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(634, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 77);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Shto Liber";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // librat_grid
            // 
            this.librat_grid.AllowUserToDeleteRows = false;
            this.librat_grid.AllowUserToResizeColumns = false;
            this.librat_grid.AllowUserToResizeRows = false;
            this.librat_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.librat_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_COLUMN,
            this.TITULLI_COLUMN,
            this.AUTORI_COLUMN,
            this.FAQE_COLUMN,
            this.ZHANERI_COLUMN,
            this.Data_dorezimit});
            this.librat_grid.Location = new System.Drawing.Point(29, 49);
            this.librat_grid.Name = "librat_grid";
            this.librat_grid.ReadOnly = true;
            this.librat_grid.RowHeadersVisible = false;
            this.librat_grid.Size = new System.Drawing.Size(595, 321);
            this.librat_grid.TabIndex = 5;
            // 
            // ID_COLUMN
            // 
            this.ID_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_COLUMN.HeaderText = "ID";
            this.ID_COLUMN.Name = "ID_COLUMN";
            this.ID_COLUMN.ReadOnly = true;
            this.ID_COLUMN.Width = 25;
            // 
            // TITULLI_COLUMN
            // 
            this.TITULLI_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TITULLI_COLUMN.HeaderText = "Titulli";
            this.TITULLI_COLUMN.Name = "TITULLI_COLUMN";
            this.TITULLI_COLUMN.ReadOnly = true;
            this.TITULLI_COLUMN.Width = 140;
            // 
            // AUTORI_COLUMN
            // 
            this.AUTORI_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AUTORI_COLUMN.HeaderText = "Autori";
            this.AUTORI_COLUMN.Name = "AUTORI_COLUMN";
            this.AUTORI_COLUMN.ReadOnly = true;
            this.AUTORI_COLUMN.Width = 130;
            // 
            // FAQE_COLUMN
            // 
            this.FAQE_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FAQE_COLUMN.HeaderText = "Faqe";
            this.FAQE_COLUMN.Name = "FAQE_COLUMN";
            this.FAQE_COLUMN.ReadOnly = true;
            this.FAQE_COLUMN.Width = 66;
            // 
            // ZHANERI_COLUMN
            // 
            this.ZHANERI_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ZHANERI_COLUMN.HeaderText = "Zhaneri";
            this.ZHANERI_COLUMN.Name = "ZHANERI_COLUMN";
            this.ZHANERI_COLUMN.ReadOnly = true;
            // 
            // Data_dorezimit
            // 
            this.Data_dorezimit.HeaderText = "Data e dorezimit";
            this.Data_dorezimit.Name = "Data_dorezimit";
            this.Data_dorezimit.ReadOnly = true;
            this.Data_dorezimit.Width = 125;
            // 
            // lista_group
            // 
            this.lista_group.Controls.Add(this.adv_search_button);
            this.lista_group.Controls.Add(this.zhaneri_input);
            this.lista_group.Controls.Add(this.label6);
            this.lista_group.Controls.Add(this.nrFaqe);
            this.lista_group.Controls.Add(this.label5);
            this.lista_group.Controls.Add(this.autori_input);
            this.lista_group.Controls.Add(this.label4);
            this.lista_group.Controls.Add(this.librat_grid);
            this.lista_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_group.Location = new System.Drawing.Point(204, 206);
            this.lista_group.Name = "lista_group";
            this.lista_group.Size = new System.Drawing.Size(642, 377);
            this.lista_group.TabIndex = 6;
            this.lista_group.TabStop = false;
            this.lista_group.Text = "Librat";
            this.lista_group.Visible = false;
            // 
            // adv_search_button
            // 
            this.adv_search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adv_search_button.BackgroundImage")));
            this.adv_search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adv_search_button.Location = new System.Drawing.Point(15, 23);
            this.adv_search_button.Name = "adv_search_button";
            this.adv_search_button.Size = new System.Drawing.Size(36, 25);
            this.adv_search_button.TabIndex = 0;
            this.adv_search_button.Click += new System.EventHandler(this.adv_search_button_Click_1);
            // 
            // zhaneri_input
            // 
            this.zhaneri_input.FormattingEnabled = true;
            this.zhaneri_input.Items.AddRange(new object[] {
            "Te Gjithe",
            "Parodi",
            "Fantazi",
            "Poezi",
            "Realizem",
            "Tragjedi"});
            this.zhaneri_input.Location = new System.Drawing.Point(501, 16);
            this.zhaneri_input.Name = "zhaneri_input";
            this.zhaneri_input.Size = new System.Drawing.Size(123, 26);
            this.zhaneri_input.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zhaneri";
            // 
            // nrFaqe
            // 
            this.nrFaqe.Location = new System.Drawing.Point(313, 17);
            this.nrFaqe.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nrFaqe.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nrFaqe.Name = "nrFaqe";
            this.nrFaqe.Size = new System.Drawing.Size(103, 24);
            this.nrFaqe.TabIndex = 9;
            this.nrFaqe.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Faqe <";
            // 
            // autori_input
            // 
            this.autori_input.FormattingEnabled = true;
            this.autori_input.Items.AddRange(new object[] {
            "Te Gjithe",
            "Gustav Flobert",
            "J.K. Rowling",
            "Leon Tolstoi",
            "Jeronim de Rada",
            "Gjergj Fishta",
            "Migel Servantes",
            "Volfgang Gete"});
            this.autori_input.Location = new System.Drawing.Point(112, 17);
            this.autori_input.Name = "autori_input";
            this.autori_input.Size = new System.Drawing.Size(121, 26);
            this.autori_input.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Autori";
            // 
            // ID_rezervo
            // 
            this.ID_rezervo.Location = new System.Drawing.Point(38, 94);
            this.ID_rezervo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ID_rezervo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ID_rezervo.Name = "ID_rezervo";
            this.ID_rezervo.Size = new System.Drawing.Size(86, 24);
            this.ID_rezervo.TabIndex = 12;
            this.ID_rezervo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID e Librit qe deshironi";
            // 
            // rezervo_groupBox
            // 
            this.rezervo_groupBox.Controls.Add(this.rezervo_librinBtn);
            this.rezervo_groupBox.Controls.Add(this.label7);
            this.rezervo_groupBox.Controls.Add(this.ID_rezervo);
            this.rezervo_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezervo_groupBox.Location = new System.Drawing.Point(860, 290);
            this.rezervo_groupBox.Name = "rezervo_groupBox";
            this.rezervo_groupBox.Size = new System.Drawing.Size(169, 252);
            this.rezervo_groupBox.TabIndex = 14;
            this.rezervo_groupBox.TabStop = false;
            this.rezervo_groupBox.Text = "Rezervimi i Librit";
            this.rezervo_groupBox.Visible = false;
            // 
            // rezervo_librinBtn
            // 
            this.rezervo_librinBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.rezervo_librinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rezervo_librinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezervo_librinBtn.ForeColor = System.Drawing.Color.White;
            this.rezervo_librinBtn.Location = new System.Drawing.Point(38, 155);
            this.rezervo_librinBtn.Name = "rezervo_librinBtn";
            this.rezervo_librinBtn.Size = new System.Drawing.Size(98, 59);
            this.rezervo_librinBtn.TabIndex = 14;
            this.rezervo_librinBtn.Text = "Rezervo";
            this.rezervo_librinBtn.UseVisualStyleBackColor = false;
            this.rezervo_librinBtn.Click += new System.EventHandler(this.rezervo_librinBtn_Click);
            // 
            // llogari_gjendje_group
            // 
            this.llogari_gjendje_group.Controls.Add(this.liber_gjendje_label);
            this.llogari_gjendje_group.Controls.Add(this.rezervuar_label);
            this.llogari_gjendje_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llogari_gjendje_group.Location = new System.Drawing.Point(812, 86);
            this.llogari_gjendje_group.Name = "llogari_gjendje_group";
            this.llogari_gjendje_group.Size = new System.Drawing.Size(239, 114);
            this.llogari_gjendje_group.TabIndex = 15;
            this.llogari_gjendje_group.TabStop = false;
            this.llogari_gjendje_group.Text = "Gjendja e llogarise";
            this.llogari_gjendje_group.Visible = false;
            // 
            // rezervuar_label
            // 
            this.rezervuar_label.AutoSize = true;
            this.rezervuar_label.ForeColor = System.Drawing.Color.Navy;
            this.rezervuar_label.Location = new System.Drawing.Point(10, 24);
            this.rezervuar_label.Name = "rezervuar_label";
            this.rezervuar_label.Size = new System.Drawing.Size(139, 16);
            this.rezervuar_label.TabIndex = 0;
            this.rezervuar_label.Text = "Rezervuar: Asnje liber";
            // 
            // liber_gjendje_label
            // 
            this.liber_gjendje_label.AutoSize = true;
            this.liber_gjendje_label.ForeColor = System.Drawing.Color.Black;
            this.liber_gjendje_label.Location = new System.Drawing.Point(10, 70);
            this.liber_gjendje_label.Name = "liber_gjendje_label";
            this.liber_gjendje_label.Size = new System.Drawing.Size(182, 16);
            this.liber_gjendje_label.TabIndex = 1;
            this.liber_gjendje_label.Text = "Ne pronesine tuaj: Asnje liber";
            // 
            // Bibloteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1063, 634);
            this.Controls.Add(this.llogari_gjendje_group);
            this.Controls.Add(this.rezervo_groupBox);
            this.Controls.Add(this.lista_group);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Bibloteka";
            this.Text = "Bibloteka";
            this.Load += new System.EventHandler(this.Bibloteka_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.librat_grid)).EndInit();
            this.lista_group.ResumeLayout(false);
            this.lista_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrFaqe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_rezervo)).EndInit();
            this.rezervo_groupBox.ResumeLayout(false);
            this.rezervo_groupBox.PerformLayout();
            this.llogari_gjendje_group.ResumeLayout(false);
            this.llogari_gjendje_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView librat_grid;
        private System.Windows.Forms.GroupBox lista_group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox autori_input;
        private System.Windows.Forms.NumericUpDown nrFaqe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox zhaneri_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button adv_search_button;
        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_COLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULLI_COLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTORI_COLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAQE_COLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZHANERI_COLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_dorezimit;
        private System.Windows.Forms.NumericUpDown ID_rezervo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox rezervo_groupBox;
        private System.Windows.Forms.Button rezervo_librinBtn;
        private System.Windows.Forms.GroupBox llogari_gjendje_group;
        private System.Windows.Forms.Label liber_gjendje_label;
        private System.Windows.Forms.Label rezervuar_label;
    }
}

