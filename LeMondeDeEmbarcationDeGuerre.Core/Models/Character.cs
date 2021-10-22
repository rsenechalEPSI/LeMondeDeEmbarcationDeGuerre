using System;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class Character
    {
        private CharacterLevel _characterLevel;
        private CharacterState _characterState;
        
        public Character()
        {
            _characterLevel = new CharacterLevel();
            _characterState = new CharacterState();
        }

        public void Attack(Character character2)
        {
            character2.TakeDamage(new Damage());
        }
        internal void TakeDamage(Damage damage)
        {
            _characterState.SubstractDamage(damage);
        }

        public void Heal(Character character2)
        {
            character2.HealCharacter(new Heal());
        }

        private void HealCharacter(Heal heal)
        {
            _characterState.HealCharacter(heal);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Infomation personnage : \n");
            _characterState.DisplayInfoCharacterState();
            _characterLevel.DisplayLevel();
            Console.WriteLine("===========================\n");
        }
    }
}
