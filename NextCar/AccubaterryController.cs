﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class AccubaterryController
    {
        private Accubattery accubattery;

        public AccubaterryController()
        {
            this.accubattery = new Accubattery(12);
        }

        public Boolean accubatterryIsOn()
        {
            return this.accubattery.isOn();
        }

        public Boolean accubatterryIsOff()
        {
            return this.accubattery.isOff();
        }

        public void turnOn()
        {
            this.accubattery.turnOn();
        }

        public void turnOff()
        {
            this.accubattery.turnOff();
        }
    }
}
