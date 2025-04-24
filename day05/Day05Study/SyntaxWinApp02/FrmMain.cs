using System.Net.Http.Headers;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int add(int x, int y)
        {
            return x + y; // 한 줄짜리
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            // 대리자 = 람다식
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 6) + "\r\n";

            // SayHello 함수 생성 대신
            Action<string> sayHello = name => MessageBox.Show($"안녕, {name}", "인사", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            sayHello("여원");

            // LINQ 사용 이전
            List<int> resList = new List<int>();
            List<int> numbers = [9, 6, 4, 2, 7, 5, 8, 3, 10, 1];

            // 짝수만 추출해서 오름차순 정렬 하는 로직
            foreach (int n in numbers)
            {
                if (n % 2 == 0) // 2로 나눠서 나머지가 0이면 짝수
                {
                    resList.Add(n);
                }
            }

            TxtLog.Text += "전통 짝수리스트 > " + string.Join(" ", resList) + "\r\n";
            resList.Sort(); // 정렬
            TxtLog.Text += "전통 정렬된 짝수리스트 > " + string.Join(" ", resList) + "\r\n";

            // 기본 LINQ 방식 > 3줄로 위의 전통 방식 처리
            numbers = [11, 16, 20, 19, 15, 17, 13, 18, 12, 14];
            var resList2 = from n in numbers
                           where n % 2 == 0 // 짝수
                           orderby n
                           select n;

            TxtLog.Text += "LINQ1 정렬리스트 > " + string.Join(" ", resList2) + "\r\n";

            // LINQ Method Chaining
            numbers = [21, 26, 30, 29, 25, 27, 23, 28, 22, 24];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "LINQ2 정렬리스트 > " + string.Join(" ", resList3) + "\r\n";


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            //UI  초기화
            TxtTest.PlaceholderText = "테스트 입니다";
            TxtTest.Size = new Size(200, 23); // 이벤트를 만들어서 설정 줬음
            TxtTest.KeyPress += TxtTest_KeyPress;// Designer.cs에서 작업하는 것과 동일
            TxtTest.Font = new Font("휴먼매직체", 12, FontStyle.Italic);
        }

        private void TxtTest_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // ==13과 동일
            {
                MessageBox.Show("엔터키를 눌렀습니다", "키프레스",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            Print<int>(100);
            Print<float>(3.141562f);
            Print<string>("안녕하세요");
            Print<bool>(false);

            //생략가능 - 편의성을 위해서
            Print(200);
            Print<float>(6.141562f);
            Print<string>("안녕히 가세요");
            Print<bool>(true);
        
            //제네릭 클래스 사용
            Box<int> intBox = new Box<int>();
            intBox.Value = 300;
            intBox.Show();

        }

        
        public void Print<T>(T data) { Console.WriteLine(data); } 

    }
    // 제네릭 클래스
    public class Box<T> // where T : struct
    {
        public T Value { get; set; } // 속성
        //private T value; // 멤버변수

        public void Show()
        {

        //Console.WriteLine($"Box의 값 : {Value}");
        MessageBox.Show($"Box의 값 : {Value}", "제네릭 클래스",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
    }

}
