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
        //private bool dirtyBool;
        String player = "O";

        public Form1()
        {
            InitializeComponent();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            //if (dirtyBool)
            //{
            //    A3.Text = "O";
            //}
            //else
            //{
            //    A3.Text = "X";
            //}
            //dirtyBool = !dirtyBool;
            A3.Text = TicTacToeLetter();
            A3.Enabled = false;

        }

        private void A1_Click(object sender, EventArgs e)
        {
            //if (dirtyBool)
            //{
            //    A1.Text = "O";
            //}
            //else
            //{
            //    A1.Text = "X";
            //}
            //dirtyBool = !dirtyBool;

            A1.Text = TicTacToeLetter();
            A1.Enabled = false;
        }

        private void A2_Click(object sender, EventArgs e)
        {
            //if (dirtyBool)
            //{
            //    A2.Text = "O";
            //}
            //else
            //{
            //    A2.Text = "X";
            //}
            //dirtyBool = !dirtyBool;
            A2.Text = TicTacToeLetter();
            A2.Enabled = false;
        }


        private void B3_Click(object sender, EventArgs e)
        {
            //if (dirtyBool)
            //{
            //    B3.Text = "O";
            //}
            //else
            //{
            //    B3.Text = "X";
            //}
            //dirtyBool = !dirtyBool;
            B3.Text = TicTacToeLetter();
            B3.Enabled = false;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            //if (dirtyBool)
            //{
            //    B1.Text = "O";
            //}
            //else
            //{
            //    B1.Text = "X";
            //}
            //dirtyBool = !dirtyBool;
            B1.Text = TicTacToeLetter();
            B1.Enabled = false;
        }

        private void A1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void B2_Click(object sender, EventArgs e)
        {
            //if (dirtyBool)
            //{
            //    B2.Text = "O";
            //}
            //else
            //{
            //    B2.Text = "X";
            //}
            //dirtyBool = !dirtyBool;
            B2.Text = TicTacToeLetter();
            B2.Enabled = false;
        }

        private void C1_Click(object sender, EventArgs e)
        {
            //if (dirtyBool)
            //{
            //    C1.Text = "O";
            //}
            //else
            //{
            //    C1.Text = "X";
            //}
            //dirtyBool = !dirtyBool;
            C1.Text = TicTacToeLetter();
            C1.Enabled = false;
        }

        private void C2_Click(object sender, EventArgs e)
        {
            //if (dirtyBool)
            //{
            //    C2.Text = "O";
            //}
            //else
            //{
            //    C2.Text = "X";
            //}
            //dirtyBool = !dirtyBool;
            C2.Text = TicTacToeLetter();
            C2.Enabled = false;
        }

        private void C3_Click(object sender, EventArgs e)
        {
            //if (dirtyBool)
            //{
            //    C3.Text = "O";
            //}
            //else
            //{
            //    C3.Text = "X";
            //}
            //dirtyBool = !dirtyBool;
            C3.Text = TicTacToeLetter();
            C3.Enabled = false;
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
            return player;
        }

        
        


        
    }
}
