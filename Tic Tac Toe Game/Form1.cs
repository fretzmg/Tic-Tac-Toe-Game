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
        private bool dirtyBool;

        public Form1()
        {
            InitializeComponent();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (dirtyBool)
            {
                A3.Text = "O";
            }
            else
            {
                A3.Text = "X";
            }
            dirtyBool = !dirtyBool;
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (dirtyBool)
            {
                A1.Text = "O";
            }
            else
            {
                A1.Text = "X";
            }
            dirtyBool = !dirtyBool;
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (dirtyBool)
            {
                A2.Text = "O";
            }
            else
            {
                A2.Text = "X";
            }
            dirtyBool = !dirtyBool;
        }


        private void B3_Click(object sender, EventArgs e)
        {
            if (dirtyBool)
            {
                B3.Text = "O";
            }
            else
            {
                B3.Text = "X";
            }
            dirtyBool = !dirtyBool;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (dirtyBool)
            {
                B1.Text = "O";
            }
            else
            {
                B1.Text = "X";
            }
            dirtyBool = !dirtyBool;
        }

        private void A1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (dirtyBool)
            {
                B2.Text = "O";
            }
            else
            {
                B2.Text = "X";
            }
            dirtyBool = !dirtyBool;
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (dirtyBool)
            {
                C1.Text = "O";
            }
            else
            {
                C1.Text = "X";
            }
            dirtyBool = !dirtyBool;
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (dirtyBool)
            {
                C2.Text = "O";
            }
            else
            {
                C2.Text = "X";
            }
            dirtyBool = !dirtyBool;
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (dirtyBool)
            {
                C3.Text = "O";
            }
            else
            {
                C3.Text = "X";
            }
            dirtyBool = !dirtyBool;
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
        }
    }
}
