using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true;
        int ruch = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Restart();

            resultX.Text = "0";
            resultO.Text = "0";
            lblPlayerTurn.Text = "X";
        }

        public void Restart()
        {
            ruch = 0;
            Button[] ButtonTable = new Button[9];
            ButtonTable[0] = button1;
            ButtonTable[1] = button2;
            ButtonTable[2] = button3; 
            ButtonTable[3] = button4;
            ButtonTable[4] = button5;
            ButtonTable[5] = button6;
            ButtonTable[6] = button7;
            ButtonTable[7] = button8;
            ButtonTable[8] = button9;
            foreach (var button in ButtonTable)
            {
                button.Enabled = true;
                button.Text = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClicked((Button)sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClicked((Button)sender); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClicked((Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonClicked((Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClicked((Button)sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonClicked((Button)sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonClicked((Button)sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonClicked((Button)sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonClicked((Button)sender);
        }


        private void ButtonClicked(Button sender)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "X" : "O"; // tenary
            ((Button)sender).Enabled = false;
            if (ruch > 4)
            {
                CheckWin();
            }
            gracz1 = !gracz1;
            lblPlayerTurn.Text = gracz1 ? "X" : "O"; //tenary
        }

        private void CheckWin()

        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                WinMatch();
            }
            else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                WinMatch();
            }
            else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                WinMatch();
            }
            else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                WinMatch();
            }
            else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                WinMatch();
            }
            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                WinMatch();
            }
            else if (ruch > 8)
            {
                MessageBox.Show("Draw!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restart();
            }


        }

        private void WinMatch()
        {
            MessageBox.Show($"Player {lblPlayerTurn.Text} Wins!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (lblPlayerTurn.Text == "O")
            {

                resultO.Text = ((int.Parse(resultO.Text)) + 1).ToString();
            }
            else
            {

                resultX.Text = ((int.Parse(resultO.Text)) + 1).ToString();
            }
            Restart();
        }
    }
}
