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
            var operatorr = challenge.GetOperator();
            int uitkomst = 0;

            switch (operatorr)
            {
                case "+":
                    uitkomst = this.add(challenge.GetGetal1(), challenge.GetGetal2());
                    break;
                case "-":
                    uitkomst = this.substract(challenge.GetGetal1(), challenge.GetGetal2());
                    break;
                case "*":
                    uitkomst = this.multiply(challenge.GetGetal1(), challenge.GetGetal2());
                    break;
                case "/":
                    uitkomst = this.multiply(challenge.GetGetal1(), challenge.GetGetal2());
                    break;
            }
          
            return uitkomst;
        }

        public int add(int getal1, int getal2)
        {
            int uitkomst = getal1 + getal2;
            this.toString(uitkomst);
            return uitkomst;
        }

        public int substract(int getal1, int getal2)
        {
            int uitkomst = getal1 - getal2;
            this.toString(uitkomst);
            return uitkomst;
        }


        public int deel(int getal1, int getal2)
        {
            int uitkomst = getal1 / getal2;
            this.toString(uitkomst);
            return uitkomst;
        }

        public int multiply(int getal1, int getal2)
        {
            int uitkomst = getal1 * getal2;
            this.toString(uitkomst);
            return uitkomst;
        }

        public void toString(int uitkomst)
        {
            Console.WriteLine(uitkomst);
        }

    }
}
