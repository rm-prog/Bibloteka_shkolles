﻿using System;
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

        public List<Liber> GetLibraByAutoriFaqeZhaneri(string autori, int faqe, string zhaneri)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Use stored procedure to get records with particular Autor, Number of Faqe and Zhaner
                // Pass The Parameters autori, faqe, zhaneri
                return connection.Query<Liber>("dbo.GET_LIBRAT_BY_AUTORI_FAQE_ZHANERI @Autori, @Faqe, @Zhaneri",
                new { Autori = autori, Faqe = faqe, Zhaneri = zhaneri }).ToList();
            }
        }

        public List<Liber> GetLibraByAutoriFaqe(string autori, int faqe)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Use stored procedure to get records with particular Autor, Number of Faqe
                // Pass The Parameters autori, faqe
                return connection.Query<Liber>("dbo.GET_LIBRAT_BY_AUTORI_FAQE @Autori, @Faqe",
                new { Autori = autori, Faqe = faqe }).ToList();
            }
        }

        public List<Liber> GetLibraByFaqeZhaneri(int faqe, string zhaneri)
        {
            // Create connection with DB using connection string, get connection string with helper class
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIBLOTEKA_DB")))
            {
                // Use stored procedure to get records with particular Number of Faqe and Zhaneri
                // Pass The Parameters faqe, zhaneri
                return connection.Query<Liber>("dbo.GET_LIBRAT_BY_FAQE_ZHANERI @Faqe, @Zhaneri",
                new { Faqe = faqe, Zhaneri = zhaneri }).ToList();
            }
        }

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