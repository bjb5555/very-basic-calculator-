using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcRevision
{
    public partial class PythagForm : Form
    {
        ShapeClass ShapeCalculator = new ShapeClass();
        public PythagForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CalculatorForm nextform = new CalculatorForm();
            this.Hide();
            nextform.Show();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(ATXT.Text, out _) && int.TryParse(BTXT.Text, out _))
            {
                ShapeCalculator.A = Convert.ToDouble(ATXT.Text);
                ShapeCalculator.B = Convert.ToDouble(BTXT.Text);
                if (ShapeCalculator.A <= 0 || ShapeCalculator.B <= 0)
                {
                    MessageBox.Show("error occured due to one of the entered values being either 0 or negative. Entered numbers must be positive numbers greater than 0.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShapeCalculator.FindC();
                    CTXT.Text = $"C = {ShapeCalculator.Answer}";
                }
            }

            else if (int.TryParse(ATXT.Text, out _) && int.TryParse(CTXT.Text, out _))
            {
                ShapeCalculator.A = Convert.ToDouble(ATXT.Text);
                ShapeCalculator.C = Convert.ToDouble(CTXT.Text);
                if (ShapeCalculator.A > ShapeCalculator.C)
                {
                    MessageBox.Show("error occured due to C needing to be the largest value", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ShapeCalculator.A <= 0 || ShapeCalculator.C <= 0)
                    {
                        MessageBox.Show("error occured due to one of the entered values being either 0 or negative. Entered numbers must be positive numbers greater than 0.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ShapeCalculator.FindB();
                        CTXT.Text = $"B = {ShapeCalculator.Answer}";
                    }
                }
            }

            else if (int.TryParse(BTXT.Text, out _) && int.TryParse(CTXT.Text, out _))
            {
                ShapeCalculator.B = Convert.ToDouble(BTXT.Text);
                ShapeCalculator.C = Convert.ToDouble(CTXT.Text);
                if (ShapeCalculator.B > ShapeCalculator.C)
                {
                    MessageBox.Show("error occured due to C needing to be the largest value", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ShapeCalculator.A <= 0 || ShapeCalculator.B <= 0)
                    {
                        MessageBox.Show("error occured due to one of the entered values being either 0 or negative. Entered numbers must be positive numbers greater than 0.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ShapeCalculator.FindA();
                        CTXT.Text = $"A = {ShapeCalculator.Answer}";
                    }
                }
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if(panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
    }
}
