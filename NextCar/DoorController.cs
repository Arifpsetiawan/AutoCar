using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class DoorController
    {
        private Door Pintu;
        public DoorController()
        {
            this.Pintu = new Door(4);
        }
        public Boolean PintuOn()
        {
            return this.Pintu.isOn();
        }
        public Boolean PintuOff()
        {
            return this.Pintu.isOff();
        }
        public void turnOn()
        {
            this.Pintu.turnOn();
        }

        public void turnOff()
        {
            this.Pintu.turnOff();
        }
    }
}
