using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class Car
    {
        AccubaterryController accubaterryController;
        DoorController doorController;

        public void setDoorController(DoorController doorController)
        {
            this.doorController = doorController;
        }

        public void turnOnDoorPower()
        {
            this.doorController.turnOn();
        }

        public void turnOfDoorPower()
        {
            this.doorController.turnOff();
        }

        public Boolean doorIsLocked()
        {
            return this.doorController.PintuOn();
        }
        public Boolean doorIsUnLocked()
        {
            return this.doorController.PintuOff();
        }

        public void setAccubaterryController(AccubaterryController accubaterryController)
        {
            this.accubaterryController = accubaterryController;
        }

        public void turnOnPower()
        {
            this.accubaterryController.turnOn();
        }

        public void turnOfPower()
        {
            this.accubaterryController.turnOff();
        }

        public Boolean powerIsReady()
        {
            return this.accubaterryController.accubatterryIsOn();
        }
        public Boolean powerIsOff()
        {
            return this.accubaterryController.accubatterryIsOff();
        }
    }
}
