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
            // �迭 ����
            string[] fruits = { "���", "�ٳ���", "����", "����", "��纣��" };

            CboArray.Items.AddRange(fruits); // �迭�� �޺��ڽ��� �Ҵ�
            CboArray.SelectedIndex = 0; // ù ��° �׸� ����

            // ����Ʈ ����
            List<string> lFruits = new List<string>();
            lFruits.Append("���");
            lFruits.Append("����ƾ");
            lFruits.Append("������");
            lFruits.Append("¬©���丶��");

        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectedItem�� object Ÿ���̹Ƿ� string���� ��ȯ
            string selected = CboArray.SelectedItem.ToString();
            MessageBox.Show($" ������ ������ {selected} �Դϴ�", "�����ϴ� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        }
    }
}
