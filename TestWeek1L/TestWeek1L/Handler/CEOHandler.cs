using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.Handler
{
    public class CEOHandler : AbstractHandler
    {
        public override double Handle(Impiegato impiegato)
        {
            if (impiegato.Spesa >= 1000 && impiegato.Spesa <= 2500)
            {
              
                return 2500;
            }
            else { 

            return base.Handle(impiegato);
            }
        }
    }
}
