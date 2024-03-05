using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsercizioS6L12.Models
{
    public class Spedizione
    {
        public string IdCliente { get; set; }
        public DateTime DataSpedizione { get; set; }
        public decimal Peso { get; set; }
        public string CittaDestinataria { get; set; }
        public string Indirizzo { get; set; }
        public string Destinatario { get; set; }
        public decimal Costo { get; set; }
        public DateTime DataConsegna { get; set; }
        public string Stato { get; set; }
    }
}