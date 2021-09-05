using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Model
{
    public class ReservierungDTO
    {
        public Guid Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime Ende { get; set; }

        public int TotalTage { get; set; }

        public string Status { get; set; }

        public Guid KundeId { get; set; }

        public string KundeVollerName { get; set; }

        public Guid AutoId { get; set; }

        public string AutoName { get; set; }

        public decimal Gesamtkosten { get; set; }
    }
}
