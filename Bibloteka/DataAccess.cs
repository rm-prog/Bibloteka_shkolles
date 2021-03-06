using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Bibloteka
{
    public class DataAccess
    {
        // Get all records from LIBRAT table
        public List<Liber> GetAllLibra ()
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB"))) 
            {
                return connection.Query<Liber>("SELECT * FROM LIBRAT").ToList(); // Get List with all records
            }
        }


        /////////////////////////////////////////////////////////////////////////////////////
        // Get all unique values from Autori COLUMN in LIBRAT table     //////////////////////
        public List<Liber> GetLibraUniqueAutor()
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Get RECORDS from LIBRAT table with UNIQUE Autor values
                return connection.Query<Liber>("SELECT DISTINCT Autori FROM dbo.LIBRAT").ToList();
            }
        }


        /////////////////////////////////////////////////////////////////////////////////////
        // Get all unique values from Zhaneri COLUMN in LIBRAT table     //////////////////////
        public List<Liber> GetLibraUniqueZhaner()
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Get RECORDS from LIBRAT table with UNIQUE Zhaneri values
                return connection.Query<Liber>("SELECT DISTINCT Zhaneri FROM dbo.LIBRAT").ToList();
            }
        }

        // !!!!!!!!!!!!!!!!!!!!!  Test_Adv_Search -----   Get Methods need changes  !!!!!!!!!!!!!!!!!!!!!!!
        // ///////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////


        // /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // <!------------------------   Selects LIBRAT by parameters : @autori, @faqe, @zhaneri -----------------------!>
        public List<Liber> GetLibraByAutoriFaqeZhaneri(string[] autori, int faqe, string[] zhaneri)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Use stored procedure to get records with particular Autor, Number of Faqe and Zhaner
                // Pass The Parameters autori, faqe, zhaneri
                return connection.Query<Liber>(
                    $"SELECT * FROM dbo.LIBRAT WHERE Autori IN @autori AND Faqe < {faqe} AND Zhaneri IN @zhaneri",
                    new { autori, zhaneri }).ToList();
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////
        // <!--------------------    Selects LIBRAT by parameters : @autori, @faqe  --------------------------!>
        public List<Liber> GetLibraByAutoriFaqe(string[] autori, int faqe)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Use stored procedure to get records with particular Autor, Number of Faqe
                // Pass The Parameters autori, faqe
                return connection.Query<Liber>(
                    $"SELECT * FROM dbo.LIBRAT WHERE Autori IN @autori AND Faqe < {faqe}",
                    new { autori }).ToList();
            }
        }


        // ////////////////////////////////////////////////////////////////////////////////////////////////
        // <!------------------- Selects LIBRAT by parameters : @faqe, @zhaneri -------------------------->
        public List<Liber> GetLibraByFaqeZhaneri(int faqe, string[] zhaneri)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Use stored procedure to get records with particular Number of Faqe and Zhaneri
                // Pass The Parameters faqe, zhaneri
                return connection.Query<Liber>(
                    $"SELECT * FROM dbo.LIBRAT WHERE Faqe < {faqe} AND Zhaneri IN @zhaneri",
                    new { zhaneri }).ToList();
            }
        }


        // ////////////////////////////////////////////////////////////////////////////////////////////////
        // <!------------------ Selects LIBRAT by parameters : @faqe   --------------------------------->
        public List<Liber> GetLibraByFaqe(int faqe)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Use stored procedure to get records with Number of Faqe
                // Pass the Parameter faqe
                return connection.Query<Liber>("dbo.GET_LIBRAT_BY_FAQE @Faqe",
                new { Faqe = faqe }).ToList();
            }
        }


        // ///////////////////////////////////////////////////////////////////////////////////////////////
        // <!------------------ Selects LIBRAT by parameters : @ID -------------------------------------->
        public List<Liber> GetLiberByID(int ID)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Get book with ID
                // Pass the Parameter ID
                return connection.Query<Liber>("dbo.GET_LIBER_BY_ID @ID",
                new { ID = ID }).ToList();
            }
        }
        

        // /////////////////////////////////////////////////////////////////////////////////////////////
        // <!------------ Update LIBRAT, SETS LexuesiID = @lexuesiID and DataDorezimit = data ----------------->
        public void UpdateLibratLexuesiID_Data (int liberID, int lexuesiID, DateTime dataDorezimit)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                connection.Execute("dbo.SET_LIBRAT_LEXUESI_DATE @ID, @LexuesiID, @DataDorezimit",
                new { ID = liberID, LexuesiID = lexuesiID, DataDorezimit = dataDorezimit.ToShortDateString() });
            }
        }


        // /////////////////////////////////////////////////////////////////////////////////////////////
        // !!!!!!! --------------  Adds new Liber into dbo.LIBRAT  --------------- !!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!! -------     Parameters : titulli, autori, faqe, zhaneri   ------- !!!!!!!
        public void AddNewLiber (string titulli, string autori, int faqe, string zhaneri)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // INSERT INTO table LIBRAT   ---   @Titulli, @Autori, @Faqe, @Zhaneri
                // Pass Parameters ----  titulli, autori, faqe, zhaneri
                connection.Execute("dbo.ADD_NEW_LIBER @Titulli, @Autori, @Faqe, @Zhaneri", 
                new { Titulli = titulli, Autori = autori, Faqe = faqe, Zhaneri = zhaneri});
            }
        }

        // /////////////////////////////////////////////////////////////////////////////////////////////
        // <!-------------------- Updates LEXUESIT, SETS LiberGjendjeId = @gjendjeID ------------------------------->
        public void UpdateLexuesGjendjeId(int ID, int gjendjeId)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Set column LiberGjendjeID = @gjendjeId
                // Pass Parameters ID, LiberGjendjeID
                connection.Execute("dbo.SET_LEXUESI_GJENDJE_ID @ID, @LiberGjendjeId",
                new { ID = ID, LiberGjendjeID = gjendjeId });
            }
        }

        public void UpdateLexuesRezervuarId(int ID, int rezervuarId)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Set column LiberGjendjeID = @gjendjeId
                // Pass Parameters ID, LiberGjendjeID
                connection.Execute("dbo.SET_LEXUESI_REZERVUAR_ID @ID, @LiberRezervuarId",
                new { ID = ID, LiberRezervuarID = rezervuarId });
            }
        }


        // //////////////////////////////////////////////////////////////////////////////////////////////
        // <!------------------ Selects LEXUESIT by paramets : @uname ---------------------------------->
        public List<Lexues> GetLexuesByUname(string uname)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Get records with particular username using stored procedure
                // To check if there is someone with this username
                // Pass the Parameter uname
                return connection.Query<Lexues>("dbo.GET_LEXUESIT_BY_UNAME @Uname",
                new { Uname = uname }).ToList();
            }
        }


        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!!!!!   ---   Gets LEXUESIT by parameters : @liberRezervuarID !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public List<Lexues> GetLexuesiByRezervuarID(int rezervuarID)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Get Lexuesit by Parameter rezervuarID
                return connection.Query<Lexues>("dbo.GET_LEXUESIT_BY_REZERVUARID @RezervuarId",
                new { RezervuarID = rezervuarID }).ToList();
            }
        }

        // ///////////////////////////////////////////////////////////////////////////////////////////
        // <!------------------------------- Add new user to LEXUESIT ---------------------------------->
        public void AddNewLexues(string emri, string mbiemri, string uname, string pword)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Insert new lexues into LEXUESIT table
                // Pass emri, mbiemri, uname, pword parameters
                connection.Execute("dbo.NEW_LEXUES_INTO_LEXUESIT @Emri, @Mbiemri, @Uname, @Pword",
                new { Emri = emri, Mbiemri = mbiemri, Uname = uname, Pword = pword });
            }
        }
    }
}
