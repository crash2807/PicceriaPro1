using System;
using System.Collections.Generic;

namespace PicceriaPro1.Models
{
    public partial class PiccaSkladniki
    {
        public int IdPiccy { get; set; }
        public int IdSkladnika { get; set; }

        public virtual Picca IdPiccyNavigation { get; set; }
        public virtual Skladniki IdSkladnikaNavigation { get; set; }
    }
}
