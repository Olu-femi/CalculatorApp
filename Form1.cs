﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            Button thisButton = (Button)sender;
            if (String.IsNullOrWhiteSpace(txtboxDisplay.Text) || !String.IsNullOrWhiteSpace(txtboxDisplay.Text))
            {
                if (!String.IsNullOrWhiteSpace(txtboxDisplay.Text))
                {

                }
                switch (thisButton.Name)
                {
                    case "btnOne":
                        txtboxDisplay.Text = btnOne.Text;
                        lblRecord.Text = btnOne.Text;
                        break;

                    case "btnTwo":
                        txtboxDisplay.Text = btnTwo.Text;
                        lblRecord.Text = btnTwo.Text;
                        break;

                    case "btnThree":
                        txtboxDisplay.Text = btnThree.Text;
                        lblRecord.Text = btnThree.Text;
                        break;

                    case "btnFour":
                        txtboxDisplay.Text = btnFour.Text;
                        lblRecord.Text = btnFour.Text;
                        break;

                    case "btnFive":
                        txtboxDisplay.Text = btnFive.Text;
                        lblRecord.Text = btnFive.Text;
                        break;
                    case "btnSix":
                        txtboxDisplay.Text = btnSix.Text;
                        lblRecord.Text = btnSix.Text;
                        break;

                    case "btnSeven":
                        txtboxDisplay.Text = btnSeven.Text;
                        lblRecord.Text = btnSeven.Text;
                        break;

                    case "btnEight":
                        txtboxDisplay.Text = btnEight.Text;
                        lblRecord.Text = btnEight.Text;
                        break;

                    case "btnNine":
                        txtboxDisplay.Text = btnNine.Text;
                        lblRecord.Text = btnNine.Text;
                        break;

                    case "btnZero":
                        txtboxDisplay.Text = btnZero.Text;
                        lblRecord.Text = btnZero.Text;
                        break;
                    case "btnCE":
                        txtboxDisplay.Clear();
                        lblRecord.ResetText();
                        break;

                    case "btnTimes":
                        txtboxDisplay.Text = btnOne.Text;
                        lblRecord.Text = btnOne.Text;
                        break;
                    case "btnDivide":
                        txtboxDisplay.Text = btnOne.Text;
                        lblRecord.Text = btnOne.Text;
                        break;
                    case "btnMinus":
                        txtboxDisplay.Text = btnOne.Text;
                        lblRecord.Text = btnOne.Text;
                        break;
                    case "btnSum":
                        txtboxDisplay.Text = btnOne.Text;
                        lblRecord.Text = btnOne.Text;
                        break;
                    case "btnEquals":
                        txtboxDisplay.Text = btnOne.Text;
                        lblRecord.Text = btnOne.Text;
                        break;

                }
            }
        }
    


        public int addFormulae(int x, int y)
        {
            int opr = x + y;

            return opr;
        }

        public int minusFormulae(int x, int y)
        {
            int opr = x + y;

            return opr;
        }

        public float divFormulae(int x, int y)
        {
            float opr = x + y;

            return opr;
        }

        public float mulFormulae(int x, int y)
        {
            float opr = (float)x + (float)y;

            return opr;
        }
    }
}