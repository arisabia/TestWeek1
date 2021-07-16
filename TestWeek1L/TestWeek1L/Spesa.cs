using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L
{
    public class Spesa : IFileSerializable
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public double Importo { get; set; }
        public string Path { get; set; } = @"C:\Users\larisa.b.antonica\Desktop\MyTestAcademy\TestWeek1\TestWeek1L";

        public async Task<Spesa> LoadFromFile(string fileName)
        {
            try
            {
                using (StreamReader reader = File.OpenText(Path + fileName))
                {
                    string data = await reader.ReadLineAsync();
                    string instanceData = reader.ReadLine();
                    string[] values = instanceData.Split(":");

                    string[] dataSpesa = values[1].Split(";");
                    Categoria = dataSpesa[0];
                    
                    Descrizione = dataSpesa[1];

                    double.TryParse(dataSpesa[2], out double importo);
                    Importo = importo;

                }
            }
            catch (IOException ioe)
            {

                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return new Spesa();
        }

        internal static Task<FileSystemEventHandler> LoadFromFile()
        {
            throw new NotImplementedException();
        }

        public async Task<Spesa> SaveToFile(string fileName)
        {
            try
            {
                using (StreamWriter writer = File.CreateText(Path + fileName))
                {
                    await writer.WriteLineAsync("data:" + DateTime.Today.ToShortDateString());
                    await writer.WriteLineAsync("values: " + Categoria + ";" + Descrizione + ";" + Importo );
                }
            }
            catch (IOException ioe)
            {

                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return new Spesa();
        }

        Task IFileSerializable.SaveToFile(string fileName)
        {
            throw new NotImplementedException();
        }

        Task IFileSerializable.LoadFromFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
