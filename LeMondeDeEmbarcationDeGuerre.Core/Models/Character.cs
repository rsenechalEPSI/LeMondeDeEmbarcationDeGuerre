using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMondeDeEmbarcationDeGuerre.Core.Models
{
    public class Character : ICharacter
    {
        public int HealthPoint { get; set; }
        public int Level { get; set; }
        public bool Living { get; set; }

        public Character()
        {
            HealthPoint = 1000;
            Level = 1;
            Living = true;
        }

        public void Attack(Character characterToHit)
        {
            if (!characterToHit.Living)
            {
                throw new Exception("The Character is dead.");
            }
            Random r = new Random();
            int randomDamage = r.Next(50, 100);
            
            characterToHit.HealthPoint -= randomDamage;
            if(characterToHit.HealthPoint < 0)
            {
                characterToHit.Living = false;
            }
        }

        public void Heal(Character characterToHeal)
        {
            if (!characterToHeal.Living)
            {
                throw new Exception("The Character is dead.");
            }
            Random r = new Random();
            int randomHP = r.Next(50, 100);

            if(characterToHeal.HealthPoint + randomHP <= 1000)
            {
                characterToHeal.HealthPoint += randomHP;
            }
            else
            {
                characterToHeal.HealthPoint += (1000 - randomHP);

            }
        }
    }
}
