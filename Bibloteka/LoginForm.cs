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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            // Get input from text boxes
            string uname = uname_input.Text;
            string pword = pword_input.Text;

            // Check if there is someone with this username
            List<Lexues> lexues = db.GetLexuesByUname(uname);

            if (lexues.Count < 1)
            {
                MessageBox.Show("Emri i perdoruesit eshte i gabuar");
            } 
            // Check if password is correct
            else if (pword != lexues[0].Pword)
            {
                MessageBox.Show("Fjalekalimi eshte i gabuar");
            }
            else
            {
                MessageBox.Show("Kyçja u krye me sukses");

                DialogResult = DialogResult.OK;

                // Update current user information
                Perdoruesi.ID = lexues[0].ID;
                Perdoruesi.FirstName = lexues[0].Emri;
                Perdoruesi.LastName = lexues[0].Mbiemri;
                Perdoruesi.Uname = lexues[0].Uname;
                Perdoruesi.LiberRezervuarID = lexues[0].LiberRezervuarID;
                Perdoruesi.LiberGjendjeID = lexues[0].LiberGjendjeID;
                Perdoruesi.LoggedIn = true;

                Close();
            }
        }
    }
}
