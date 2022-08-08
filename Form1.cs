namespace BrékAowt
{
    public partial class Form1 : Form
    {
        private int ballMoveX = 0;
        private int ballMoveY = 3;
        private int ballX;
        private int ballY;
        private int boxCount = 0;
        private bool gameOver = true;
        private int Score = 0;
        private int lives;
        private string popUpText = "Press 'Space' to Start";
        int pX = 369;
        int pY = 1100;
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            Cursor.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Right) pX += 25;
            else if (e.KeyCode == Keys.Left) pX -= 25;
            else if (gameOver && e.KeyCode == Keys.Space)
            {
                gameOver = false;
                boxCount = 36;
                lives = 3;
            }
            paddle.Location = new Point(pX, paddle.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random randX = new Random();
            ballX = ball.Location.X;
            ballY = ball.Location.Y;
            int ballSize = 20;
            if (gameOver == false)
            {
                if (ballX < 0 || ballX + ballSize >= this.ClientSize.Width) ballMoveX = -ballMoveX;
                else if (ballY < 0) ballMoveY = -ballMoveY;
                else if (ball.Bounds.IntersectsWith(topBox.Bounds))
                {
                    ballMoveY = -ballMoveY;
                }
                else if (ballY + ballSize >= this.ClientSize.Height)
                {
                    lives--;
                    ballX = 476;
                    ballY = 751;
                    ballMoveX = 0;
                    ballMoveY = 3;
                    pX = 369;
                    pY = 1100;
                }
                else if (ball.Bounds.IntersectsWith(paddle.Bounds))
                {
                    ballMoveX = randX.Next(-5, 5);
                    if (ballMoveX == 0) ballMoveX = -3;
                    ballMoveY = -3;
                }
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "pictureBox" && gameOver == false)
                    {
                        if (ball.Bounds.IntersectsWith(x.Bounds))
                        {
                            boxCount--;
                            Score++;
                            this.Controls.Remove(x);
                            ballMoveY = -ballMoveY;
                            
                        }
                    }
                    else if (x is PictureBox && x.Tag == "pictureBox" && gameOver == true)
                    {
                        this.Controls.Add(x);
                    }
                }

                if (boxCount == 0)
                {
                    boxCount = -1;
                    gameOver = true;
                    ballX = 476;
                    ballY = 751;
                    ballMoveX = 0;
                    ballMoveY = 0;
                }

                ballX += ballMoveX;
                ballY += ballMoveY;

                popUpText = "";
                popUp.Text = popUpText;
                lifeInt.Text = Convert.ToString(lives);
                scoreInt.Text = Convert.ToString(Score);
                ball.Location = new Point(ballX, ballY);
                if (lives == 0)
                {
                    gameOver = true;
                    boxCount = -2;
                }
            } else if (gameOver && boxCount == -1)
            {
                popUpText = "You won!\nPress 'Space' to start again";
                popUp.Text = popUpText;
            } else if (gameOver && boxCount == -2)
            {
                popUpText = "You lost!\nPress 'Space' to try again";
                popUp.Text = popUpText;
            }
            
        }
    }
}