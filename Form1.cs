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

                // 5. 시각적 피드백 (폼 제목 표시줄에 좌표 출력)
                this.Text = $"버튼 위치: ({nextX}, {nextY})";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}