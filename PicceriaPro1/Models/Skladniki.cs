using System;
using System.Collections.Generic;

namespace PicceriaPro1.Models
{
    public partial class Skladniki
    {
        public Skladniki()
        {
            PiccaSkladniki = new HashSet<PiccaSkladniki>();
        }

        public int IdSkladnika { get; set; }
        public string NazwaSkladnika { get; set; }
        public decimal? CenaSkladnika { get; set; }

        public virtual ICollection<PiccaSkladniki> PiccaSkladniki { get; set; }
    }
}
