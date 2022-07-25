using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crossesAndZeros
{
    public partial class trainForm : Form
    {
        public trainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool prevSymb = false;
        private int clickCounter = 0;

        private void ChangeChoise(string whatButton)
        {
            clickCounter++;
            if (prevSymb == false)
            {
                ChangeButtonCaption(whatButton, "X");
                prevSymb = true;
            }
            else
            {
                ChangeButtonCaption(whatButton, "O");
                prevSymb = false;
            }
        }
        private void ChangeButtonCaption(string whatButton, string symb)
        {
            if (whatButton == "b1")
            {
                b1.Text = symb;
                FindWinner(symb);
            }
            else if (whatButton == "b2")
            {
                b2.Text = symb;
                FindWinner(symb);
            }
            else if (whatButton == "b3")
            {
                b3.Text = symb;
                FindWinner(symb);
            }
            else if (whatButton == "b4")
            {
                b4.Text = symb;
                FindWinner(symb);
            }
            else if (whatButton == "b5")
            {
                b5.Text = symb;
                FindWinner(symb);
            }
            else if (whatButton == "b6")
            {
                b6.Text = symb;
                FindWinner(symb);
            }
            else if (whatButton == "b7")
            {
                b7.Text = symb;
                FindWinner(symb);
            }
            else if (whatButton == "b8")
            {
                b8.Text = symb;
                FindWinner(symb);
            }
            else if (whatButton == "b9")
            {
                b9.Text = symb;
                FindWinner(symb);
            }
        }

        private void FindWinner(string symb)
        {
            //horizontal
            if (b1.Text == symb && b2.Text == symb && b3.Text == symb)
            {
                MessageBox.Show($"Winner is {symb} !!!");
                Application.Restart();
            }
            if (b4.Text == symb && b5.Text == symb && b6.Text == symb)
            {
                MessageBox.Show($"Winner is {symb} !!!");
                Application.Restart();
            }
            if (b7.Text == symb && b8.Text == symb && b9.Text == symb)
            {
                MessageBox.Show($"Winner is {symb} !!!");
                Application.Restart();
            }
            //vertical
            if (b1.Text == symb && b4.Text == symb && b7.Text == symb)
            {
                MessageBox.Show($"Winner is {symb} !!!");
                Application.Restart();
            }
            if (b2.Text == symb && b5.Text == symb && b8.Text == symb)
            {
                MessageBox.Show($"Winner is {symb} !!!");
                Application.Restart();
            }
            if (b3.Text == symb && b6.Text == symb && b9.Text == symb)
            {
                MessageBox.Show($"Winner is {symb} !!!");
                Application.Restart();
            }
            //leftToRight
            if (b1.Text == symb && b5.Text == symb && b9.Text == symb)
            {
                MessageBox.Show($"Winner is {symb} !!!");
                Application.Restart();
            }
            //rightToLeft
            if (b3.Text == symb && b5.Text == symb && b7.Text == symb)
            {
                MessageBox.Show($"Winner is {symb} !!!");
                Application.Restart();
            }
            //nobodyWon
            if (clickCounter == 9)
            {
                MessageBox.Show($"Nobody won *_* ");
                Application.Restart();
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.BackColor = Color.Aquamarine;
            ChangeChoise("b1");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.BackColor = Color.Aquamarine;
            ChangeChoise("b2");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.BackColor = Color.Aquamarine;
            ChangeChoise("b3");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.BackColor = Color.Aquamarine;
            ChangeChoise("b4");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.BackColor = Color.Aquamarine;
            ChangeChoise("b5");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.BackColor = Color.Aquamarine;
            ChangeChoise("b6");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.BackColor = Color.Aquamarine;
            ChangeChoise("b7");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.BackColor = Color.Aquamarine;
            ChangeChoise("b8");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.BackColor = Color.Aquamarine;
            ChangeChoise("b9");
        }

        private void trainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Let's play :/\nYou start from X");
        }
    }
}
