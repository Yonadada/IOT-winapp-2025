using System.Threading.Tasks;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //async -> 비동기로 동작하는 메서드라고 선언의 의미
        //async, await는 항상 같이 사용
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            //* : ui 스레드가 관리
            LblCurrState.Text = " 현재 상태 : 진행";  //UI처리
            BtnStart.Text = "진행 중"; // UI처리
            BtnStart.Enabled = false; // 버튼 비활성화    //UI처리


            // 엄청난 시간이 걸리는 연산을 수행
            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;

            //await로 비동기 대기
            //UI와 전혀 관계없는 작업
            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)((i * 100) / MaxVal) + 1;
                    Console.WriteLine(progress.ToString());

                    //Task.Run 에 들어가는 UI 처리 로직은 
                    this.Invoke(new Action(() =>
                    {

                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length; // 텍스트박스의 마지막 위치로 이동
                        TxtLog.ScrollToCaret(); // 스크롤을 가장 아래로 이동
                        PrgProcess.Value = progress;

                    }));

                    Thread.Sleep(50); // 500ms 대기 (대량의 일을 처리하는 것 처럼)
                    // Application.DoEvents(); // 권장하지 않음
                }
            });


            LblCurrState.Text = " 현재 상태 : 중지"; //UI처리
            BtnStart.Text = "시작";   // UI처리
            BtnStart.Enabled = true; // 버튼 활성화
        }
    }
}
