using Lab7.FactorMethod.BaseProduct;
using Lab7.FactoryMethod.interfaces;
using Lab7.Utils;
using System;
using System.Drawing;

namespace Lab7.FactorMethod.BaseCreator
{
    /// <summary>
    /// 
    /// </summary>
    abstract class Creator
    {
        private Color _color { get; set; }
        private TransportType _type { get; set; }
        private DateTime _productDate { get; set; }

        protected Creator(Color color, TransportType type, DateTime productDate)
        {
            _color = color;
            _type = type;
            _productDate = productDate;
        }

        abstract public IMovable Create();
    }
}
