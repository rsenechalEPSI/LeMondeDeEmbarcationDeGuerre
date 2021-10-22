using System;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class Damage
    {
        private int _value;

        public Damage()
        {
            Random r = new Random();
            _value = r.Next(50, 100);
        }

        public void Substract(HealthPoint hp)
        {
            while(_value > 0)
            {
                hp.Substract();
                _value -= 1;
            }
        }
    }
}
