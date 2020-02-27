namespace ModCal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecord = new System.Windows.Forms.Label();
            this.txtboxDisplay = new System.Windows.Forms.TextBox();
            this.grpBxKeypad = new System.Windows.Forms.GroupBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpBxKeypad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCE
            // 
            this.btnCE.CausesValidation = false;
            this.btnCE.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCE.Location = new System.Drawing.Point(6, 23);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(59, 54);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRecord);
            this.panel1.Controls.Add(this.txtboxDisplay);
            this.panel1.Controls.Add(this.grpBxKeypad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 377);
            this.panel1.TabIndex = 1;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(12, 21);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(0, 16);
            this.lblRecord.TabIndex = 18;
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxDisplay
            // 
            this.txtboxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtboxDisplay.Location = new System.Drawing.Point(3, 57);
            this.txtboxDisplay.Name = "txtboxDisplay";
            this.txtboxDisplay.Size = new System.Drawing.Size(268, 40);
            this.txtboxDisplay.TabIndex = 17;
            this.txtboxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpBxKeypad
            // 
            this.grpBxKeypad.Controls.Add(this.btnZero);
            this.grpBxKeypad.Controls.Add(this.btnEquals);
            this.grpBxKeypad.Controls.Add(this.btnSum);
            this.grpBxKeypad.Controls.Add(this.btnMinus);
            this.grpBxKeypad.Controls.Add(this.btnDivide);
            this.grpBxKeypad.Controls.Add(this.btnTimes);
            this.grpBxKeypad.Controls.Add(this.btnSeven);
            this.grpBxKeypad.Controls.Add(this.btnFour);
            this.grpBxKeypad.Controls.Add(this.btnOne);
            this.grpBxKeypad.Controls.Add(this.btnSix);
            this.grpBxKeypad.Controls.Add(this.btnTwo);
            this.grpBxKeypad.Controls.Add(this.btnFive);
            this.grpBxKeypad.Controls.Add(this.btnEight);
            this.grpBxKeypad.Controls.Add(this.btnThree);
            this.grpBxKeypad.Controls.Add(this.btnNine);
            this.grpBxKeypad.Controls.Add(this.btnCE);
            this.grpBxKeypad.Location = new System.Drawing.Point(3, 103);
            this.grpBxKeypad.Name = "grpBxKeypad";
            this.grpBxKeypad.Size = new System.Drawing.Size(268, 262);
            this.grpBxKeypad.TabIndex = 16;
            this.grpBxKeypad.TabStop = false;
            // 
            // btnZero
            // 
            this.btnZero.CausesValidation = false;
            this.btnZero.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnZero.Location = new System.Drawing.Point(71, 23);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(59, 54);
            this.btnZero.TabIndex = 30;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.CausesValidation = false;
            this.btnEquals.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(201, 203);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(59, 53);
            this.btnEquals.TabIndex = 29;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSum
            // 
            this.btnSum.CausesValidation = false;
            this.btnSum.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSum.Location = new System.Drawing.Point(201, 143);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(59, 54);
            this.btnSum.TabIndex = 28;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.button_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.CausesValidation = false;
            this.btnMinus.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(201, 83);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(59, 54);
            this.btnMinus.TabIndex = 27;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.button_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.CausesValidation = false;
            this.btnDivide.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnDivide.Location = new System.Drawing.Point(201, 23);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(59, 54);
            this.btnDivide.TabIndex = 26;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnTimes.Location = new System.Drawing.Point(136, 23);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(59, 54);
            this.btnTimes.TabIndex = 25;
            this.btnTimes.Text = "*";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.CausesValidation = false;
            this.btnSeven.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSeven.Location = new System.Drawing.Point(136, 83);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(59, 54);
            this.btnSeven.TabIndex = 24;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFour
            // 
            this.btnFour.CausesValidation = false;
            this.btnFour.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnFour.Location = new System.Drawing.Point(136, 143);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(59, 54);
            this.btnFour.TabIndex = 23;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.button_Click);
            // 
            // btnOne
            // 
            this.btnOne.CausesValidation = false;
            this.btnOne.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnOne.Location = new System.Drawing.Point(136, 202);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(59, 54);
            this.btnOne.TabIndex = 22;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSix
            // 
            this.btnSix.CausesValidation = false;
            this.btnSix.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSix.Location = new System.Drawing.Point(6, 143);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(59, 54);
            this.btnSix.TabIndex = 21;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.CausesValidation = false;
            this.btnTwo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnTwo.Location = new System.Drawing.Point(71, 202);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(59, 54);
            this.btnTwo.TabIndex = 20;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFive
            // 
            this.btnFive.CausesValidation = false;
            this.btnFive.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnFive.Location = new System.Drawing.Point(71, 143);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(59, 54);
            this.btnFive.TabIndex = 19;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEight
            // 
            this.btnEight.CausesValidation = false;
            this.btnEight.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnEight.Location = new System.Drawing.Point(71, 83);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(59, 54);
            this.btnEight.TabIndex = 18;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.button_Click);
            // 
            // btnThree
            // 
            this.btnThree.CausesValidation = false;
            this.btnThree.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnThree.Location = new System.Drawing.Point(6, 202);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(59, 54);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.button_Click);
            // 
            // btnNine
            // 
            this.btnNine.CausesValidation = false;
            this.btnNine.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnNine.Location = new System.Drawing.Point(6, 83);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(59, 54);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 377);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ModCal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBxKeypad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxDisplay;
        private System.Windows.Forms.GroupBox grpBxKeypad;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Label lblRecord;
    }
}