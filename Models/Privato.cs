using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EsercizioS6L12.Models
{
    public class Privato
    {
        [Key]
        public string CF { get; set; }

        [Display(Name ="Nome")]
        [Required(ErrorMessage =("Campo Obbligatorio"))]
        [StringLength(100, MinimumLength = 2 , ErrorMessage ="Il nome deve avere minimo 2 lettere")]
        public string Nome { get; set; }

        [Display(Name = "Cognome")]
        [Required(ErrorMessage = ("Campo Obbligatorio"))]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il Cognome deve avere minimo 2 lettere")]
        public string Cognome { get; set; }

        [Display(Name = "Citta")]
        [Required(ErrorMessage = ("Campo Obbligatorio"))]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La citta deve avere minimo 2 lettere")]
        public string Citta { get; set; }

        [Display(Name = "Cap")]
        [Required(ErrorMessage = ("Campo Obbligatorio"))]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il Cap deve avere minimo 2 lettere")]
        public string Cap {  get; set; }

        [Display(Name = "Indirizzo")]
        [Required(ErrorMessage = ("Campo Obbligatorio"))]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il Cap deve avere minimo 2 lettere")]
        public string Indirizzo { get; set; }
    }
}