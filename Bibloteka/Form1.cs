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


        //  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!!!!!!! ----    Button that Opens Register Form --------- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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




        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!!!!!!! ------   Button that allows user to look for different books --- !!!!!!!!!!!!!!!!!!
        public void btnSearch_Click(object Sender, EventArgs eventArgs)
        {
            DataAccess db = new DataAccess();

            librat = db.GetAllLibra();

            lista_group.Visible = true;

            librat_grid.Columns[5].Visible = false;

            rezervo_groupBox.Visible = false;

            // Fill librat_grid datagridview with records from librat <list>
            // librat <list> gets records from LIBRAT table through sql connection in db DataAccess object
            Helper.FillDataGrid(librat, librat_grid);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!! --- Button that allows user to search books according to his preferences ------------ !!!!!!!!!!!!!!!!!!!!
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



        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!! --- Button that opens table with libra from library and allows user to book a book --------- !!!!!!!!!!!!!!!!!
        private void btnReserve_Click(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (!Perdoruesi.LoggedIn)
            {
                MessageBox.Show("Duhet te kyçeni per te rezervuar libra");
            } 
            else if (Perdoruesi.LiberGjendjeID != 20000)
            {
                MessageBox.Show("Nuk mund te rezervoni nje liber, pa dorezuar librin qe keni");
            }
            else if (Perdoruesi.LiberRezervuarID != 20000)
            {
                MessageBox.Show("Nuk mund te rezervoni me shume se nje liber");
            }
            else
            {
                DataAccess db = new DataAccess();

                librat = db.GetAllLibra();

                lista_group.Visible = true;

                // Make visible column that shows Data e dorezimit te librit
                librat_grid.Columns[5].Visible = true;

                rezervo_groupBox.Visible = true;
                // Fill librat_grid datagridview with records from librat <list>
                // librat <list> gets records from LIBRAT table through sql connection in db DataAccess object
                Helper.FillDataGrid(librat, librat_grid);
            }

        }



        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!!! ---  Button that opens Login Form ------------ !!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!!!!!! ------     Logs user in ---------------     !!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!! ---------------   Also displays info about the user on screen   ---------------  !!!!!!!!
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

                // Display info about user on screen
                llogari_gjendje_group.Visible = true;

                Helper.UpdateUserInfoOnScreen(rezervuar_label, liber_gjendje_label);

            }
        }

        private void hello_label_Click(object sender, EventArgs e)
        {

        }


        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!!!!!!!!! -----   Button that lets the user book the book if possible --------- !!!!!!!!!!!!!!!!!11
        private void rezervo_librinBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int liberID = Convert.ToInt32(ID_rezervo.Value);

            librat = db.GetLiberByID(liberID);

            if (librat.Count < 1)
            {
                MessageBox.Show("Nuk ka liber my kete ID");
            } 
            else if (librat[0].Data_dorezimit == Convert.ToDateTime("2020-01-01"))
            {
                // Should inform user that he can take the book now
                // Should change the users data
                // Set the ID of the book he has ( Column LiberGjendjeID )
                // Set the ID of the user that has the book ( In table LIBRAT Column Lexuesi_ID )
                // Set the due date of the book ( In table LIBRAT Column Data_dorezimit )
                // Change users data in Perdoruesi Static Class

                DateTime today = DateTime.Now;
                DateTime dataDorezimit = today.AddDays(21);

                db.UpdateLexuesGjendjeId(Perdoruesi.ID, liberID);
                db.UpdateLibratLexuesiID_Data(liberID, Perdoruesi.ID, dataDorezimit);

                Perdoruesi.LiberGjendjeID = liberID;

                MessageBox.Show($"Duhet te dorezoni librin me : '{dataDorezimit.ToShortDateString()}'");


            } 
            else
            {
                // Check if there is anyone who has reserved this book
                // If yes than user cant reserve it
                // If noone than reserve it
                // Change users data
                // Set the ID of the book reserved ( Column LiberRezervuarID )
                // Change users data in Perdoruesi Static Class

                List<Lexues> lexues = db.GetLexuesiByRezervuarID(liberID);
                if (lexues.Count > 1)
                {
                    MessageBox.Show("Nuk mund te rezervoni kete liber. Dikush tjeter e ka rezervuar para jush");
                } 
                else
                {
                    db.UpdateLexuesRezervuarId(Perdoruesi.ID, liberID);

                    Perdoruesi.LiberRezervuarID = liberID;

                    MessageBox.Show($"Ju sapo rezervuat librin '{librat[0].Titulli}'\n Terhiqeni me: {librat[0].Data_dorezimit.ToShortDateString()}");

                    Helper.UpdateUserInfoOnScreen(rezervuar_label, liber_gjendje_label);
                }
            }
        }
    }
}
