﻿using System;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void remis()
        {
            if (button1.Text != " " && button2.Text != " " && button3.Text != " " && button4.Text != " " && button5.Text != " " && button6.Text != " " && button7.Text != " " && button8.Text != " " && button9.Text != " " && notWin == true)
            {
                label1.Text = "Remis";
            }
        }

        int click = 1;
        bool notWin = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button1.Text != "X" && notWin)
            {
                button1.Text = "0";
                label1.Text = "Następny gracz:  X";
                click++;
            }
            if (click % 2 == 1 && button1.Text != "0" && notWin)
            {
                button1.Text = "X";
                label1.Text = "Następny gracz:  0";
                click++;
            }

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }

            remis();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button2.Text != "X" && notWin)
            {
                button2.Text = "0";
                label1.Text = "Następny gracz:  X";
                click++;
            }
            if (click % 2 == 1 && button2.Text != "0" && notWin)
            {
                button2.Text = "X";
                label1.Text = "Następny gracz:  0";
                click++;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            remis();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button3.Text != "X" && notWin)
            {
                button3.Text = "0";
                label1.Text = "Następny gracz:  X";
                click++;
            }
            if (click % 2 == 1 && button3.Text != "0" && notWin)
            {
                button3.Text = "X";
                label1.Text = "Następny gracz:  0";
                click++;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            remis();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button6.Text != "X" && notWin)
            {
                button6.Text = "0"; 
                label1.Text = "Następny gracz:  X";
                click++;
            }
            if (click % 2 == 1 && button6.Text != "0" && notWin)
            {
                button6.Text = "X";
                label1.Text = "Następny gracz:  0";
                click++;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            remis();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button5.Text != "X" && notWin)
            {
                button5.Text = "0"; 
                label1.Text = "Następny gracz:  X";
                click++;
            }
            if (click % 2 == 1 && button5.Text != "0" && notWin)
            {
                button5.Text = "X";
                label1.Text = "Następny gracz:  0";
                click++;
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            remis();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button4.Text != "X" && notWin)
            {
                button4.Text = "0";
                label1.Text = "Następny gracz:  X";
                click++;
            }
            if (click % 2 == 1 && button4.Text != "0" && notWin)
            {
                button4.Text = "X";
                label1.Text = "Następny gracz:  0";
                click++;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            remis();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button7.Text != "X" && notWin)
            {
                button7.Text = "0";
                label1.Text = "Następny gracz:  X";
                click++;
            }
            if (click % 2 == 1 && button7.Text != "0" && notWin)
            {
                button7.Text = "X";
                label1.Text = "Następny gracz:  0";
                click++;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            remis();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button8.Text != "X" && notWin)
            {
                button8.Text = "0";
                label1.Text = "Następny gracz:  X";
                click++;
            }
            if (click % 2 == 1 && button8.Text != "0" && notWin)
            {
                button8.Text = "X";
                label1.Text = "Następny gracz:  0";
                click++;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            remis();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button9.Text != "X" && notWin)
            {
                button9.Text = "0";
                label1.Text = "Następny gracz:  X";
                click++;
            }
            if (click % 2 == 1 && button9.Text != "0" && notWin)
            {
                button9.Text = "X";
                label1.Text = "Następny gracz:  0";
                click++;
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label1.Text = " Wygrał gracz X";
                notWin = false;
            }
            if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                label1.Text = " Wygrał gracz 0";
                notWin = false;
            }
            remis();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            notWin = true;
            if (label1.Text == " Wygrał gracz 0")
            {
                label1.Text = "Zaczyna gracz X";
            }
            if (label1.Text == " Wygrał gracz X")
            {
                label1.Text = "Zaczyna gracz 0";
            }
        }
    }
}
