using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Backend.Model
{
    public enum ReservierungStatus
    {
        Reserviert,
        Verliehen
    }

    public class Reservierung : IEntity<Guid>
    {
        public Guid Id { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime Ende { get; set; }

        [NotMapped]
        public int TotalTage
        {
            get
            {
                if (Start < Ende)
                {
                    var result = Ende - Start;
                    return result.Days;
                }
                else
                {
                    return 0;
                }
            }
        }

        public ReservierungStatus Status { get; set; }
        [Required]
        public Guid KundeId { get; set; }

        public Kunde Kunde { get; set; }
        [Required]
        public Guid AutoId { get; set; }

        public Auto Auto { get; set; }
    }

}
