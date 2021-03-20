using Lab7.FactoryMethod.interfaces;
using Lab7.Utils;
using System;
using System.Drawing;

namespace Lab7.FactorMethod.BaseProduct
{
    abstract class Car : IMovable
    {
        private Color _color { get; set; }
        private TransportType _type { get; set; }
        private DateTime _productDate { get; set; }

        protected Car()
        {
        }

        protected Car(Color color, TransportType type, DateTime productDate)
        {
            _color = color;
            _type = type;
            _productDate = productDate;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
