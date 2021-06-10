using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bibloteka
{
    public partial class RegisterForm : Form
    {

        List<Lexues> lexuesit = new List<Lexues>();
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void form2_registerBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            // Get data from textBoxes
            string emri = name_input.Text;
            string mbiemri = lastname_input.Text;
            string uname = uname_input.Text;
            string pword = pword_input.Text;

            // Check if inputs are correct
            bool correctEmri = Regex.IsMatch(emri, @"^[a-zA-Z]+$") && emri != "" && emri.Length <= 16? true : false;
            bool correctMbiemri = Regex.IsMatch(mbiemri, @"^[a-zA-Z]+$") && mbiemri != "" && mbiemri.Length <= 16 ? true : false;
            bool correctUname = uname != "" && uname.Length <= 16 ? true : false;
            bool correctPword = pword != "" && pword.Length <= 16 ? true : false;

            // Check if there someone existing with the chosen username
            lexuesit = db.GetLexuesByUname(uname);

            if (!correctEmri)
            {
                MessageBox.Show("Emri nuk duhet te jete bosh dhe duhet te kete vetem shkronja. 16 shkronja maksimumi");
            } 
            else if (!correctMbiemri)
            {
                MessageBox.Show("Mbiemri nuk duhet te jete bosh dhe duhet te kete vetem shkronja. 16 shkronja maksimumi");
            }
            else if (!correctUname)
            {
                MessageBox.Show("Emri i perdoruesit nuk duhet te jete bosh dhe te kete jo me shume se 16 shkronja");
            }
            else if (!correctPword)
            {
                MessageBox.Show("Fjalekalimi nuk duhet te jete bosh dhe te kete jo me shume se 16 shkronja");
            } 
            else if (lexuesit.Count > 0) 
            {
                MessageBox.Show("Emri i perdoruesit eshte perdorur nga dikush tjeter");
            }
            else
            {
                try
                {
                    // Add new Lexues 
                    db.AddNewLexues(emri, mbiemri, uname, pword);

                    MessageBox.Show("Ju u regjistruat me sukses");

                    // Login is successful
                    DialogResult = DialogResult.OK;

                    Close();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
