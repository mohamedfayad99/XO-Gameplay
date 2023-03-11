using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame
{
    public partial class Bordform : Form
    {
        private int[,] bord;
        private int curentplayer;
        private int p1score;
        private int p2score;
        public Bordform(string plaername1, string playername2)
        {
            InitializeComponent();
            labP1.Text = plaername1;
            labP2.Text = playername2;
        }
        private void Bordform_Load(object sender, EventArgs e)
        {
            bord = new int[3, 3];
            curentplayer = 1;
            p1score = 0;
            p2score = 0;
        }

        private bool IsWinner(int Player)
        {
            bool win = false;
            #region  Rows
            for (int i = 0; i < 3; i++)
            {
                win = true;
                for (int j = 0; j < 3; j++)
                {
                    if (bord[i, j] != Player) win = false;
                }
                if (win) return true;

            }
            #endregion

            #region Colums
            //check Colums
            for (int i = 0; i < 3; i++)
            {
                win = true;
                for (int j = 0; j < 3; j++)
                {
                    if (bord[j, i] != Player) win = false;
                }
                if (win) { return true; }

            }
            // /diagonal
            win = true;
            for (int i = 0; i < 3; i++)
            {

                if (bord[i, i] != Player) win = false;
            }
            if (win) { return true; }


            //  \diagonal
            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (bord[i, (Math.Abs(i - 2))] != Player) win = false;
            }
            if (win) { return true; }
            return false;
        }
        #endregion

        private bool IsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (bord[i, j] == 0) return false;
                }

            }
            return true;
        }

        private void Disaple()
        {
            btn00.Enabled = false;
            btn01.Enabled = false;
            btn02.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn20.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;

        }
        private void Enable()
        {
            btn00.Enabled = true;
            btn01.Enabled = true;
            btn02.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;

        }
        private void IsApply(int row, int col)
        {
            bord[row, col] = curentplayer;
            bool iswiner = IsWinner(curentplayer);
            if (iswiner)
            {
                MessageBox.Show($"the Winer is : {(curentplayer == 1 ? labP1.Text : labP2.Text)}");
                if (curentplayer == 1)
                {
                    p1score++;
                    txtP1Score.Text = p1score.ToString();
                }
                else
                {
                    p2score++;
                    txtP2Score.Text = p2score.ToString();

                }
                Disaple();
            }
            else
            {
                bool isfull = IsFull();
                if (isfull)
                {
                    MessageBox.Show("No One Is Wins");
                    Disaple();
                }
                else
                {
                    curentplayer = curentplayer == 1 ? 2 : 1;
                }
            }

        }
        private void btn00_Click(object sender, EventArgs e)
        {
            btn00.Text = curentplayer == 1 ? "X" : "O";
            IsApply(0, 0);
            btn00.Enabled = false;
        }
        private void btn01_Click(object sender, EventArgs e)
        {
            btn01.Text = curentplayer == 1 ? "X" : "O";
            IsApply(0, 1);
            btn01.Enabled = false;

        }

        private void btn02_Click(object sender, EventArgs e)
        {
            btn02.Text = curentplayer == 1 ? "X" : "O";
            IsApply(0, 2);
            btn02.Enabled = false;

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            btn10.Text = curentplayer == 1 ? "X" : "O";
            IsApply(1, 0);
            btn10.Enabled = false;

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            btn11.Text = curentplayer == 1 ? "X" : "O";
            IsApply(1, 1);
            btn11.Enabled = false;

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            btn12.Text = curentplayer == 1 ? "X" : "O";
            IsApply(1, 2);
            btn12.Enabled = false;

        }

        private void btn20_Click(object sender, EventArgs e)
        {
            btn20.Text = curentplayer == 1 ? "X" : "O";
            IsApply(2, 0);
            btn20.Enabled = false;

        }

        private void btn21_Click(object sender, EventArgs e)
        {
            btn21.Text = curentplayer == 1 ? "X" : "O";
            IsApply(2, 1);
            btn21.Enabled = false;

        }

        private void btn22_Click(object sender, EventArgs e)
        {
            btn22.Text = curentplayer == 1 ? "X" : "O";
            IsApply(2, 2);
            btn22.Enabled = false;

        }

        private void Clear()
        {
            btn00.Text = string.Empty;
            btn01.Text = string.Empty;
            btn02.Text = string.Empty;
            btn10.Text = string.Empty;
            btn11.Text = string.Empty;
            btn12.Text = string.Empty;
            btn20.Text = string.Empty;
            btn21.Text = string.Empty;
            btn22.Text = string.Empty;
        }

        #region New Game Button
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            bord = new int[3, 3];
            curentplayer = 1;
            Clear();
            Enable();
        }

        private void btnNewGame_MouseMove(object sender, MouseEventArgs e)
        {

            btnNewGame.BackColor = Color.DarkGreen;
            btnNewGame.ForeColor = Color.White;

        }

        private void btnNewGame_MouseLeave(object sender, EventArgs e)
        {

            btnNewGame.BackColor = Color.SandyBrown;
            btnNewGame.ForeColor = Color.DarkGreen;
        }
        private void btnNewGame_KeyUp(object sender, KeyEventArgs e)
        {
            btnNewGame.BackColor = Color.DarkGreen;
            btnNewGame.ForeColor = Color.White;
        }
        private void btnNewGame_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            btnNewGame.BackColor = Color.SandyBrown;
            btnNewGame.ForeColor = Color.DarkGreen;
        }
        #endregion

        #region Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnNewGame_Click(null, null);
            p1score = 0;
            p2score = 0;
            txtP1Score.Text = "0";
            txtP2Score.Text = "0";
        }

        private void btnReset_MouseMove(object sender, MouseEventArgs e)
        {
            btnReset.BackColor = Color.Red;
            btnReset.ForeColor = Color.White;

        }
        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.SandyBrown;
            btnReset.ForeColor = Color.Red;
        }
        private void btnReset_KeyUp(object sender, KeyEventArgs e)
        {
            btnReset.BackColor = Color.Red;
            btnReset.ForeColor = Color.White;
        }
        private void btnReset_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            btnReset.BackColor = Color.SandyBrown;
            btnReset.ForeColor = Color.Red;
        }
        #endregion

        #region Return Button
        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Return_MouseLeave(object sender, EventArgs e)
        {
            Return.BackColor = Color.SandyBrown;
            Return.ForeColor = Color.Maroon;
        }

        private void Return_MouseMove(object sender, MouseEventArgs e)
        {
            Return.BackColor = Color.Maroon;
            Return.ForeColor = Color.White;
        }

        private void Return_KeyUp(object sender, KeyEventArgs e)
        {
            Return.BackColor = Color.Maroon;
            Return.ForeColor = Color.White;
        }
        private void Return_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Return.BackColor = Color.SandyBrown;
            Return.ForeColor = Color.Maroon;
        }



        #endregion


    }
}
