using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteka
{
    public partial class Bibloteka : Form
    {

        List<Liber> librat = new List<Liber>();

        public Bibloteka()
        {
            InitializeComponent();
        }
    
        public void btnRegister_Click(object Sender, EventArgs eventArgs)
        {
            // Open RegisterForm to register new user
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();

            // Register process continues in RegisterForm form_2_registerBtn_Click
            // Wait for registerform to close

            // If register was successful
            if (registerForm.DialogResult == DialogResult.OK)
            {
                btnRegister.Enabled = false;
                btnRegister.Visible = false;
            }
        }

        public void btnSearch_Click(object Sender, EventArgs eventArgs)
        {
            DataAccess db = new DataAccess();

            librat = db.GetAllLibra();

            lista_group.Visible = true;

            // Fill librat_grid datagridview with records from librat <list>
            // librat <list> gets records from LIBRAT table through sql connection in db DataAccess object
            Helper.FillDataGrid(librat, librat_grid);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void adv_search_button_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            librat_grid.Rows.Clear();

            string autori = autori_input.Text; // Get which author has the user choosed
            int faqe = Convert.ToInt32(nrFaqe.Value); // How many pages maximum
            string zhaneri = zhaneri_input.Text; // The Zhaner the user has choosed

            bool getByAutori = autori != "" && autori != "Te Gjithe" ? true : false; // Check if user has chosen any specific author
            bool getByZhaneri = zhaneri != "" && zhaneri != "Te Gjithe" ? true : false; // Check if user has chosen any specific zhaner

            if (getByAutori && getByZhaneri)
            {
                librat = db.GetLibraByAutoriFaqeZhaneri(autori, faqe, zhaneri); // Select librat based on autori, faqe and zhaner
            } 
            else if (getByAutori && !getByZhaneri)
            {
                librat = db.GetLibraByAutoriFaqe(autori, faqe); // Select librat based on autori and faqe
            } 
            else if (!getByAutori && getByZhaneri)
            {
                librat = db.GetLibraByFaqeZhaneri(faqe, zhaneri); // Select librat based on faqe and zhaneri
            }
            else
            {
                librat = db.GetLibraByFaqe(faqe); // Select librat based on faqe
            }

            Helper.FillDataGrid(librat, librat_grid); // Fill the dataGridView with records from librat List<>
        }

        private void Bibloteka_Load(object sender, EventArgs e)
        {
            hello_label.Text = $"Pershendetje {Perdoruesi.FirstName}!";
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (!Perdoruesi.LoggedIn)
            {
                MessageBox.Show("Duhet te kyçeni per te rezervuar libra");
            } 
            else
            {
                // Should open the table with librat with all columns
                throw new NotImplementedException();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            loginForm.ShowDialog();

            // If login is successful
            if (loginForm.DialogResult == DialogResult.OK)
            {
                hello_label.Text = $"Pershendetje {Perdoruesi.FirstName} !";
                btnLogin.Enabled = false;
                btnLogin.Visible = false;
                btnRegister.Enabled = false;
                btnRegister.Visible = false;
            }
        }
    }
}
