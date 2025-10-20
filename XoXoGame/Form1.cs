using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XoXoGame.Properties;

namespace XoXoGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBoard();
        }

        int PlayCount = 0;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enWinner winnerPlayer = enWinner.Player1;
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            InProgress
        }

        private PictureBox[] getAllCells() => new[] { pB1, pB2, pB3, pB4, pB5, pB6, pB7, pB8, pB9 };

        private void InitializeBoard()
        {
            foreach (var cell in getAllCells())
            {
                cell.Click += OnCellClick;
            }
        }

        private void OnCellClick(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;
            HandlePlayerMove(cell);
            winnerPlayer = GetWinner();
            checkEndGame(winnerPlayer);

        }

        public void HandlePlayerMove(PictureBox btn)
        {
            if (btn.Tag.ToString() != "?")
            {
                MessageBox.Show("Wrong Choice", "Woring", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (PlayerTurn)
            {
                case enPlayer.Player1:
                    btn.Image = Resources.X;
                    player.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    btn.Tag = "X";
                    break;

                case enPlayer.Player2:
                    btn.Image = Resources.O;
                    player.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    btn.Tag = "O";
                    break;
            }
            PlayCount++;
        }

        enWinner GetWinner()
        {
            PictureBox[][] winPatterns = new[]
            {
                new[]{pB1, pB2, pB3},
                new[]{pB4, pB5, pB6},
                new[]{pB7, pB8, pB9},
                new[]{pB1, pB5, pB9},
                new[]{pB3, pB5, pB7},
                new[]{pB1, pB4, pB7},
                new[]{pB3, pB6, pB9},
                new[]{pB2, pB5, pB8}
            };

            foreach (PictureBox[] pattern in winPatterns)
            {
                if (IsWinningPattern(pattern))
                {
                    showGreenYellowBackGround(pattern);
                    return pattern[0].Tag.ToString() == "X"
                        ? enWinner.Player1
                        : enWinner.Player2;
                }
            }

            return PlayCount == 9
                ? enWinner.Draw
                : enWinner.InProgress;
        }

        void showGreenYellowBackGround(PictureBox[] cells)
        {
            cells[0].BackColor = Color.GreenYellow;
            cells[1].BackColor = Color.GreenYellow;
            cells[2].BackColor = Color.GreenYellow;
        }

        private bool IsWinningPattern(PictureBox[] cells)
        {
            string first = cells[0].Tag.ToString();
            return first != "?" && cells.All(c => c.Tag.ToString() == first);
        }
        void endGame()
        {
            foreach (var cell in getAllCells())
            {
                cell.Enabled = false;
            }
        }

        void checkEndGame(enWinner winner)
        {
            if (winner != enWinner.InProgress)
            {
                showMessageForWinner(winnerPlayer);
                endGame();
            }
        }
       
        void showMessageForWinner(enWinner win)
        {
            switch (win)
            {
                case enWinner.Player1:
                    lblProg.Text = "Player 1 Wins!";
                    MessageBox.Show("🎉 Player 1 Wins!", "Game Over",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;

                case enWinner.Player2:
                    lblProg.Text = "Player 2 Wins!";
                    MessageBox.Show("🎉 Player 2 Wins!", "Game Over",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;

                case enWinner.Draw:
                    lblProg.Text = "Draw";
                    MessageBox.Show("🤝 It's a Draw!", "Game Over",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
            }
            
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
           
            foreach(var cell in getAllCells())
            {
                cell.Enabled = true;
                cell.Tag = "?";
                cell.BackColor = Color.Transparent;
                cell.Image = Resources.question_mark_96;

            }

            PlayCount = 0;
            PlayerTurn = enPlayer.Player1;
            player.Text = "Plyer 1";
            lblProg.Text = "In Progress";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 400, 70, 400, 400);
            e.Graphics.DrawLine(pen, 510, 70, 510, 400);
            e.Graphics.DrawLine(pen, 290, 180, 620, 180);
            e.Graphics.DrawLine(pen, 290, 290, 620, 290);

        }
    }
}
