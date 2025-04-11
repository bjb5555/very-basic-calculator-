using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcRevision
{
    public partial class DiceForm : Form
    {

        CalcClass DiceCalculation = new CalcClass();
        public DiceForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CalculatorForm nextform = new CalculatorForm();
            this.Hide();
            nextform.Show();
        }

        private async void DiceButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 28; i++)
            {
                DiceCalculation.Roll();
                if (i != 28)
                {
                    if (i == 0 || i == 7 || i == 14 || i == 21)
                    {
                        DicePictureLBL.ForeColor = Color.Red;
                    }
                    else if (i == 1 || i ==8 || i == 15 || i == 22)
                    {
                        DicePictureLBL.ForeColor = Color.Orange;
                    }
                    else if (i == 2 || i == 9 || i == 16 || i == 23)
                    {
                        DicePictureLBL.ForeColor = Color.Gold;
                    }
                    else if (i == 3 || i == 10 || i == 17 || i == 24)
                    {
                        DicePictureLBL.ForeColor = Color.Green;
                    }
                    else if (i == 4 || i == 11 || i == 18 || i == 25)
                    {
                        DicePictureLBL.ForeColor = Color.Blue;
                    }
                    else if (i == 5 || i == 12 || i == 19 || i == 26)
                    {
                        DicePictureLBL.ForeColor = Color.Indigo;
                    }
                    else if (i == 6 || i == 13 || i == 20 || i == 27)
                    {
                        DicePictureLBL.ForeColor = Color.Violet;
                    }

                    DicePictureLBL.Text = DiceCalculation.Symbol;
                }
                else
                {
                    DicePictureLBL.ForeColor = Color.Black;
                    DicePictureLBL.Text = $"{DiceCalculation.Symbol}\n\nThe Dice has rolled a {DiceCalculation.Answer}!!!";
                }
                await Task.Delay(10*(i+1));
            }
        }
    }
}
