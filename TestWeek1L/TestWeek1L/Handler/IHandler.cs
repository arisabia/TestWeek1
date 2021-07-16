using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.Handler
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        double Handle(Impiegato impiegato);
    }
}
