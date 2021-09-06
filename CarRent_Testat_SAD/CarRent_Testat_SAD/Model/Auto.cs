using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRent_Testat_SAD.Model
{
    public class Auto
    {
        public Guid Id { get; set; }
        [Required]
        public Guid KlasseId { get; set; }

        public AutoKlasse Klasse { get; set; }
        [Required]
        public string Marke { get; set; }
        [Required]
        public string Typ { get; set; }
        
    }
}
