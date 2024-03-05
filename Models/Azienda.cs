using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EsercizioS6L12.Models
{
    public class Azienda
    {
        [Key]
        public string PIVA {  get; set; }

        public string Citta { get; set; }
        public string Cap {  get; set; }
        public string Indirizzo { get; set; }
        public string Nome { get; set; }
    }
}