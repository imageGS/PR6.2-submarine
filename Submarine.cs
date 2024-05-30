using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2_submarine
{
    internal class Submarine
    {
        ControlCenter cc = new ControlCenter();
        AttackDefenceCenter adc = new AttackDefenceCenter();
        IntelligenceCenter ic = new IntelligenceCenter();
        
        public void Move()
        {

        }

        public void Fire(SubmarineHub form) 
        {
            adc.Innit(form);
        }
        public bool TurnOnRadar()
        {
            if (ic.IsOn == false)
            {
                ic.IsOn = true;
                return true;
            }
            else
            {
                ic.IsOn = false;
                return false;
            }
        }
    }
}
