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
                Getal2 = Int32.Parse(arguments[2]);
            } 
            else if (IsOperator(arguments[1])) 
            {
                Operator = arguments[1];
                Getal1 = Int32.Parse(arguments[0]);
                Getal2 = Int32.Parse(arguments[2]);
            }
            else if (IsOperator(arguments[2])) 
            {
                Operator = arguments[2];
                Getal1 = Int32.Parse(arguments[0]);
                Getal2 = Int32.Parse(arguments[1]);
            }
        }

        private bool IsOperator(string given)
        {
            bool isAdd = given == "+";
            bool isMin = given == "-";
            bool isMultiply = given == "*";
            bool isDivide = given == "/";
            bool isModulo = given == "%";

            return isAdd || isMin || isMultiply || isDivide || isModulo;
                
        }

        public string GetOperator()
        {
            return this.Operator;
        }

        public int GetGetal1()
        {
            return this.Getal1;
        }

        public int GetGetal2()
        {
            return this.Getal2;
        }
    }
}
