namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();

            // 1. 이동 범위 제한 (사진의 4번 항목)
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;

            // 2. 랜덤 좌표 생성
            int nextX = random.Next(0, maxX);
            int nextY = random.Next(0, maxY);

            // 3. 버튼 이동
            button1.Location = new Point(nextX, nextY);

            // 4. 폼 제목에 좌표 표시 (사진의 3번 항목)
            this.Text = $"X: {button1.Location.X}, Y: {button1.Location.Y}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
