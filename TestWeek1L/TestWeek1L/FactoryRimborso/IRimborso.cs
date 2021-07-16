using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.FactoryRimborso
{
   public  interface IRimborso
    {
        public string Tipologia { get; }
        void categori(string tipoRimborso);
    }
}
