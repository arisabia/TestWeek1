using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.FactoryRimborso
{
    public class RimborsoFactory
    {
        public static IRimborso CreaRimborso(int importo)
        {
            IRimborso rimborso;
            if (importo == 100 && importo == 50)
            {
                rimborso = new Viaggio();

            }
            else if (importo == 100)
            {
                rimborso = new Alloggio();
            }
            else if (importo == 70)
            {
                rimborso = new Vitto();
            }
            else if (importo == 10)
            {
                rimborso = new Altro();
            }
            else
            {
                rimborso = null;
            }
            return rimborso;
        }
    }
}
