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
            return x + y; // �� ��¥��
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            // �븮�� = ���ٽ�
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 6) + "\r\n";

            // SayHello �Լ� ���� ���
            Action<string> sayHello = name => MessageBox.Show($"�ȳ�, {name}", "�λ�", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            sayHello("����");

            // LINQ ��� ����
            List<int> resList = new List<int>();
            List<int> numbers = [9, 6, 4, 2, 7, 5, 8, 3, 10, 1];

            // ¦���� �����ؼ� �������� ���� �ϴ� ����
            foreach (int n in numbers)
            {
                if (n % 2 == 0) // 2�� ������ �������� 0�̸� ¦��
                {
                    resList.Add(n);
                }
            }

            TxtLog.Text += "���� ¦������Ʈ > " + string.Join(" ", resList) + "\r\n";
            resList.Sort(); // ����
            TxtLog.Text += "���� ���ĵ� ¦������Ʈ > " + string.Join(" ", resList) + "\r\n";

            // �⺻ LINQ ��� > 3�ٷ� ���� ���� ��� ó��
            numbers = [11, 16, 20, 19, 15, 17, 13, 18, 12, 14];
            var resList2 = from n in numbers
                           where n % 2 == 0 // ¦��
                           orderby n
                           select n;

            TxtLog.Text += "LINQ1 ���ĸ���Ʈ > " + string.Join(" ", resList2) + "\r\n";

            // LINQ Method Chaining
            numbers = [21, 26, 30, 29, 25, 27, 23, 28, 22, 24];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "LINQ2 ���ĸ���Ʈ > " + string.Join(" ", resList3) + "\r\n";


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            //UI  �ʱ�ȭ
            TxtTest.PlaceholderText = "�׽�Ʈ �Դϴ�";
            TxtTest.Size = new Size(200, 23); // �̺�Ʈ�� ���� ���� ����
            TxtTest.KeyPress += TxtTest_KeyPress;// Designer.cs���� �۾��ϴ� �Ͱ� ����
            TxtTest.Font = new Font("�޸ո���ü", 12, FontStyle.Italic);
        }

        private void TxtTest_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // ==13�� ����
            {
                MessageBox.Show("����Ű�� �������ϴ�", "Ű������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            Print<int>(100);
            Print<float>(3.141562f);
            Print<string>("�ȳ��ϼ���");
            Print<bool>(false);

            //�������� - ���Ǽ��� ���ؼ�
            Print(200);
            Print<float>(6.141562f);
            Print<string>("�ȳ��� ������");
            Print<bool>(true);
        
            //���׸� Ŭ���� ���
            Box<int> intBox = new Box<int>();
            intBox.Value = 300;
            intBox.Show();

        }

        
        public void Print<T>(T data) { Console.WriteLine(data); } 

    }
    // ���׸� Ŭ����
    public class Box<T> // where T : struct
    {
        public T Value { get; set; } // �Ӽ�
        //private T value; // �������

        public void Show()
        {

        //Console.WriteLine($"Box�� �� : {Value}");
        MessageBox.Show($"Box�� �� : {Value}", "���׸� Ŭ����",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
    }

}
