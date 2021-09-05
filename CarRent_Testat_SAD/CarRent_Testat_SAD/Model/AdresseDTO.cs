using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Model
{
    public class AdresseDTO
    {
        public Guid Id { get; set; }

        public string PLZ { get; set; }

        public string Land { get; set; }

        public string Ort { get; set; }
    }
}
