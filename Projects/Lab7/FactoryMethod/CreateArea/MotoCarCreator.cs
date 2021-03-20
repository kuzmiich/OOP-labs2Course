using Lab7.FactorMethod.BaseCreator;
using Lab7.FactorMethod.Products.MotoCar;
using Lab7.FactoryMethod.interfaces;
using Lab7.Utils;
using System;
using System.Drawing;

namespace Lab7.FactorMethod.CreateArea
{
    class MotoCarCreator : Creator
    {
        public MotoCarCreator(Color color, TransportType type, DateTime productDate) : base(color, type, productDate)
        {
        }

        public override IMovable Create() => new Lada();
    }
}
