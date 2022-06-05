using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerinAlanVeCevreHesabiTest
{
    internal class Ucgen : ISekil
    {
        private double tabanLength;
        private double height;

        public Ucgen(double tabanLength, double height)
        {
            this.tabanLength = tabanLength;
            this.height = height;
        }

        public double AlanHesabi()
        {
            return (tabanLength * height) / 2;
        }

        public double CevreHesabi()
        {
            throw new NotImplementedException();
        }
    }
}
