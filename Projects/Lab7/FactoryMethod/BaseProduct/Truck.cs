using Lab7.FactoryMethod.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.FactoryMethod.BaseProduct
{
    class Truck : IMovable
    {
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
