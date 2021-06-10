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
            }

        }

    }
}
