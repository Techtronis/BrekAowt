namespace BrékAowt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.popUp = new System.Windows.Forms.Label();
            this.topBox = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.scoreInt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lifeInt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBox)).BeginInit();
            this.SuspendLayout();
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.Color.White;
            this.paddle.Location = new System.Drawing.Point(369, 1100);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(219, 45);
            this.paddle.TabIndex = 59;
            this.paddle.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Cyan;
            this.ball.Location = new System.Drawing.Point(476, 751);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 60;
            this.ball.TabStop = false;
            // 
            // popUp
            // 
            this.popUp.AutoSize = true;
            this.popUp.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.popUp.ForeColor = System.Drawing.Color.White;
            this.popUp.Location = new System.Drawing.Point(272, 583);
            this.popUp.Name = "popUp";
            this.popUp.Size = new System.Drawing.Size(460, 65);
            this.popUp.TabIndex = 61;
            this.popUp.Text = "Press \'Space\' to start";
            // 
            // topBox
            // 
            this.topBox.BackColor = System.Drawing.Color.Gray;
            this.topBox.Location = new System.Drawing.Point(-3, 0);
            this.topBox.Name = "topBox";
            this.topBox.Size = new System.Drawing.Size(983, 88);
            this.topBox.TabIndex = 62;
            this.topBox.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Gray;
            this.score.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(16, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(156, 65);
            this.score.TabIndex = 63;
            this.score.Text = "Score:";
            // 
            // scoreInt
            // 
            this.scoreInt.AutoSize = true;
            this.scoreInt.BackColor = System.Drawing.Color.Gray;
            this.scoreInt.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreInt.Location = new System.Drawing.Point(159, 9);
            this.scoreInt.Name = "scoreInt";
            this.scoreInt.Size = new System.Drawing.Size(54, 65);
            this.scoreInt.TabIndex = 64;
            this.scoreInt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(655, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 65);
            this.label1.TabIndex = 65;
            this.label1.Text = "Lives left:";
            // 
            // lifeInt
            // 
            this.lifeInt.AutoSize = true;
            this.lifeInt.BackColor = System.Drawing.Color.Gray;
            this.lifeInt.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lifeInt.Location = new System.Drawing.Point(883, 9);
            this.lifeInt.Name = "lifeInt";
            this.lifeInt.Size = new System.Drawing.Size(54, 65);
            this.lifeInt.TabIndex = 66;
            this.lifeInt.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(978, 1157);
            this.Controls.Add(this.lifeInt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreInt);
            this.Controls.Add(this.score);
            this.Controls.Add(this.topBox);
            this.Controls.Add(this.popUp);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Name = "Form1";
            this.Text = "BrékAowt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox paddle;
        private System.Windows.Forms.Timer timer1;
        private PictureBox ball;
        private Label popUp;
        private PictureBox topBox;
        private Label score;
        private Label scoreInt;
        private Label label1;
        private Label lifeInt;
    }
}