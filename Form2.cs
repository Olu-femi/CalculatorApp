using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModCal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double firstdigit;
        string opr;

        private void del_Click(object sender, EventArgs e)
        {
            string n = txtbxdisply.Text;

            if(n.Length >= 1)
            {
              n = n.Substring(0, n.Length - 1);
            }
            else
            {
                n = "0";
            }

            txtbxdisply.Text = n;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtbxdisply.Text = "0";
        }

        private void off_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cal is closing");

            this.Close();
            
        }

        public void makeMultipleDigits(object sender)
        {
            Button thisButton = (Button)sender;

            List<double> n = new List<double>();
            string decVal = thisButton.Text;
            n.Add(double.Parse(decVal));
            txtbxdisply.Text = txtbxdisply.Text + decVal;
        }

        private void digit_Click(object sender, EventArgs e)
        {

            Button thisButton = (Button)sender;

            if (txtbxdisply.Text != null || txtbxdisply.Text == "0")
            {
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
            if(txtbxdisply.Text != null && txtbxdisply.Text != "0")
            {
                txtbxdisply.Text = txtbxdisply.Text + "0";
            }
            else
            {
                txtbxdisply.Text = "0";
            }
        }
    }
}
