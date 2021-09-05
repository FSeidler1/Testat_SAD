using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRent_Testat_SAD.Model
{
    public class Adresse
    {
        public Guid Id { get; set; }
        [Required]
        public string PLZ { get; set; }
        [Required]
        public string Land { get; set; }
        [Required]
        public string Ort { get; set; }
    }
}
