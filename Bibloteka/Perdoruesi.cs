using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka
{
    public static class Perdoruesi
    {
        // Static class where info about the current user is saved and changed

        private static int iD = 0;
        private static string firstName = "";
        private static string lastName = "";
        private static string uname = "";
        private static bool loggedIn = false;
        private static int liberRezervuarID = 20000;
        private static int liberGjendjeID = 20000;


        public static int ID { get => iD; set => iD = value; }

        public static string FirstName { get => firstName; set => firstName = value; }

        public static string LastName { get => lastName; set => lastName = value; }

        public static string Uname { get => uname; set => uname = value; }

        public static bool LoggedIn { get => loggedIn; set => loggedIn = value; }

        public static int LiberRezervuarID { get => liberRezervuarID; set => liberRezervuarID = value; }

        public static int LiberGjendjeID { get => liberGjendjeID; set => liberGjendjeID = value; }

    }
}
