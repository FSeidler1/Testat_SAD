using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRent_Testat_SAD.Model
{
    public class AutoKlasse
    {
        public enum AutoKlasseTyp
        {
            Classic,
            Basic,
            Medium,
            Luxury
        }

        public Guid Id { get; set; }
        [Required]
        public AutoKlasseTyp Typ { get; set; }
        [Required]
        public decimal PricePerDay { get; set; }
    }
}
