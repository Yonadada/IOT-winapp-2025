using System.Threading.Tasks;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //async -> �񵿱�� �����ϴ� �޼����� ������ �ǹ�
        //async, await�� �׻� ���� ���
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            //* : ui �����尡 ����
            LblCurrState.Text = " ���� ���� : ����";  //UIó��
            BtnStart.Text = "���� ��"; // UIó��
            BtnStart.Enabled = false; // ��ư ��Ȱ��ȭ    //UIó��


            // ��û�� �ð��� �ɸ��� ������ ����
            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;

            //await�� �񵿱� ���
            //UI�� ���� ������� �۾�
            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)((i * 100) / MaxVal) + 1;
                    Console.WriteLine(progress.ToString());

                    //Task.Run �� ���� UI ó�� ������ 
                    this.Invoke(new Action(() =>
                    {

                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length; // �ؽ�Ʈ�ڽ��� ������ ��ġ�� �̵�
                        TxtLog.ScrollToCaret(); // ��ũ���� ���� �Ʒ��� �̵�
                        PrgProcess.Value = progress;

                    }));

                    Thread.Sleep(50); // 500ms ��� (�뷮�� ���� ó���ϴ� �� ó��)
                    // Application.DoEvents(); // �������� ����
                }
            });


            LblCurrState.Text = " ���� ���� : ����"; //UIó��
            BtnStart.Text = "����";   // UIó��
            BtnStart.Enabled = true; // ��ư Ȱ��ȭ
        }
    }
}
