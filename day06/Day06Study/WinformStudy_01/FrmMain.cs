namespace WinformStudy_01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //�α��� Ȯ�ι�ư
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string userId = TxtId.Text;
            string userPw = TxtPw.Text;

            //�α��� ���� ��� TxtState
            TxtState.Text = $"ID : {TxtId.Text} \r\nPassword : {TxtPw.Text}";

            //�α��� ���� ���� (����)
            if(userId.ToLower() == "yeowon" || userPw == "1234")
            {
                MessageBox.Show(BtnCheck.Text,"�α���",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(BtnCheck.Text, "�α���",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }


        }

       
    }
}
