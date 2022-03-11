using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingSimulation
{
    class WinOrLoose
    {
        public static int WinOrLooseGame()
        {
            int result = new Random().Next(0, 2);
            return result;
        }
    }
}
