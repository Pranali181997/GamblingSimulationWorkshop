using System;
using System.Collections.Generic;
using System.Text;

namespace GmblingSimulation
{
    class Gabmbling
    {
        //UC1 Setting Stake as 100 and Bet as 1
        public const int STAKE = 100;
        public const int BET = 1;

        /*UC2 Win or Loose*/
        public static int WinOrLoose()
        {
            int result = new Random().Next(0, 2);
            return result;
        }

        /*UC3 Gambler plays till win or loose fifty percent.*/

        public const float STAKE_VALUE = 0.5f;
        public static int WinOrLooseFiftyPercent()
        {
            int winningAmount, loosingAmount, stake;
            loosingAmount = (int)Math.Round(STAKE * STAKE_VALUE);
            winningAmount = (int)Math.Round(STAKE + (STAKE * STAKE_VALUE));
            bool play = true;
            stake = STAKE;
            while (play == true)
            {
                int betOutcome = WinOrLoose();
                if (betOutcome == 1)
                {
                    stake += BET;
                }
                else
                {
                    stake -= BET;
                }
                if ((stake == loosingAmount) || (stake == winningAmount))
                    play = false;
            }
            return stake;
        }
    }
}