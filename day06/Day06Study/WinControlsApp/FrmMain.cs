namespace WinControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //os 전체 폰트 가져오기
            var Fonts = FontFamily.Families;
            foreach (var Font in Fonts)
            {
                // 폰트 이름을 콤보박스에 추가
                CboFonts.Items.Add(Font.Name);
            }

            LblState.Text = "상태 : 폰트 읽기 완료!";

            //툴팁  -> 눌렸을 때 무엇을 나타내는지 설명을 보여주는 것
            toolTip1.SetToolTip(BtnModal, "모달창 연습 버튼입니다.");
            toolTip1.SetToolTip(TxtYear, " 달력 선택 년도 표시 텍스트 박스입니다");

        }
        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }


        //ChangeFont 메서드 : 폰트 변경
        private void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0) return; // 선택된 폰트가 없으면 리턴
            FontStyle style = FontStyle.Regular; // 기본 폰트 스타일

            if (ChkBold.Checked) style |= FontStyle.Bold; // FontStyle.Regular | FontStyle.Bold  => 0000 | 0001 = 0001 (즉, 글자가 볼드체로 변환)
                                                          // Bold 체크박스가 체크되면 Bold 스타일 추가

            if (ChkItalic.Checked) style |= FontStyle.Italic; // 0001 | 0010 = 0011 (즉, 글자가 이탤릭체로 변환)
                                                              // Italic 체크박스가 체크되면 Italic 스타일 추가

            // CboFonts에서 선택된 글자로, 글자크기12, 글자체 스타일 적용
            TxtResult.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PrgProcess.Value = TrbProcess.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "모달창";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.LightPink;
            frmModal.StartPosition = FormStartPosition.CenterParent; //  부모창의 정중앙
            frmModal.ShowDialog(); // 모달창 띄우기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frmModaless = new Form();
            frmModaless.Text = "모달창";
            frmModaless.Width = 300;
            frmModaless.Height = 100;
            frmModaless.BackColor = Color.LightBlue;
            //모달리스창을 모달창처럼 메인창 정중앙에 위치하려면 계산필요
            frmModaless.StartPosition = FormStartPosition.Manual; // 수동으로 위치 지정
            frmModaless.Location = new Point(this.Location.X + (this.Width - frmModaless.Width) / 2,
                                            this.Location.Y + (this.Height - frmModaless.Height) / 2); // 부모창의 정중앙에 위치하도록 계산하여 지정
            frmModaless.Show(this); // 모달리스창 띄우기

        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // 메세지박스 -> 모달창
            MessageBox.Show(TxtResult.Text, "텍스트박스 문장~!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            TrvDummy.Nodes.Add(rand.Next().ToString());
            TreeToList(); // 트리뷰를 리스트뷰로 변환
        }

        private void BtnNode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("노드를 선택하세요", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand(); //  트리확장 Expand,  트리축소 Collapse
            TreeToList();
        }

        private void TreeToList()
        {
            LsvDummy.Items.Clear(); // 리스트뷰 초기화
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            ListViewItem item = new ListViewItem(
                    new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() });
            item.ImageIndex = 0; // 아이템의 이미지 인덱스 설정
            LsvDummy.Items.Add(item);
            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode); //재귀호출(Recursive call)
            }
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "이미지 열기";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp; *.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom; // PictureBoxSizeMode.Zoom 이미지 원본대로 볼 수 있는 모드
                // PictureBoxSizeMode.StretchImage 이미지가 넓이, 높이를 픽처박스 크기에 맞춰서 이미지가 일그러짐  
            }
        }

        private void CalSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(CalSchedule.SelectionStart.ToString());
            TxtYear.Text = CalSchedule.SelectionStart.Year.ToString();
            TxtMonth.Text = CalSchedule.SelectionStart.Month.ToString();
            TxtDay.Text = CalSchedule.SelectionStart.Day.ToString();
        }

        private void DtpBirth_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing; // 아래의 폼 클로징이벤트 핸들러 제거 -> 종료 1번에 가능
                Application.Exit(); // 프로그램 완전 종료
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // 종료 취소
            }
        }

        private void LblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.naver.com",
                UseShellExecute = true,

            });
        }
    
    }

}
