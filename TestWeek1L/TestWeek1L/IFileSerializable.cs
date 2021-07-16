using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L
{
    public interface IFileSerializable
    {
        public string Path { get; set; }
        public Task SaveToFile(string fileName);

        public Task LoadFromFile(string fileName);

    }
}
