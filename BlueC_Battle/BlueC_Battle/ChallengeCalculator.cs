using System;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Battle
{
    public class ChallengeCalculator
    {
        public int Accept(string challenge)
        {
            Challenge parsed = Parse(challenge);
            int calculated = this.Calculate(parsed);

            return calculated;
        }

        public Challenge Parse(string challenge)
        {
            string[] splitted = challenge.Split(" ");
            return new Challenge(splitted);
        }

        public int Calculate(Challenge challenge)
        {
            // calculator
            return 3;
        }
    }
}
