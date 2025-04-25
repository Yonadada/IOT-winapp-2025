namespace WinformStudy_01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //로그인 확인버튼
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string userId = TxtId.Text;
            string userPw = TxtPw.Text;

            //로그인 정보 출력 TxtState
            TxtState.Text = $"ID : {TxtId.Text} \r\nPassword : {TxtPw.Text}";

            //로그인 정보 저장 (수동)
            if(userId.ToLower() == "yeowon" || userPw == "1234")
            {
                MessageBox.Show(BtnCheck.Text,"로그인",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(BtnCheck.Text, "로그인",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }


        }

       
    }
}
