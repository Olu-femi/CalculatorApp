namespace ModCal
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxdisply = new System.Windows.Forms.TextBox();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnequals = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbxdisply
            // 
            this.txtbxdisply.BackColor = System.Drawing.Color.White;
            this.txtbxdisply.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtbxdisply.Location = new System.Drawing.Point(12, 64);
            this.txtbxdisply.Name = "txtbxdisply";
            this.txtbxdisply.ReadOnly = true;
            this.txtbxdisply.Size = new System.Drawing.Size(266, 32);
            this.txtbxdisply.TabIndex = 1;
            this.txtbxdisply.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btndiv
            // 
            this.btndiv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btndiv.Location = new System.Drawing.Point(150, 408);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(59, 58);
            this.btndiv.TabIndex = 5;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnminus.Location = new System.Drawing.Point(219, 186);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(59, 58);
            this.btnminus.TabIndex = 9;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            // 
            // btndot
            // 
            this.btndot.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btndot.Location = new System.Drawing.Point(82, 408);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(59, 58);
            this.btndot.TabIndex = 8;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(13, 408);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(59, 58);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.zero_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnDel.Location = new System.Drawing.Point(219, 129);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(59, 42);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.del_Click);
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnmul.Location = new System.Drawing.Point(219, 260);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(59, 58);
            this.btnmul.TabIndex = 13;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(150, 186);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(59, 58);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.digit_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(82, 186);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(59, 58);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.digit_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(13, 186);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(59, 58);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.digit_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(82, 260);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(59, 58);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.digit_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(13, 260);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(59, 58);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.digit_Click);
            // 
            // btnequals
            // 
            this.btnequals.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnequals.Location = new System.Drawing.Point(219, 408);
            this.btnequals.Name = "btnequals";
            this.btnequals.Size = new System.Drawing.Size(59, 58);
            this.btnequals.TabIndex = 21;
            this.btnequals.Text = "=";
            this.btnequals.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(150, 334);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(59, 58);
            this.btn1.TabIndex = 20;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.digit_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(82, 334);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(59, 58);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.digit_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(13, 334);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(59, 58);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.digit_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(150, 260);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(59, 58);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.digit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(150, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "OFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.off_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnadd.Location = new System.Drawing.Point(219, 334);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(59, 58);
            this.btnadd.TabIndex = 24;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(82, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 42);
            this.button2.TabIndex = 25;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnequals);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.txtbxdisply);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxdisply;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnequals;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button2;
    }
}