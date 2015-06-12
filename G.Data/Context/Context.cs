using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Data.Context
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void executeCreate(object obj)
        {
            strategy.Create(obj);
        }

        public object executeRead()
        {
            return strategy.Read();
        }

        public void executeUpdate(object obj)
        {
            strategy.Update(obj);
        }

        public void executeDelete(object obj)
        {
            strategy.Delete(obj);
        }
    }
}