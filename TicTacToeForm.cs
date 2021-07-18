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
    public partial class TicTacToeForm : Form
    {
        private bool change = true;

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        //this is a click method for buttons, when clicking - display symbols
        private void button_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;

            //Display playes's symbol
            if (change)
            {
                but.Text = "X";
                but.Font = new Font("Times New Roman", 24);
                change = false;
            }
            else
            {
                but.Text = "O";
                but.Font = new Font("Times New Roman", 24);
                change = true;
            }



            //disable button that was clicked
            but.Enabled = false;

            winner();

        }

        private void winner()
        {

            String winner = "";

            //Detemine a winner
            if (change == false)
            {
                winner = "Player 1 = X";
            }
            else
            {
                winner = "Player 2 = O";
            }

            //Check all the possible outcomes of the game
            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "")
            {
                MessageBox.Show("WINNER: " + winner);
                System.Windows.Forms.Application.Exit();
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
            {
                MessageBox.Show("WINNER: " + winner);
                System.Windows.Forms.Application.Exit();
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
            {
                MessageBox.Show("WINNER: " + winner);
                System.Windows.Forms.Application.Exit();
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
            {
                MessageBox.Show("WINNER: " + winner);
                System.Windows.Forms.Application.Exit();
            }
            else if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "")
            {
                MessageBox.Show("WINNER: " + winner);
                System.Windows.Forms.Application.Exit();
            }
            else if (A2.Text == B2.Text && B2.Text == C2.Text && C2.Text != "")
            {
                MessageBox.Show("WINNER: " + winner);
                System.Windows.Forms.Application.Exit();
            }
            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
            {
                MessageBox.Show("WINNER: " + winner);
                System.Windows.Forms.Application.Exit();
            }
            else if (C3.Text == B2.Text && B2.Text == A1.Text && C3.Text != "")
            {
                MessageBox.Show("WINNER: " + winner);
                System.Windows.Forms.Application.Exit();
            }
            //This will check all controls available in group box and display a Tie message
            else if (groupBox1.Controls.OfType<Button>().All(b => !b.Enabled))
            {
                MessageBox.Show("TIE! Better luck next time");
                System.Windows.Forms.Application.Exit();
            }







        }
    }
}
