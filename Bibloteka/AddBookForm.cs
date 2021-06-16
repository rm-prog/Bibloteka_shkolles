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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void addLiberBtn_Click(object sender, EventArgs e)
        {
            string titulli = titulli_label.Text;
            string autori = autori_label.Text;
            int faqe = Convert.ToInt32(faqe_numeric.Value);
            string zhaneri = zhaneri_label.Text;

            if (titulli.Length < 3)
            {
                MessageBox.Show("Titulli eshte shume i shkurter");
            } 
            else if (autori.Length < 5) 
            {
                MessageBox.Show("Emri i autorit eshte shume i shkurter");
            } 
            else if (zhaneri.Length < 3)
            {
                MessageBox.Show("Emri i zhanerit eshte shume i shkurter");
            } 
            else
            {
                DataAccess db = new DataAccess();

                db.AddNewLiber(titulli, autori, faqe, zhaneri);

                MessageBox.Show("Sapo shtuat nje liber te ri ne bibloteke");
            }
        }
    }
}
