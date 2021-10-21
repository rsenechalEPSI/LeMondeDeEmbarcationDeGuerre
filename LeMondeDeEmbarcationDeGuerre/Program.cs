using LeMondeDeEmbarcationDeGuerre.Core.Models;
using System;

namespace LeMondeDeEmbarcationDeGuerre
{
    class Program
    {
        static void Affichage(Character character1, Character character2)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Witcher : ");
            Console.WriteLine("PV     : " + character1.HealthPoint);
            Console.WriteLine("LVL    : " + character1.Level);
            Console.WriteLine("Vivant : " + character1.HealthPoint);
            Console.WriteLine("===============================");
            Console.WriteLine("Paysan : ");
            Console.WriteLine("PV     : " + character2.HealthPoint);
            Console.WriteLine("LVL    : " + character2.Level);
            Console.WriteLine("Vivant : " + character2.HealthPoint);
            Console.WriteLine("===============================");
        }

        static void Main(string[] args)
        {
            Character witcher = new Character();
            Character paysan = new Character();

            while (paysan.Living)
            {
                Affichage(witcher, paysan);
                witcher.Attack(paysan);

            }
        }


    }
}
