namespace WinControlsApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuNewFile = new ToolStripMenuItem();
            MnuExit = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            TxtResult = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupbox2 = new GroupBox();
            BtnOpenImage = new Button();
            PicImage = new PictureBox();
            groupBox3 = new GroupBox();
            BtnCheck = new Button();
            DtpBirth = new DateTimePicker();
            LblUrl = new LinkLabel();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            CalSchedule = new MonthCalendar();
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            groupBox4 = new GroupBox();
            PrgProcess = new ProgressBar();
            TrbProcess = new TrackBar();
            groupBox5 = new GroupBox();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox6 = new GroupBox();
            button1 = new Button();
            BtnRoot = new Button();
            LsvDummy = new ListView();
            imageList1 = new ImageList(components);
            TrvDummy = new TreeView();
            DlgOpenImage = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            groupBox3.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.InactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuNewFile, MnuExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(F)";
            // 
            // MnuNewFile
            // 
            MnuNewFile.Name = "MnuNewFile";
            MnuNewFile.Size = new Size(119, 22);
            MnuNewFile.Text = "새 글(&N)";
            // 
            // MnuExit
            // 
            MnuExit.Name = "MnuExit";
            MnuExit.Size = new Size(119, 22);
            MnuExit.Text = "종료(&X)";
            MnuExit.Click += MnuExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "일반 컨트롤";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(15, 62);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(349, 21);
            TxtResult.TabIndex = 3;
            TxtResult.Text = "SampleText";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("나눔고딕", 9F, FontStyle.Italic);
            ChkItalic.Location = new Point(281, 25);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(59, 18);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("나눔고딕", 9F, FontStyle.Bold);
            ChkBold.Location = new Point(225, 25);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(50, 18);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "볼드";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(50, 23);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(169, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(29, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트";
            // 
            // groupbox2
            // 
            groupbox2.Controls.Add(BtnOpenImage);
            groupbox2.Controls.Add(PicImage);
            groupbox2.Location = new Point(400, 27);
            groupbox2.Name = "groupbox2";
            groupbox2.Size = new Size(383, 509);
            groupbox2.TabIndex = 3;
            groupbox2.TabStop = false;
            groupbox2.Text = "픽쳐박스";
            // 
            // BtnOpenImage
            // 
            BtnOpenImage.Location = new Point(277, 469);
            BtnOpenImage.Name = "BtnOpenImage";
            BtnOpenImage.Size = new Size(100, 30);
            BtnOpenImage.TabIndex = 2;
            BtnOpenImage.Text = "이미지열기";
            BtnOpenImage.UseVisualStyleBackColor = true;
            BtnOpenImage.Click += BtnOpenImage_Click;
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.ControlLight;
            PicImage.Location = new Point(6, 20);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(371, 443);
            PicImage.SizeMode = PictureBoxSizeMode.CenterImage;
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnCheck);
            groupBox3.Controls.Add(DtpBirth);
            groupBox3.Controls.Add(LblUrl);
            groupBox3.Controls.Add(TxtDay);
            groupBox3.Controls.Add(TxtMonth);
            groupBox3.Controls.Add(TxtYear);
            groupBox3.Controls.Add(CalSchedule);
            groupBox3.Location = new Point(789, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 509);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "기타 컨트롤";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(260, 182);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 40);
            BtnCheck.TabIndex = 4;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // DtpBirth
            // 
            DtpBirth.Location = new Point(14, 201);
            DtpBirth.Name = "DtpBirth";
            DtpBirth.Size = new Size(200, 21);
            DtpBirth.TabIndex = 3;
            DtpBirth.ValueChanged += DtpBirth_ValueChanged;
            // 
            // LblUrl
            // 
            LblUrl.AutoSize = true;
            LblUrl.Location = new Point(12, 234);
            LblUrl.Name = "LblUrl";
            LblUrl.Size = new Size(40, 14);
            LblUrl.TabIndex = 2;
            LblUrl.TabStop = true;
            LblUrl.Text = "네이버";
            LblUrl.LinkClicked += LblUrl_LinkClicked;
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(263, 80);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(88, 21);
            TxtDay.TabIndex = 1;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(263, 53);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(88, 21);
            TxtMonth.TabIndex = 1;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(263, 26);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(88, 21);
            TxtYear.TabIndex = 1;
            // 
            // CalSchedule
            // 
            CalSchedule.FirstDayOfWeek = Day.Monday;
            CalSchedule.Location = new Point(12, 26);
            CalSchedule.Name = "CalSchedule";
            CalSchedule.TabIndex = 0;
            CalSchedule.DateChanged += CalSchedule_DateChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.InactiveCaption;
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.Name = "LblState";
            LblState.Size = new Size(90, 17);
            LblState.Text = "상태 : 일반상태";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(PrgProcess);
            groupBox4.Controls.Add(TrbProcess);
            groupBox4.Location = new Point(12, 133);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(383, 113);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "트랙바";
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(15, 71);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(349, 23);
            PrgProcess.TabIndex = 1;
            // 
            // TrbProcess
            // 
            TrbProcess.Location = new Point(15, 20);
            TrbProcess.Maximum = 100;
            TrbProcess.Name = "TrbProcess";
            TrbProcess.Size = new Size(349, 45);
            TrbProcess.TabIndex = 0;
            TrbProcess.TickFrequency = 10;
            TrbProcess.Scroll += trackBar1_Scroll;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnMsgBox);
            groupBox5.Controls.Add(BtnModaless);
            groupBox5.Controls.Add(BtnModal);
            groupBox5.Location = new Point(12, 261);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(383, 100);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "모달, 모달리스트";
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(250, 38);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(100, 30);
            BtnMsgBox.TabIndex = 2;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(134, 38);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(100, 30);
            BtnModaless.TabIndex = 1;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(15, 38);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(100, 30);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(BtnRoot);
            groupBox6.Controls.Add(LsvDummy);
            groupBox6.Controls.Add(TrvDummy);
            groupBox6.Location = new Point(12, 367);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(383, 169);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "트리뷰, 리스트뷰";
            // 
            // button1
            // 
            button1.Location = new Point(277, 129);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 2;
            button1.Text = "노드추가";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnNode_Click;
            // 
            // BtnRoot
            // 
            BtnRoot.Location = new Point(175, 129);
            BtnRoot.Name = "BtnRoot";
            BtnRoot.Size = new Size(100, 30);
            BtnRoot.TabIndex = 2;
            BtnRoot.Text = "루트추가";
            BtnRoot.UseVisualStyleBackColor = true;
            BtnRoot.Click += BtnRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.LargeImageList = imageList1;
            LsvDummy.Location = new Point(189, 20);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(188, 103);
            LsvDummy.SmallImageList = imageList1;
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.SmallIcon;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder-normal.png");
            // 
            // TrvDummy
            // 
            TrvDummy.ImageIndex = 0;
            TrvDummy.ImageList = imageList1;
            TrvDummy.Location = new Point(6, 20);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.SelectedImageIndex = 0;
            TrvDummy.Size = new Size(177, 103);
            TrvDummy.TabIndex = 0;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1184, 561);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox3);
            Controls.Add(groupbox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("나눔고딕", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UI 컨트롤 예제 윈앱";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private GroupBox groupbox2;
        private GroupBox groupBox3;
        private StatusStrip statusStrip1;
        private ComboBox CboFonts;
        private Label label1;
        private CheckBox ChkBold;
        private TextBox TxtResult;
        private CheckBox ChkItalic;
        private ToolStripStatusLabel LblState;
        private GroupBox groupBox4;
        private ProgressBar PrgProcess;
        private TrackBar TrbProcess;
        private GroupBox groupBox5;
        private Button BtnModal;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private GroupBox groupBox6;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private Button BtnOpenImage;
        private Button BtnRoot;
        private ImageList imageList1;
        private PictureBox PicImage;
        private Button button1;
        private OpenFileDialog DlgOpenImage;
        private TextBox TxtYear;
        private MonthCalendar CalSchedule;
        private DateTimePicker DtpBirth;
        private LinkLabel LblUrl;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private ToolTip toolTip1;
        private Button BtnCheck;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuNewFile;
        private ToolStripMenuItem MnuExit;
    }
}
