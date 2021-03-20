using Lab7.FactorMethod.BaseCreator;
using Lab7.FactorMethod.BaseProduct;
using Lab7.FactoryMethod.BaseProduct;
using Lab7.FactoryMethod.interfaces;
using Lab7.Utils;
using System;
using System.Drawing;

namespace Lab7.FactoryMethod.CreateArea
{
    class PlaneCreator : Creator
    {

        public PlaneCreator(Color color, TransportType type, DateTime productDate) 
            : base(color, type, productDate)
        {
        }

        public override IMovable Create() => new Plane();
    }
}
