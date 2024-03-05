using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EsercizioS6L12.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.Data.Sql;

namespace EsercizioS6L12.Controllers
{
    public class FormController : Controller
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Spedizioni"].ToString();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddPrivato(Privato privato)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var commandText = "INSERT INTO Privato (Cf, Nome, Cognome, Citta, Cap, Indirizzo) VALUES (@cf, @nome, @cognome, @citta, @cap, @indirizzo)";
                var command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@cf", privato.CF);
                command.Parameters.AddWithValue("@nome", privato.Nome);
                command.Parameters.AddWithValue("@cognome", privato.Cognome);
                command.Parameters.AddWithValue("@citta", privato.Citta);
                command.Parameters.AddWithValue("@cap", privato.Cap);
                command.Parameters.AddWithValue("@indirizzo", privato.Indirizzo);

                command.ExecuteNonQuery();
            }

            return View("~/Views/Home/Index.cshtml");
        }


        public ActionResult AddAzienda(Azienda azienda)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var commandText = "INSERT INTO Azienda (PIVA, Nome, Citta, Cap, Indirizzo) VALUES (@piva, @nome, @citta, @cap, @indirizzo)";
                var command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@piva", azienda.PIVA);
                command.Parameters.AddWithValue("@nome", azienda.Nome);
                command.Parameters.AddWithValue("@citta", azienda.Citta);
                command.Parameters.AddWithValue("@cap", azienda.Cap);
                command.Parameters.AddWithValue("@indirizzo", azienda.Indirizzo);

                command.ExecuteNonQuery();
            }

            return View("~/Views/Home/Index.cshtml");
        }



        public ActionResult AddUser(string UserType)
        {
            if (UserType == null)
            {
                ViewBag.user = "Private";
            }
            else
            {
                ViewBag.user = UserType;
            }

            return View("~/Views/Home/Form.cshtml");
        }

    }
}