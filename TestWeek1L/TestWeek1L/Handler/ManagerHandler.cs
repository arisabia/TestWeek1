using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.Handler
{
    public class ManagerHandler : AbstractHandler
    {
        
        public override double Handle(Impiegato impiegato)
        {
            if (impiegato.Spesa <= 400)
            {

                return 400;
            }
            else
            {

                return base.Handle(impiegato);
            }
        }
    }
}
