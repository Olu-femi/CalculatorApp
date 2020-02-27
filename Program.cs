using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModCal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //    int sum = 0;
            //    List<int> num = new List<int>();

            //for (int i = 0; i < 5; i++)
            //    {
            //    string myval = "79";

            //        num.Add(int.Parse(myval));

            //        sum += int.Parse(myval);  

            //    }
            //Console.Read();

        }
    }
}
