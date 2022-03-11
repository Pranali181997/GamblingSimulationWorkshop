using GmblingSimulation;
using System;

namespace GmblingSimulation
{
    class Program
    {                
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GamblingSimulation!");
            Gabmbling.WinOrLoose();

            Gabmbling.WinOrLooseFiftyPercent();
        }
    }
}
