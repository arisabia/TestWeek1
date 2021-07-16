using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.FactoryRimborso
{
    public class Alloggio : IRimborso
    {
        public string Tipologia { get; } = "Alloggio";

        public void categori(string tipoRimborso)
        {
            Console.WriteLine($"Rimborso alloggio {tipoRimborso}");
        }
    }
}
