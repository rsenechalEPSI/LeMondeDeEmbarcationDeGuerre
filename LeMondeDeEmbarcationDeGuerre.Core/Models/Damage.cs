using System;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class Damage
    {
        private int _value;

        public Damage()
        {
            //Random r = new Random();
            //_value = r.Next(50, 100);
            _value = 1000;
        }

        public void Substract(HealthPoint healthPoint, LivingState livingState)
        {
            while(_value > 0)
            {
                healthPoint.Substract(livingState);
                _value -= 1;
            }
        }
    }
}
