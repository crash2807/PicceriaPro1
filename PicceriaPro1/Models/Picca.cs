using System;
using System.Collections.Generic;

namespace PicceriaPro1.Models
{
    public partial class Picca
    {
        public Picca()
        {
            PiccaSkladniki = new HashSet<PiccaSkladniki>();
        }

        public int IdPiccy { get; set; }
        public string NazwaPiccy { get; set; }
        public decimal Rozmiar { get; set; }
        public decimal CenaPiccy { get; set; }

        public virtual ICollection<PiccaSkladniki> PiccaSkladniki { get; set; }
    }
}
