using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek1L.Handler
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual double Handle(Impiegato impiegato)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(impiegato);
            }
            else
            {
                return 0;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
