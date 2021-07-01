using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_FLYING_POSTMAN
{
    class Flydata
    {
        private int scope;
        private int velocity;
        private int landing_time;
        private int take_off;
        private int refuel_time;

       
        public int Take_off { get => take_off; set => take_off= value; }
        public int Scope { get => scope; set => scope = value; }
        public int Landing_time { get => landing_time; set => landing_time = value; }
        public int Vel { get => velocity; set => velocity = value; }
        public int Refuel_time { get => refuel_time; set => refuel_time = value; }

        public Flydata(int scope, int Vel, int take_off, int landing_time, int refuel_time)
        {
            try
            {
                this.Scope = Convert.ToInt32(scope);
                this.Vel = Convert.ToInt32(Vel);
                this.Take_off = Convert.ToInt32(take_off);
                this.Landing_time = Convert.ToInt32(landing_time);
                this.Refuel_time = Convert.ToInt32(refuel_time);
        }
         
            catch (FormatException e)
            {
                throw e;
            }

     
            if (Landing_time < 0 || Vel < 0 || Take_off < 0 || Scope < 0 || Refuel_time < 0)
            {
                throw new Exception();
            }
        }
    } 
}

    
