namespace BrékAowt
{
    public partial class Form1 : Form
    {
        private int ballMoveX = 0;
        private int ballMoveY = 3;
        private int ballX;
        private int ballY;
        private int boxCount = 36;
        private bool gameOver = true;
        private int Score = 0;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Right) pX += 25;
            else if (e.KeyCode == Keys.Left) pX -= 25;

            if (gameOver && e.KeyCode == Keys.Space) gameOver = false;

            paddle.Location = new Point(pX, paddle.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
                    ballX = 476;
                    ballY = 751;
                    ballMoveX = 0;
                    ballMoveY = -3;
                    pX = 369;
                    pY = 1100;
                }
                else if (ball.Bounds.IntersectsWith(paddle.Bounds))
                {
                    if (ballMoveX == 0) ballMoveX = -3;
                    ballMoveY = -ballMoveY;
                }
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "pictureBox")
                    {
                        if (ball.Bounds.IntersectsWith(x.Bounds))
                        {
                            boxCount--;
                            Score++;
                            this.Controls.Remove(x);
                            ballMoveY = -ballMoveY;
                        }
                    }
                }

                if (boxCount == 0)
                {
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
                scoreInt.Text = Convert.ToString(Score);
                ball.Location = new Point(ballX, ballY);
            } else if (gameOver && boxCount == 0)
            {
                popUpText = "Oh no you lost.\nPress 'Space' to start again";
                popUp.Text = popUpText;
            }
        }
    }
}