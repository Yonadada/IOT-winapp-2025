namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 배열 생성
            string[] fruits = { "사과", "바나나", "딸기", "망고", "블루베리" };

            CboArray.Items.AddRange(fruits); // 배열을 콤보박스에 할당
            CboArray.SelectedIndex = 0; // 첫 번째 항목 선택

            // 리스트 생성
            List<string> lFruits = new List<string>();
            lFruits.Append("용과");
            lFruits.Append("망고스틴");
            lFruits.Append("복숭아");
            lFruits.Append("짭짤이토마토");

        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectedItem은 object 타입이므로 string으로 변환
            string selected = CboArray.SelectedItem.ToString();
            MessageBox.Show($" 선택한 과일은 {selected} 입니다", "좋아하는 과일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        }
    }
}
