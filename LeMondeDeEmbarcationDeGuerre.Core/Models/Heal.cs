using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class Heal
    {
        private int _value;
        public Heal()
        {
            Random r = new Random();
            _value = r.Next(50, 100);
        }

        public void Add(HealthPoint healthPoint)
        {
            while(_value > 0)
            {
                healthPoint.Substract();
                _value -= 1;
            }
        }

    }
}
