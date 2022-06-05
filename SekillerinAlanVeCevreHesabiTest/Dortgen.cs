using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerinAlanVeCevreHesabiTest
{
    internal class Dortgen : ISekil
    {
        double tabanLength;
        double height;

        public Dortgen(double tabanLength, double height)
        {
            this.tabanLength = tabanLength;
            this.height = height;
        }

        public double AlanHesabi()
        {
            return tabanLength * height;
        }

        public double CevreHesabi()
        {
            return (tabanLength + height) * 2;
        }
    }
}
