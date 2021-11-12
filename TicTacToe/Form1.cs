using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public static int TimesPressed = 0;
        public bool WonTheGame = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClickEvent(Button button)
        {
            if(true) // check of het al ingedrukt is (aka of er al een waarde in button.text staat
            {
                button.Text = TimesPressed % 2 == 0 ? "X" : "O";
                TimesPressed++;
            }
        }

        private void WinCheck()
        {
            // 3 op een rij = win

            // Maak 2d array aan
            // Controleer op alle mogelijke win condities

            MessageBox.Show("You won");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClickEvent(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClickEvent(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClickEvent(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonClickEvent(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClickEvent(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonClickEvent(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonClickEvent(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonClickEvent(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonClickEvent(button9);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
