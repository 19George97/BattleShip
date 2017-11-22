using System;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Battle
{
    public class Challenge
    {
        private string Operator;
        private int Getal1;
        private int Getal2;

        public Challenge(string[] arguments)
        {
            if(IsOperator(arguments[0]))
            {
                Operator = arguments[0];
                Getal1 = Int32.Parse(arguments[1]);

                // getal2
            }
        }

        private bool IsOperator(string given)
        {
            bool isAdd = given == "+";
            bool isMin = given == "-";
            // etc

            return isAdd 
                || isMin;
        }

        public string GetOperator()
        {
            return this.Operator;
        }

    }
}
