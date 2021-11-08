using LeMondeDeEmbarcationDeGuerre.Core.Models;
using System;
using System.Collections.Generic;

namespace LeMondeDeEmbarcationDeGuerre
{
    class Program
    {
        static void Main(string[] args)
        {
            Character witcher = new Character();

            Character paysan = new Character();

            LaunchGame(witcher, paysan);
        }

        static void LaunchGame(Character hero, Character ennemy)
        {
            Fight(hero, ennemy);
            Heal(hero, ennemy);
            Continue(hero, ennemy);
        }

        static void Fight(Character character1, Character character2)
        {
            DispayInfoCharacters(character1, character2);
            Console.WriteLine("Do you want to Attack the other character ? (Y for Yes, N for no)");
            string userInput = Console.ReadLine().ToLower();
            if(userInput == "y")
            {
                character1.Attack(character2);
            }
        }

        static void Heal(Character character1, Character character2)
        {
            DispayInfoCharacters(character1, character2);
            Console.WriteLine("Do you want to Heal the other character ? (Y for Yes, N for no)");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                character1.Heal(character2);
            }
        }

        static void Continue(Character character1, Character character2)
        {
            DispayInfoCharacters(character1, character2);
            Console.WriteLine("Do you want to continue the fight ? (Y for Yes, N for no)");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                LaunchGame(character1, character2);
            }
        }

        static void DispayInfoCharacters(Character character1, Character character2)
        {
            character1.DisplayInfo();
            character2.DisplayInfo();
        }

    }
}
