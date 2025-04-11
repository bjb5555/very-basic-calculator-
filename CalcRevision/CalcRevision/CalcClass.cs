using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalcRevision
{
    class CalcClass
    {
        private string equation;
        private string symbol;
        private List<string> splitEquation = new List<string>();
        private double answer;
        private double previousAnswer;

        public CalcClass()
        {
            answer = 0;
            previousAnswer = 0;
        }

        public CalcClass(string equation, string symbol, List<string> splitEquation, double answer, double previousAnswer)
        {
            this.equation = equation;
            this.symbol = symbol;
            this.splitEquation = splitEquation;
            this.answer = answer;
            this.previousAnswer = previousAnswer;
        }

        public string Equation
        {
            get { return equation; }
            set { equation = value; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public List<string> SplitEquation
        {
            get { return splitEquation; }
            set { splitEquation = value; }
        }

        public double Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public double PreviousAnswer
        {
            get { return previousAnswer; }
            set { previousAnswer = value; }
        }

        public void Addition()
        {
            answer = Convert.ToDouble(splitEquation[0]) + Convert.ToDouble(splitEquation[2]);
            Console.WriteLine($"{splitEquation[0]} + {splitEquation[2]} = {answer}");
            previousAnswer = answer;
        }

        public void Subtraction()
        {
            answer = Convert.ToDouble(splitEquation[0]) - Convert.ToDouble(splitEquation[2]);
            Console.WriteLine($"{splitEquation[0]} - {splitEquation[2]} = {answer}");
            previousAnswer = answer;
        }

        public void Division()
        {
            answer = Convert.ToDouble(splitEquation[0]) / Convert.ToDouble(splitEquation[2]);
            Console.WriteLine($"{splitEquation[0]} ÷ {splitEquation[2]} = {answer}");
            previousAnswer = answer;
        }

        public void Multiplication()
        {
            answer = Convert.ToDouble(splitEquation[0]) * Convert.ToDouble(splitEquation[2]);
            Console.WriteLine($"{splitEquation[0]} × {splitEquation[2]} = {answer}");
            previousAnswer = answer;
        }

        public void Squared()
        {
            answer = Math.Pow(Convert.ToDouble(splitEquation[0]), 2);
            previousAnswer = answer;
        }

        public void cubed()
        {
            answer = Math.Pow(Convert.ToDouble(splitEquation[0]), 3);
            previousAnswer = answer;
        }

        public void squareRoot()
        {
            answer = Math.Sqrt(Convert.ToDouble(splitEquation[1]));
            previousAnswer = answer;
        }

        public void cubeRoot()
        {
            answer = Math.Pow(Convert.ToDouble(splitEquation[1]), 0.33333333333333333333333333333333333333333333);
            previousAnswer = answer;
        }

        public void Roll()
        {
            Random random = new Random();
            int DiceResult = random.Next(1,7);
            if(DiceResult == 1)
            {
                symbol =@"                          ----- 
                         |       |
                         |   o  |
                         |       |
                          -----  ";

                answer = 1;
            }

            if (DiceResult == 2)
            {
                symbol =@"                          ----- 
                         |o     |
                         |       |
                         |     o|
                          -----  ";

                answer = 2;
            }

            if (DiceResult == 3)
            {
                symbol =@"                          ----- 
                         | o    |
                         |   o  |
                         |     o|
                          -----  ";

                answer = 3;
            }

            if (DiceResult == 4)
            {
                symbol =@"                          ----- 
                         |o   o|
                         |       |
                         |o   o|
                          -----  ";

                answer = 4;
            }

            if (DiceResult == 5)
            {
                symbol =@"                          ----- 
                         |o   o|
                         |  o   |
                         |o   o|
                          -----  ";

                answer = 5;
            }

            if (DiceResult == 6)
            {
                symbol =@"                          ----- 
                         |o   o|
                         |o   o|
                         |o   o|
                          -----  ";

                answer = 6;
            }
        }
        public void ReplacePi()
        {
            //check later
            if (SplitEquation.Contains("π"))
            {
                var stringBuilder = new System.Text.StringBuilder();
                var splitEquation = SplitEquation;

                foreach (var item in splitEquation)
                {
                    stringBuilder.Append(item);
                }

                int result;
                if (int.TryParse(stringBuilder.ToString(), out result))
                {
                    stringBuilder.Replace("π", Math.PI.ToString(" F5 "));
                    SplitEquation.Add(Convert.ToString(stringBuilder));
                }
                else
                {

                }

                //stringBuilder.Replace("π", Math.PI.ToString(" F5 "));
                //SplitEquation.Add(Convert.ToString(stringBuilder));
            }
        }
    }
}

