using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Bibloteka
{
    public static class Helper
    {
        public static string CnnVal(string name) // Which connection string to get out of app.config
        { 
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        // Fill the table with all records from LIBRAT table
        public static void FillDataGrid (List<Liber> librat, DataGridView books_grid)
        {
            int libratCount = librat.Count;

            books_grid.AllowUserToAddRows = true;

            for (int i=0; i<libratCount; i++)
            {
                books_grid.RowCount++;
                // Add to row LIBRAT record
                books_grid.Rows[i].Cells[0].Value = librat[i].ID;
                books_grid.Rows[i].Cells[1].Value = librat[i].Titulli;
                books_grid.Rows[i].Cells[2].Value = librat[i].Autori;
                books_grid.Rows[i].Cells[3].Value = librat[i].Faqe;
                books_grid.Rows[i].Cells[4].Value = librat[i].Zhaneri;
                books_grid.Rows[i].Cells[5].Value = librat[i].Data_dorezimit.ToShortDateString();
            }

        }


        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
        // !!!!!!!!!!!!!!!!!!!!!! ----------  This function updates user info on screen --------- !!!!!!!!!!!!!!!!!!1
        // Parameters : @librat -> List containing libra ; @rezervuar_label : Here is displayed info about booked books
        //   @liber_gjendje_label : Here is displayed info about possesed books
        public static void UpdateUserInfoOnScreen (Label rezervuar_label, Label liber_gjendje_label)
        {

            List<Liber> librat;
            // Check if he has a book booked
            if (Perdoruesi.LiberRezervuarID != 20000)
            {
                DataAccess db = new DataAccess();

                librat = db.GetLiberByID(Perdoruesi.LiberRezervuarID);

                // Check if the book he has booked, has been submitted
                if (librat[0].Lexuesi_ID == 20000)
                {
                    DateTime today = DateTime.Now;
                    DateTime dataDorezimit = today.AddDays(21);

                    db.UpdateLexuesGjendjeId(Perdoruesi.ID, librat[0].ID);
                    db.UpdateLibratLexuesiID_Data(librat[0].ID, Perdoruesi.ID, dataDorezimit);

                    Perdoruesi.LiberGjendjeID = librat[0].ID;
                    Perdoruesi.LiberRezervuarID = 20000;

                    MessageBox.Show($"Ju sapo terhoqet librin {librat[0].Titulli} \n Libri duhet te dorezohet mbas 21 ditesh");
                }
                else
                {
                    rezervuar_label.Text = $"Rezervuar: {librat[0].Titulli}\n Data e terheqjes: {librat[0].Data_dorezimit.ToShortDateString()}";
                }

                liber_gjendje_label.Text = "Ne pronesine tuaj: Asnje liber";
            }

            // Check if user has a book
            if (Perdoruesi.LiberGjendjeID != 20000)
            {
                DataAccess db = new DataAccess();

                librat = db.GetLiberByID(Perdoruesi.LiberGjendjeID);

                // Check if the due date of the book is today
                if (librat[0].Data_dorezimit.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    Perdoruesi.LiberGjendjeID = 20000;

                    db.UpdateLexuesGjendjeId(Perdoruesi.ID, 20000);
                    db.UpdateLibratLexuesiID_Data(librat[0].ID, 20000, Convert.ToDateTime("2020-01-01"));

                    MessageBox.Show($"Ju sapo dorezuat librin {librat[0].Titulli}");
                }
                else
                {
                    liber_gjendje_label.Text = $"Ne pronesine tuaj: {librat[0].Titulli} \n Data e dorezimit: {librat[0].Data_dorezimit.ToShortDateString()}";
                }
            }

            if (Perdoruesi.LiberGjendjeID == 20000 && Perdoruesi.LiberRezervuarID == 20000)
            {
                rezervuar_label.Text = "Rezervuar: Asnje liber";
                liber_gjendje_label.Text = "Ne pronesine tuaj: Asnje liber";
            }
        }

    }
}
