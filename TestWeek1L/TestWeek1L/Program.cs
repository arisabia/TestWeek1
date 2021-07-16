using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TestWeek1L.FactoryRimborso;
using TestWeek1L.Handler;

namespace TestWeek1L
{
    class Program
    {
        static async Task Main(string[] args)
        {
           // FileSystemWatcher fsw = new FileSystemWatcher();
           // fsw.Path = @"C:\Users\larisa.b.antonica\Desktop\MyTestAcademy\TestWeek1\TestWeek1L";
           // fsw.Filter = "*.txt";
           // fsw.NotifyFilter = NotifyFilters.LastWrite |
           //        NotifyFilters.LastAccess | NotifyFilters.FileName
           //        | NotifyFilters.DirectoryName;
           // fsw.EnableRaisingEvents = true;

           // fsw.Created += await Spesa.LoadFromFile();
           // Console.WriteLine("Premi q per uscire");
           // while (Console.Read() != 'q') ;

           // Spesa spesa = new Spesa()
           // {
           //     Categoria = "",
           //     Descrizione = "",
           //     Importo = 100.0
           // };
           // await spesa.SaveToFile("spesa.txt");
           //await spesa.LoadFromFile("spesa.txt");
            //////////////////////////////////
            List<Impiegato> impiegati = new List<Impiegato>();

            // TODO ADD Lista impiegati
            impiegati.Add(new Impiegato()

            {
                Nome = "Mara",
                Spesa = 350
            });
            var manager = new ManagerHandler();
            var opeManagar = new OperationalManagerHandler();
            var ceo = new CEOHandler();

            manager.SetNext(opeManagar).SetNext(ceo);
            foreach (var item in impiegati)
            {
                Console.WriteLine($"Il dipendente {item.Nome} ha il livello di aprovazione fino a  {manager.Handle(item)}  euro");
            }

            RimborsoFactory factory = new RimborsoFactory();
            Console.WriteLine("Quale percento di rimborso devi ricevere?");
            var percentoRimborso = Convert.ToInt32(Console.ReadLine());
            IRimborso selectTipo = factory.CreaRimborso(percentoRimborso);
            if (selectTipo != null)
            {
                selectTipo.categori("X");
            }
        }
    }
}
