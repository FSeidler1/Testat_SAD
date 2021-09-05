using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRent_Testat_SAD.Model
{
    public class Kunde
    {
        public Guid Id { get; set; }
        [Required]
        public string Vorname { get; set; }
        [Required]
        public string Nachname { get; set; }
        [Required]
        public string Strasse { get; set; }
        [Required]
        public Guid PLZId { get; set; }

        public Adresse PLZ { get; set; }
    }
}
