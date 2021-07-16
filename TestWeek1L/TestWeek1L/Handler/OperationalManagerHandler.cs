using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.Handler
{
    public class OperationalManagerHandler : AbstractHandler
    {
        
        public override double Handle(Impiegato impiegato)
        {
            if (impiegato.Spesa >= 401 && impiegato.Spesa <= 1000)
            {

                return 1000;
            }
            else
            {

                return base.Handle(impiegato);
            }
        }
    }
}
