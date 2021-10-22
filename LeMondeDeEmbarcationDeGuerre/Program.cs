using LeMondeDeEmbarcationDeGuerre.Core.Models;
using System;

namespace LeMondeDeEmbarcationDeGuerre
{
    class Program
    {

        static void Main(string[] args)
        {
            Character witcher = new Character();
            Character paysan = new Character();

            

            while (true)
            {
                witcher.DisplayInfo();
                paysan.DisplayInfo();

                witcher.Attack(paysan);
                witcher.DisplayInfo();
                paysan.DisplayInfo();
                break;
            }
        }


    }
}
