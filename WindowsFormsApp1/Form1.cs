using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }

    class Calc
     {
        int num1 = 0, num2 = 0, res = 0;
        bool r = false;
        string action = "";


        public void Print()
        {
            if (r)
            {
                return Convert.ToString(num1) + act
            }
        }


        public void PrintRes()
        {
            num1 = res;
            num2 = 0;
            return Convert.ToString(res);
        }

        public void Clear()
        {
            num1 = 0;
            num2 = 0;
            res = 0;
            r = false;
        }
        public void Action(string a)
        {
            if (a == "+" || a == "-" || a == "*" || a == "/" || a == "=" || a == "C")
            {
                if (a == "+" || a == "-" || a == "*" || a == "/")
                {
                    action = a;
                }
                else if (a == "=")
                {
                    if (action == "+")
                    {
                        res = num1 + num2;
                    }
                    else if (action == "-")
                    {
                        res = num1 - num2;
                    }
                    else if(action == "*")
                    {
                        res = num1 * num2;
                    }
                    else if(a == "/")
                    {
                        res = num1 / num2;
                    }
                }

                r = true;

                if (a == "C")
                {
                    Clear();
                }
            }
            else
            {
                if (r == false)
                {
                    num1 = Int32.Parse(Convert.ToString(num1) + a);
                }
                else
                {
                    num2 = Int32.Parse(Convert.ToString(num2) + a);
                }

                Print();
            }
        }
     }
}
