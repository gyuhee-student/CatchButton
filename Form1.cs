using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 1. 점수와 랜덤 객체를 클래스 레벨로 선언
        int score = 1000;
        int missCount = 0; // 4단계: 놓친 횟수 카운트
        Random random = new Random();

        // 초기 상태 저장을 위한 변수들
        Size initialSize;
        Font initialFont;
        Point initialLocation;
        Button btnReset; // 4단계: 다시 시작 버튼

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기 상태 저장
            initialSize = myTarget.Size;
            initialFont = myTarget.Font;
            initialLocation = myTarget.Location;

            // 다시 시작 버튼 설정 (코드 기반 생성)
            btnReset = new Button();
            btnReset.Text = "다시 시작";
            btnReset.Size = new Size(120, 50);
            btnReset.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            // 폼 중앙 배치
            btnReset.Location = new Point((this.ClientSize.Width - btnReset.Width) / 2, (this.ClientSize.Height - btnReset.Height) / 2);
            btnReset.Visible = false; // 처음엔 안 보임
            btnReset.Click += BtnReset_Click;
            this.Controls.Add(btnReset);
            
            this.Text = "버튼 잡기 게임을 시작합니다!";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 게임 오버 상태면 실행 안 함
            if (missCount >= 30) return;

            // 3단계 미션: 도망갈 때 10점 감점 및 횟수 증가
            score -= 10;
            missCount++;

            // 1. 난수 생성기 준비 (내용pdf 4단계 참고)
            Random rd = new Random();
            
            // 2. 가용 영역 계산 (내용pdf 4단계 참고)
            // ClientSize는 타이틀 바와 테두리를 제외한 실제 작업 영역임
            int maxX = this.ClientSize.Width - myTarget.Width;
            int maxY = this.ClientSize.Height - myTarget.Height;

            // 3. 랜덤 좌표 추출
            if (maxX > 0 && maxY > 0)
            {
                int nextX = rd.Next(0, maxX);
                int nextY = rd.Next(0, maxY);

                // 4. 위치 할당 (내용pdf 4단계 참고)
                myTarget.Location = new Point(nextX, nextY);

                // 5. 시각적 피드백 (제목 표시줄 업데이트 - 내용pdf 5단계 참고)
                this.Text = $"점수: {score} | 놓친 횟수: {missCount}/30 | 위치: ({nextX}, {nextY})";

                // 추가 피드백: 커서와 소리
                myTarget.Cursor = Cursors.Hand;
                System.Media.SystemSounds.Asterisk.Play();
            }

            // 4단계: 30번 놓치면 게임 오버
            if (missCount >= 30)
            {
                myTarget.Enabled = false;
                btnReset.Visible = true;
                btnReset.BringToFront(); // 버튼을 맨 앞으로
                this.Text = "Game Over!";
                MessageBox.Show("30번을 놓쳤습니다. Game Over!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 3단계 미션: 잡았을 때 100점 추가
            score += 100;

            // 3단계 미션: 난이도 조절 - 버튼 크기를 10% 축소
            myTarget.Width = (int)(myTarget.Width * 0.9);
            myTarget.Height = (int)(myTarget.Height * 0.9);

            // 글자 크기도 같이 축소하여 가독성 유지
            float newFontSize = myTarget.Font.Size * 0.9f;
            if (newFontSize < 5f) newFontSize = 5f;
            myTarget.Font = new Font(myTarget.Font.FontFamily, newFontSize, myTarget.Font.Style);

            // 5. 시각적 피드백
            this.Text = $"점수: {score} | 버튼을 잡았습니다!";

            // 2단계 미션: 효과음 + 메시지 박스
            System.Media.SystemSounds.Exclamation.Play();
            MessageBox.Show("축하합니다~!");
        }

        // 4단계: 다시 시작 기능 구현
        private void BtnReset_Click(object sender, EventArgs e)
        {
            score = 1000;
            missCount = 0;
            
            // 버튼 상태 복구
            myTarget.Enabled = true;
            myTarget.Size = initialSize;
            myTarget.Font = initialFont;
            myTarget.Location = initialLocation;
            
            // UI 초기화
            btnReset.Visible = false;
            this.Text = "게임을 다시 시작합니다!";
        }
    }
}
