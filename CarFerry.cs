using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    internal class CarFerry
    {
        private string _name;
        private double _weight;
        private double _maxWeight;

        public List<Vehicle> vehicleList;

        public CarFerry(string weight,  double maxWeight)
        {
            _maxWeight = maxWeight;
        }

        public void addVehicle(Vehicle vehicle)
        {
            vehicleList.Add(vehicle);
        }

        public void removeVehicle(Vehicle vehicle)
        {

        }

        public Vehicle getVehicle(string licensePlate)
        {
            Vehicle car = null;
            for (int i = 0; i < vehicleList.Count; i++)
            {
                if (vehicleList[i].getLicensePlate() == licensePlate)
                {
                    return vehicleList[i];
                }
            }
            return car;
        }

        public double getTotalWeight()
        {
            return 0.0;
        }

        public bool isOverWeight()
        { 
            return false;
        }

        public string getName()
        {
            return "";
        }

        public void setName(string name)
        {

        }

        public double getWeight()
        {
            return 0.0;
        }

        public double getMaxWeight()
        {
            return 0.0;
        }
    }
}
