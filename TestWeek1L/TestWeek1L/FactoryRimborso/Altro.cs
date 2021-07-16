using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.FactoryRimborso
{
    public class Altro : IRimborso
    {
        public string Tipologia { get; } = "Altro";

        public void categori(string tipoRimborso)
        {
            Console.WriteLine($"Rimborso altro {tipoRimborso}");
        }
    }
}
