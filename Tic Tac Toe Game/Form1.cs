using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {   
        String player = "O";
        public Form1()
        {
            InitializeComponent();
        }
        private void A1_Click(object sender, EventArgs e)
        { 
            A1.Text = TicTacToeLetter();
            A1.Enabled = false;
        }
        private void A2_Click(object sender, EventArgs e)
        {
            A2.Text = TicTacToeLetter();
            A2.Enabled = false;
        }
        private void A3_Click(object sender, EventArgs e)
        {
            A3.Text = TicTacToeLetter();
            A3.Enabled = false;
        }
        private void B3_Click(object sender, EventArgs e)
        { 
            B3.Text = TicTacToeLetter();
            B3.Enabled = false;
        }
        private void B1_Click(object sender, EventArgs e)
        {
            B1.Text = TicTacToeLetter();
            B1.Enabled = false;
        }
        private void B2_Click(object sender, EventArgs e)
        {
            B2.Text = TicTacToeLetter();
            B2.Enabled = false;
        }
        private void C1_Click(object sender, EventArgs e)
        {
            C1.Text = TicTacToeLetter();
            C1.Enabled = false;
        }
        private void C2_Click(object sender, EventArgs e)
        {
            C2.Text = TicTacToeLetter();
            C2.Enabled = false;
        }
        private void C3_Click(object sender, EventArgs e)
        {
            C3.Text = TicTacToeLetter();
            C3.Enabled = false;
        }
        private String TicTacToeLetter()
        {
            if (player == "X")
            {
                player = "O";
            }
            else
            {
                player = "X";
            }
            checkForWinner();
            return player;
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
        }
        private void checkForWinner()
        {
            bool winner = false;       
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                winner = true;

            if (winner)
            {
                MessageBox.Show("There's alrady a Winner! Congrats!");
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
            }
        }
    }
}
