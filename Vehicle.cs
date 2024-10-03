using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    internal class Vehicle
    {
        private string _licensPlate;
        private double _weight;


        public Vehicle(string licensPlate, double weight)
        {
           _licensPlate = licensPlate;
        }

        public string getLicensePlate()
        {
            return _licensPlate;
        }

        public double getWeight()
        {
            return 0.0;
        }

        public string toString()
        {
            return "";
        }

        public bool equals (Vehicle other)
        {
            return false;
        }

        
    }
}
