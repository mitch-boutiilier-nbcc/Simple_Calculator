using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class frmCalculator : Form
    {
        //global variables to handle calculations
        double tempNumber = 0, answer = 0, input = 0;
        int expression = 9; //0 = Add, 1 = Subtract, 2 = Multiply, 3 = Divide, 8 = Finish, 9 = Start
        bool working = false; // flag for if a user is still entering a number

        //Number input buttons
        private void btn0_Click(object sender, EventArgs e)
        {
            //Don't input 0s if you're already at 0
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "0";

                }
                else
                {
                    lblDisplay.Text = "0";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Replace 0 if that's all that's there
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "1";
                } else
                {
                    lblDisplay.Text = "1";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }                
            } else
            {
                lblDisplay.Text = "1";
            }

            working = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Replace 0 if that's all that's there
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "2";
                }
                else
                {
                    lblDisplay.Text = "2";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }
            }
            else
            {
                lblDisplay.Text = "2";
            }

            working = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Replace 0 if that's all that's there
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "3";
                }
                else
                {
                    lblDisplay.Text = "3";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }
            }
            else
            {
                lblDisplay.Text = "3";
            }

            working = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //Replace 0 if that's all that's there
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "4";
                }
                else
                {
                    lblDisplay.Text = "4";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }
            }
            else
            {
                lblDisplay.Text = "4";
            }

            working = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //Replace 0 if that's all that's there
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "5";
                }
                else
                {
                    lblDisplay.Text = "5";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }
            }
            else
            {
                lblDisplay.Text = "5";
            }

            working = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //Replace 0 if that's all that's there
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "6";
                }
                else
                {
                    lblDisplay.Text = "6";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }
            }
            else
            {
                lblDisplay.Text = "6";
            }

            working = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //Replace 0 if that's all that's there
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "7";
                }
                else
                {
                    lblDisplay.Text = "7";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }
            }
            else
            {
                lblDisplay.Text = "7";
            }

            working = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //Replace 0 if that's all that's there
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "8";
                }
                else
                {
                    lblDisplay.Text = "8";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }
            }
            else
            {
                lblDisplay.Text = "8";
            }

            working = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //Replace 0 if that's all that's there
            if (lblDisplay.Text != "0")
            {
                //Replace the text if this isn't the final answer
                if ((expression != 8) && (working == true))
                {
                    lblDisplay.Text = lblDisplay.Text + "9";
                }
                else
                {
                    lblDisplay.Text = "9";

                    //set expression to 9 to prevent label from resetting in a loop
                    if (expression == 8)
                    {
                        expression = 9;
                    }
                }
            }
            else
            {
                lblDisplay.Text = "9";
            }

            working = true;
        }


        //function for evaluating calculations based on expression type
        public double calculate()
        {
            input = double.Parse(lblDisplay.Text);
            working = false;

            switch (expression)
            {
                case 0: //Addition
                    answer = tempNumber + input;
                    break;
                case 1: //Subtraction
                    answer = tempNumber - input;
                    break;
                case 2: //Multiplication
                    answer = tempNumber * input;
                    break;
                case 3: //Division
                    answer = tempNumber / input;
                    break;
                default: //First input
                    tempNumber = double.Parse(lblDisplay.Text);
                    answer = tempNumber;
                    break;
            }
            return answer;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculate();
            expression = 0;
            lblDisplay.Text = answer.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calculate();
            expression = 1;
            lblDisplay.Text = answer.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calculate();
            expression = 2;
            lblDisplay.Text = answer.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculate();
            expression = 3;
            lblDisplay.Text = answer.ToString();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if((expression != 9) && (lblDisplay.Text != "0")) {
                calculate();
                lblDisplay.Text = answer.ToString();
            }

            expression = 8;
        }

        public frmCalculator()
        {
            InitializeComponent();
            //Reset the display to 0 incase of any weird load
            lblDisplay.Text = "0";
        }

        //Resets the Calculator
        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            tempNumber = 0;
            answer = 0;
            input = 0;
        }
    }
}
