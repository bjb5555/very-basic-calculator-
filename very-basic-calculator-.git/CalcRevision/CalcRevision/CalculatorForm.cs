//As an edit note...why...? It wastes SO much resources.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace CalcRevision
{
    public partial class CalculatorForm : Form
    {
        int formatchecker = 0;
        CalcClass calculation = new CalcClass();
        public CalculatorForm()
        {
            InitializeComponent();
            CalcClass calculation = new CalcClass();
        }

        private void QuestionEnterTXTBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int x = 0;
                calculation.Equation = QuestionEnterTXTBOX.Text;
                string[] temp = new string[calculation.Equation.Length];
                if (calculation.Equation.Contains("+"))
                {
                    calculation.Symbol = "+";
                    x = calculation.Equation.IndexOf('+');
                    if (calculation.Equation.Contains(" ") == false)
                    {
                        temp = calculation.Equation.Split(' ');
                        calculation.SplitEquation = temp.ToList();
                        //to add space after the + symbol

                        //to add space before the + symbol

                        calculation.Addition();
                        AnswerBox.Text = Convert.ToString($"{calculation.SplitEquation[0]} + {calculation.SplitEquation[2]} = {calculation.Answer}");

                    }
                    else
                    {
                        temp = calculation.Equation.Split(' ');
                        calculation.SplitEquation = temp.ToList();

                        calculation.Addition();
                        AnswerBox.Text = Convert.ToString($"{calculation.SplitEquation[0]} + {calculation.SplitEquation[2]} = {calculation.Answer}");

                    }
                }
                
                if (calculation.SplitEquation.Contains("π"))
                {
                    calculation.ReplacePi();
                }
                


                if (calculation.Equation.Contains("-"))
                {
                    calculation.Symbol = "-";
                    //x = calculation.Equation.IndexOf('+'); For adding spaces but this is to do later
                    if (calculation.Equation.Contains(" ") == false)
                    {
                        temp = calculation.Equation.Split(' ');
                        calculation.SplitEquation = temp.ToList();
                        //to add space after the + symbol

                        //to add space before the + symbol

                        calculation.Subtraction();
                        AnswerBox.Text = Convert.ToString($"{calculation.SplitEquation[0]} - {calculation.SplitEquation[2]} = {calculation.Answer}");


                    }
                    else
                    {
                        temp = calculation.Equation.Split(' ');
                        calculation.SplitEquation = temp.ToList();

                        calculation.Subtraction();
                        AnswerBox.Text = Convert.ToString($"{calculation.SplitEquation[0]} - {calculation.SplitEquation[2]} = {calculation.Answer}");

                    }

                }
                

               
                if (calculation.Equation.Contains("/"))
                {
                    calculation.Symbol = "÷";
                    //x = calculation.Equation.IndexOf('+'); For adding spaces but this is to do later
                    if (calculation.Equation.Contains(" ") == false)
                    {
                        temp = calculation.Equation.Split(' ');
                        calculation.SplitEquation = temp.ToList();
                        //to add space after the + symbol

                        //to add space before the + symbol


                        calculation.Division();
                        AnswerBox.Text = Convert.ToString($"{calculation.SplitEquation[0]} ÷ {calculation.SplitEquation[2]} = {calculation.Answer}");
                    }
                    else
                    {
                        temp = calculation.Equation.Split(' ');
                        calculation.SplitEquation = temp.ToList();

                        calculation.Division();
                        AnswerBox.Text = Convert.ToString($"{calculation.SplitEquation[0]} ÷ {calculation.SplitEquation[2]} = {calculation.Answer}");
                    }

                }
                


                if (calculation.Equation.Contains("*"))
                {
                    calculation.Symbol = "×";
                    //x = calculation.Equation.IndexOf('+'); For adding spaces but this is to do later
                    if (calculation.Equation.Contains(" ") == false)
                    {
                        temp = calculation.Equation.Split(' ');
                        calculation.SplitEquation = temp.ToList();
                        //to add space after the + symbol

                        //to add space before the + symbol

                        temp = calculation.Equation.Split(' ');
                        calculation.SplitEquation = temp.ToList();
                    }
                    else
                    {
                        temp = calculation.Equation.Split(' ');
                        calculation.SplitEquation = temp.ToList();

                        calculation.Multiplication();
                        AnswerBox.Text = Convert.ToString($"{calculation.SplitEquation[0]} × {calculation.SplitEquation[2]} = {calculation.Answer}");
                    }

                    
                }
                if (calculation.Equation.Contains("²"))
                {
                    calculation.Symbol = "²";
                    temp = calculation.Equation.Split('²');
                    calculation.SplitEquation = temp.ToList();


                    temp = calculation.Equation.Split('²');
                    calculation.SplitEquation = temp.ToList();

                    calculation.Squared();
                    AnswerBox.Text = $"{calculation.SplitEquation[0]}² = {calculation.Answer}";
                }

                if (calculation.Equation.Contains("³"))
                {
                    calculation.Symbol = "³";
                    temp = calculation.Equation.Split('³');
                    calculation.SplitEquation = temp.ToList();


                    temp = calculation.Equation.Split('³');
                    calculation.SplitEquation = temp.ToList();

                    calculation.cubed();
                    AnswerBox.Text = $"{calculation.SplitEquation[0]}³ = {calculation.Answer}";
                }

                if (calculation.Equation.Contains("√"))
                {
                    calculation.Symbol = "√";
                    temp = calculation.Equation.Split('√');
                    calculation.SplitEquation = temp.ToList();


                    temp = calculation.Equation.Split('√');
                    calculation.SplitEquation = temp.ToList();

                    calculation.squareRoot();
                    AnswerBox.Text = $"√{calculation.SplitEquation[1]} = {calculation.Answer}";
                    
                }

                if (calculation.Equation.Contains("∛"))
                {
                    calculation.Symbol = "∛";
                    temp = calculation.Equation.Split('∛');
                    calculation.SplitEquation = temp.ToList();


                    temp = calculation.Equation.Split('∛');
                    calculation.SplitEquation = temp.ToList();

                    calculation.cubeRoot();
                    AnswerBox.Text = $"∛{calculation.SplitEquation[1]} = {calculation.Answer}";
                    
                }
            }
        }
    
    




        private void AnsButton_Click(object sender, EventArgs e)
        {
            QuestionEnterTXTBOX.Text += calculation.PreviousAnswer;
        }

        private void piButton_Click(object sender, EventArgs e)
        {
            double π = Math.PI;
            QuestionEnterTXTBOX.Text += "π";
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            QuestionEnterTXTBOX.Text += "²";            
        }

        private void cubedButton_Click(object sender, EventArgs e)
        {
            QuestionEnterTXTBOX.Text += "³";
        }

        static TimeSpan TimeDiff(TimeSpan nowSpan, TimeSpan ts)
        {
            if (nowSpan > ts)
            {
                ts = ts.Add(TimeSpan.FromDays(1));
            }
            return ts - nowSpan;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (formatchecker == 0)
            {
                TimeLBL.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }
            if(formatchecker == 1)
            {
                TimeLBL.Text = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }
            TimeSpan TillBreak = TimeDiff(DateTime.Now.TimeOfDay, new TimeSpan( 10, 25, 0));
            timeTillBreak.Text = TillBreak.ToString();
            //timeTillBreak.Text = $"{Math.Round(TillBreak.TotalHours),0}: {Math.Round(TillBreak.TotalMinutes/60),0}: {Math.Round(TillBreak.TotalSeconds/3600),0}";
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            if(formatchecker == 0)
            {
                formatchecker = 1;
            }
            else if (formatchecker == 1)
            {
                formatchecker = 0;
            }
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            QuestionEnterTXTBOX.Text += "√";
        }

        private void cubedRoot_Click(object sender, EventArgs e)
        {
            QuestionEnterTXTBOX.Text += "∛";
        }

        private void PythagPic_Click(object sender, EventArgs e)
        {            
            PythagForm nextForm = new PythagForm();
            this.Hide();
            nextForm.ShowDialog();
            this.Show();
        }

        private void DicePic_Click(object sender, EventArgs e)
        {
            DiceForm nextform = new DiceForm();            
            this.Hide();
            nextform.ShowDialog();
            this.Show();
        }
    }
}
