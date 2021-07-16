using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.FactoryRimborso
{
    public class Viaggio : IRimborso
    {
        public string Tipologia { get; } = "Viaggio";

        public void categori(string tipoRimborso)
        {
            Console.WriteLine($"Rimborso viaggio {tipoRimborso}");
        }
    }
}
