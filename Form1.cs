namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 1. 점수와 랜덤 객체를 클래스 레벨로 선언
        int score = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 3단계 미션: 도망갈 때 10점 감점
            score -= 10;

            // 1. 난수 생성기 준비
            Random rd = new Random();
            // 2. 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            // ClientSize는 타이틀 바와 테두리를 제외한 실제 흰 도화지 영역임
            // 버튼의 너비(Width)와 높이(Height)를 빼줘야 화면 밖으로 나가지 않음
            int maxX = this.ClientSize.Width - myTarget.Width;
            int maxY = this.ClientSize.Height - myTarget.Height;

            // 3. 랜덤 좌표 추출 (0 ~ 최대 가용치 사이)
            // 가용 영역이 0보다 큰 경우에만 실행 (창이 너무 작으면 오류 방지)
            if (maxX > 0 && maxY > 0)
            {
                int nextX = rd.Next(0, maxX);
                int nextY = rd.Next(0, maxY);

                // 4. 위치 할당 (새로운 Point 객체 생성)
                myTarget.Location = new Point(nextX, nextY);

                // 5. 시각적 피드백 (폼 제목 표시줄에 좌표와 점수 출력)
                this.Text = $"점수: {score} | 버튼 위치: ({nextX}, {nextY})";

                // 6. 추가: 마우스 커서를 손 모양(Hand)으로 변경
                myTarget.Cursor = Cursors.Hand;

                // 7. 추가: 도망갈 때 효과음 (윈도우 시스템 소리)
                System.Media.SystemSounds.Asterisk.Play();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 3단계 미션: 잡았을 때 100점 추가
            score += 100;

            // 3단계 미션: 난이도 조절 - 버튼 크기를 10% 축소 (현재의 90%로 설정)
            // int로 형변환 필요 (크기는 정수여야 함)
            myTarget.Width = (int)(myTarget.Width * 0.9);
            myTarget.Height = (int)(myTarget.Height * 0.9);

            // 추가: 버튼이 작아지면 글자 크기도 똑같이 10% 축소
            // 최소 글자 크기를 5pt로 제한하여 가독성 유지
            float newFontSize = myTarget.Font.Size * 0.9f;
            if (newFontSize < 5f) newFontSize = 5f;
            myTarget.Font = new Font(myTarget.Font.FontFamily, newFontSize, myTarget.Font.Style);

            // 5. 시각적 피드백 (폼 제목 표시줄 업데이트)
            this.Text = $"점수: {score} | 버튼을 잡았습니다!";

            // 2단계 미션: 잡았을 때 효과음 + 메시지 박스 띄우기
            System.Media.SystemSounds.Exclamation.Play();
            MessageBox.Show("축하합니다~!");
        }

        
        
    }
}