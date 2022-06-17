using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csFactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            switch (tires)
            {
                case 2:
                    return new Motorcycle();
                    break;
                case 4:
                    return new Car();
                    break;
                default:
                    return new Car();
                    break;
            }
        }
    }
}
