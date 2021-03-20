using System;
using System.Drawing;
using Lab7.FactorMethod.BaseCreator;
using Lab7.FactorMethod.BaseProduct;
using Lab7.FactorMethod.Products;
using Lab7.FactorMethod.Products.Truck;
using Lab7.FactoryMethod.interfaces;
using Lab7.Utils;

namespace Lab7.FactorMethod.CreateArea
{
    class TruckCreator : Creator
    {
        public TruckCreator(Color color, TransportType type, DateTime productDate) : base(color, type, productDate)
        {
        }

        public override IMovable Create() => new Zil();
    }
}
