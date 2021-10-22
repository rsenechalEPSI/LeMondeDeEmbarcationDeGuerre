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
            for (int i = 0; i < _value; i++)
            {
                hp.Substract();
            }
        }
    }
}
