using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerinAlanVeCevreHesabiTest
{
    internal class Circle : ISekil
    {
        private double yaricap;

        public Circle(double yaricap)
        {
            this.yaricap = yaricap;
        }

        public double AlanHesabi()
        {   
            return Math.PI * yaricap * yaricap;
        }

        public double CevreHesabi()
        {
            double cap = Math.PI * 2;
            return Math.PI * cap;
        }
    }
}
