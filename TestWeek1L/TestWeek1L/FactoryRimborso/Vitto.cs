using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.FactoryRimborso
{
    public class Vitto : IRimborso
    {
        public string Tipologia { get; } = "Vitto";

        public void categori(string tipoRimborso)
        {
            Console.WriteLine($"Rimborso vitto {tipoRimborso}");
        }
    }
}
