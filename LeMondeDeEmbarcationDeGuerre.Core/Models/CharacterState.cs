using System;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class CharacterState
    {
        private HealthPoint _healthPoint;
        private LivingState _livingState;

        public CharacterState()
        {
            _healthPoint = new HealthPoint();
            _livingState = new LivingState();
        }

        internal void SubstractDamage(Damage damage)
        {
            damage.Substract(_healthPoint, _livingState);
        }

        internal void HealCharacter(Heal heal)
        {
            heal.Add(_healthPoint);
        }

        internal void DisplayInfoCharacterState()
        {
            _healthPoint.DisplayHealth();
            _livingState.DisplayState();
        }
    }
}
