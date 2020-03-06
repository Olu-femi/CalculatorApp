using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //num1 is the first value entered and opr is the operation to be performed for calculation
        double num1;
        string opr;

        private void del_Click(object sender, EventArgs e)
        { //this function is used as backspace to allow the number to the extreme right be deleted from a string of values
            string n = txtbxdisply.Text;
            

            if (n.Length >= 1) //checks the length of the strings in the textbox
            {
                
                n = n.Substring(0, n.Length - 1);  
            }
            else
            {
                n = "0";               
            }

            txtbxdisply.Text = n; //this displays the string of values left after deleting from the string of values
        }

        private void off_Click(object sender, EventArgs e)
        {
            //Function to close the calculator application
            MessageBox.Show("cal is closing");

            this.Close();
        }

        public void makeMultipleDigits(object sender)
        {
            Button thisButton = (Button)sender;

            List<double> n = new List<double>();
            var decVal = thisButton.Text;
            n.Add(double.Parse(decVal));
            txtbxdisply.Text += decVal;
        }
        public void lblDisplay(object sender)
        {
            Button pressButton = (Button)sender;
            List<string> lbl = new List<string>();
            string val = pressButton.Text;
            lbl.Add(val);
            lblValue.Text += val;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            opr = thisButton.Text;
            lblDisplay(thisButton);
            switch (opr)
            {
                case "+":
                    num1 = double.Parse(txtbxdisply.Text);
                    txtbxdisply.Text = "0";
                    break;
                case "/":
                    num1 = double.Parse(txtbxdisply.Text);
                    txtbxdisply.Text = "0";
                    break;
                case "*":
                    num1 = double.Parse(txtbxdisply.Text);
                    txtbxdisply.Text = "0";
                    break;
                case "-":
                    num1 = double.Parse(txtbxdisply.Text);
                    txtbxdisply.Text = "0";
                    break;
                case "sqr":
                    num1 = double.Parse(txtbxdisply.Text);
                    txtbxdisply.Text = $"{txtbxdisply.Text}";
                    break;
                case "sqrt":
                    num1 = double.Parse(txtbxdisply.Text);
                    txtbxdisply.Text = $"{txtbxdisply.Text}";
                    break;
                case "x^":
                    num1 = double.Parse(txtbxdisply.Text);
                    txtbxdisply.Text = "0";
                    break;
            }
        }

        private void digit_Click(object sender, EventArgs e)
        {

            Button thisButton = (Button)sender;

            if (txtbxdisply.Text != null || txtbxdisply.Text == "0")
            {
                lblDisplay(thisButton);
                switch (thisButton.Name)
                {
                    case "btn1":
                        if (txtbxdisply.Text.Length >= 1 && txtbxdisply.Text != "0")
                        {
                            makeMultipleDigits(thisButton);
                        }
                        else
                        {
                            txtbxdisply.Text = btn1.Text;

                        }
                        break;

                    case "btn2":
                        if (txtbxdisply.Text.Length >= 1 && txtbxdisply.Text != "0")
                        {
                            makeMultipleDigits(thisButton);
                        }
                        else
                        {
                            txtbxdisply.Text = btn2.Text;
                        }
                        break;

                    case "btn3":
                        if (txtbxdisply.Text.Length >= 1 && txtbxdisply.Text != "0")
                        {
                            makeMultipleDigits(thisButton);
                        }
                        else
                        {
                            txtbxdisply.Text = btn3.Text;
                        }
                        break;

                    case "btn4":
                        if (txtbxdisply.Text.Length >= 1 && txtbxdisply.Text != "0")
                        {
                            makeMultipleDigits(thisButton);
                        }
                        else
                        {
                            txtbxdisply.Text = btn4.Text;
                        }
                        break;

                    case "btn5":
                        if (txtbxdisply.Text.Length >= 1 && txtbxdisply.Text != "0")
                        {
                            makeMultipleDigits(thisButton);
                        }
                        else
                        {
                            txtbxdisply.Text = btn5.Text;
                        }
                        break;

                    case "btn6":
                        if (txtbxdisply.Text.Length >= 1 && txtbxdisply.Text != "0")
                        {
                            makeMultipleDigits(thisButton);
                        }
                        else
                        {
                            txtbxdisply.Text = btn6.Text;
                        }
                        break;

                    case "btn7":
                        if (txtbxdisply.Text.Length >= 1 && txtbxdisply.Text != "0")
                        {
                            makeMultipleDigits(thisButton);
                        }
                        else
                        {
                            txtbxdisply.Text = btn7.Text;
                        }
                        break;

                    case "btn8":
                        if (txtbxdisply.Text.Length >= 1 && txtbxdisply.Text != "0")
                        {
                            makeMultipleDigits(thisButton);
                        }
                        else
                        {
                            txtbxdisply.Text = btn8.Text;
                        }
                        break;

                    case "btn9":
                        if (txtbxdisply.Text.Length >= 1 && txtbxdisply.Text != "0")
                        {
                            makeMultipleDigits(thisButton);
                        }
                        else
                        {
                            txtbxdisply.Text = btn9.Text;
                        }
                        break;
                }
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (txtbxdisply.Text != null && txtbxdisply.Text != "0")
            {
                txtbxdisply.Text += "0";
            }
            else
            {
                txtbxdisply.Text = "0";
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (txtbxdisply.Text != null && txtbxdisply.Text != "0")
            {
                txtbxdisply.ResetText();
                txtbxdisply.Text = "0";
                lblValue.ResetText();
            }
            else
            {
                txtbxdisply.Text = txtbxdisply.Text;
            }
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            double num2;
            double Result;

            num2 = Convert.ToDouble(txtbxdisply.Text);

            Button pressButton = (Button)sender;
            List<string> lbl = new List<string>();
            string val = pressButton.Text;
            lbl.Add(val);
            lblValue.Text += val;

            switch (opr)
            {
                case "+":
                    Result = (num1 + num2);
                    txtbxdisply.Text = Convert.ToString(Result);
                    num1 = Result;
                    lblValue.Text += Result;
                    break;
                case "/":
                    Result = (num1 / num2);
                    txtbxdisply.Text = Convert.ToString(Result);
                    num1 = Result;
                    lblValue.Text += Result;
                    break;
                case "*":
                    Result = (num1 * num2);
                    txtbxdisply.Text = Convert.ToString(Result);
                    num1 = Result;
                    lblValue.Text += Result;
                    break;
                case "-":
                    Result = (num1 - num2);
                    txtbxdisply.Text = Convert.ToString(Result);
                    num1 = Result;
                    lblValue.Text += Result;
                    break;
                case "sqr":
                    Result = Math.Pow(num1,2);
                    txtbxdisply.Text = Convert.ToString(Result);
                    num1 = Result;
                    lblValue.Text += Result;
                    break;
                case "sqrt":
                    Result = Math.Sqrt(num1);
                    txtbxdisply.Text = Convert.ToString(Result);
                    num1 = Result;
                    lblValue.Text += Result;
                    break;
                case "x^":
                    Result = Math.Pow(num1,num2 );
                    txtbxdisply.Text = Convert.ToString(Result);
                    num1 = Result;
                    lblValue.Text += Result;
                    break;
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtbxdisply.Text += ".";
            lblValue.Text += ".";
        }
    }
}
