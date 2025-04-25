namespace WinformStudy_01
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
            splitContainer1 = new SplitContainer();
            TxtState = new TextBox();
            LblPw = new Label();
            LblId = new Label();
            TxtPw = new TextBox();
            TxtId = new TextBox();
            BtnCancel = new Button();
            BtnCheck = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(TxtState);
            splitContainer1.Panel1.Controls.Add(LblPw);
            splitContainer1.Panel1.Controls.Add(LblId);
            splitContainer1.Panel1.Controls.Add(TxtPw);
            splitContainer1.Panel1.Controls.Add(TxtId);
            splitContainer1.Panel1.Controls.Add(BtnCancel);
            splitContainer1.Panel1.Controls.Add(BtnCheck);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 392;
            splitContainer1.TabIndex = 0;
            // 
            // TxtState
            // 
            TxtState.Location = new Point(112, 273);
            TxtState.Multiline = true;
            TxtState.Name = "TxtState";
            TxtState.ReadOnly = true;
            TxtState.ScrollBars = ScrollBars.Vertical;
            TxtState.Size = new Size(199, 87);
            TxtState.TabIndex = 4;
            TxtState.TextAlign = HorizontalAlignment.Center;
            // 
            // LblPw
            // 
            LblPw.AutoSize = true;
            LblPw.Location = new Point(44, 223);
            LblPw.Name = "LblPw";
            LblPw.Size = new Size(62, 15);
            LblPw.TabIndex = 3;
            LblPw.Text = "비밀번호 :";
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(56, 164);
            LblId.Name = "LblId";
            LblId.Size = new Size(50, 15);
            LblId.TabIndex = 3;
            LblId.Text = "아이디 :";
            // 
            // TxtPw
            // 
            TxtPw.BorderStyle = BorderStyle.FixedSingle;
            TxtPw.Location = new Point(112, 221);
            TxtPw.MaxLength = 18;
            TxtPw.Name = "TxtPw";
            TxtPw.PlaceholderText = "Password";
            TxtPw.Size = new Size(200, 23);
            TxtPw.TabIndex = 2;
            // 
            // TxtId
            // 
            TxtId.BackColor = SystemColors.Window;
            TxtId.BorderStyle = BorderStyle.FixedSingle;
            TxtId.Location = new Point(112, 162);
            TxtId.Name = "TxtId";
            TxtId.PlaceholderText = "ID";
            TxtId.Size = new Size(200, 23);
            TxtId.TabIndex = 2;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(112, 385);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(90, 30);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCheck_Click;
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(221, 385);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(90, 30);
            BtnCheck.TabIndex = 1;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("한컴산뜻돋움", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(162, 93);
            label1.Name = "label1";
            label1.Size = new Size(90, 35);
            label1.TabIndex = 0;
            label1.Text = "로그인";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmMain";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox TxtPw;
        private TextBox TxtId;
        private Button BtnCheck;
        private Label LblPw;
        private Label LblId;
        private Button BtnCancel;
        private TextBox TxtState;
    }
}
