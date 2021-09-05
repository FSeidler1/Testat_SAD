using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Model
{
    public class AutoDTO
    {
        public Guid Id { get; set; }

        public Guid KlasseId { get; set; }

        public string Marke { get; set; }

        public string Typ { get; set; }

        public string Klasse { get; set; }

        public decimal PreisProTag { get; set; }
    }
}
