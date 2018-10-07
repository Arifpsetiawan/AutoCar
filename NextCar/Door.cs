using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class Door
    {
        private int jmlPintu;
        private Boolean stateOn = false;
        private Boolean stateOff = true;

        public Door(int jml)
        {
            this.jmlPintu = jml;
        }

        public void turnOn()
        {
            this.stateOn = true;
        }

        public void turnOff()
        {
            this.stateOn = false;
        }

        public Boolean isOn()
        {
            return this.stateOn;
        }
        public Boolean isOff()
        {
            return this.stateOff;
        }
    }
}
