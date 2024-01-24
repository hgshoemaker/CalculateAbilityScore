using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAbilityScore
{
    internal class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;


        /// <summary>
        /// process the calculations for the program
        /// </summary>
        public void CaculateAbilityScore()
        {
            double divided = RollResult / DivideBy;
            
           int added = AddAmount + (int)divided;

            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
}
