using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Model
{
    public class KundeDTO
    {
        public Guid Id { get; set; }

        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public string Strasse { get; set; }

        public Guid PLZId { get; set; }

        public string PLZ { get; set; }

        public string Land { get; set; }

    }
}
