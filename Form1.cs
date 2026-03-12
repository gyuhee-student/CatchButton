using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 1000;
        int missCount = 0;
        Random random = new Random();

        Size initialSize;
        Font initialFont;
        Point initialLocation;
        Button btnReset;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialSize = myTarget.Size;
            initialFont = myTarget.Font;
            initialLocation = myTarget.Location;

            btnReset = new Button();
            btnReset.Text = "다시 시작";
            btnReset.Size = new Size(120, 50);
            btnReset.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnReset.Location = new Point((this.ClientSize.Width - btnReset.Width) / 2, (this.ClientSize.Height - btnReset.Height) / 2);
            btnReset.Visible = false;
            btnReset.Click += BtnReset_Click;
            this.Controls.Add(btnReset);
            
            this.Text = "버튼 잡기 게임을 시작합니다!";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (missCount >= 30) return;

            score -= 10;
            missCount++;

            Random rd = new Random();
            
            int maxX = this.ClientSize.Width - myTarget.Width;
            int maxY = this.ClientSize.Height - myTarget.Height;

            if (maxX > 0 && maxY > 0)
            {
                int nextX = rd.Next(0, maxX);
                int nextY = rd.Next(0, maxY);

                myTarget.Location = new Point(nextX, nextY);

                this.Text = $"점수: {score} | 놓친 횟수: {missCount}/30 | 위치: ({nextX}, {nextY})";

                myTarget.Cursor = Cursors.Hand;
                System.Media.SystemSounds.Asterisk.Play();
            }

            if (missCount >= 30)
            {
                myTarget.Enabled = false;
                btnReset.Visible = true;
                btnReset.BringToFront();
                this.Text = "Game Over!";
                MessageBox.Show("30번을 놓쳤습니다. Game Over!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score += 100;

            myTarget.Width = (int)(myTarget.Width * 0.9);
            myTarget.Height = (int)(myTarget.Height * 0.9);

            float newFontSize = myTarget.Font.Size * 0.9f;
            if (newFontSize < 5f) newFontSize = 5f;
            myTarget.Font = new Font(myTarget.Font.FontFamily, newFontSize, myTarget.Font.Style);

            this.Text = $"점수: {score} | 버튼을 잡았습니다!";

            System.Media.SystemSounds.Exclamation.Play();
            MessageBox.Show("축하합니다~!");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            score = 1000;
            missCount = 0;
            
            myTarget.Enabled = true;
            myTarget.Size = initialSize;
            myTarget.Font = initialFont;
            myTarget.Location = initialLocation;
            
            btnReset.Visible = false;
            this.Text = "게임을 다시 시작합니다!";
        }
    }
}
