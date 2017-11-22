using System;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Battle
{
    public class Goalkeeper : IGoalkeeper
    {
        public int AcceptChallenge(string challenge)
        {
            var problemsolver = new ChallengeCalculator();

            int result = problemsolver.Accept(challenge);

            return result;
        }
    }
}
