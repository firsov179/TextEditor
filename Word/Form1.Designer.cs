
namespace Word
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butPanCreate = new System.Windows.Forms.Button();
            this.userDir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butPanRtf = new System.Windows.Forms.Button();
            this.butPanClose = new System.Windows.Forms.Button();
            this.butPanTxt = new System.Windows.Forms.Button();
            this.butPanOpen = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxCopy = new System.Windows.Forms.RichTextBox();
            this.butPa2Bold = new System.Windows.Forms.Button();
            this.butPa2Under = new System.Windows.Forms.Button();
            this.butPa2Strike = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pa3Save = new System.Windows.Forms.Button();
            this.Pa3Stop = new System.Windows.Forms.Button();
            this.Pan3 = new System.Windows.Forms.Button();
            this.Pan3Warning = new System.Windows.Forms.Label();
            this.FileText1 = new System.Windows.Forms.RichTextBox();
            this.Par2Close = new System.Windows.Forms.Button();
            this.Pan2IsSaved = new System.Windows.Forms.Label();
            this.FileText2 = new System.Windows.Forms.RichTextBox();
            this.butPan2File3 = new System.Windows.Forms.Button();
            this.butPan2File2 = new System.Windows.Forms.Button();
            this.butPan2File1 = new System.Windows.Forms.Button();
            this.butPan2Save = new System.Windows.Forms.Button();
            this.openName = new System.Windows.Forms.Label();
            this.panelBuf = new System.Windows.Forms.Panel();
            this.butPa2Italic = new System.Windows.Forms.Button();
            this.FileText3 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тутПокаНичегоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TextTypeBox = new System.Windows.Forms.ComboBox();
            this.TextTypeLab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDark = new System.Windows.Forms.Button();
            this.buttonLight = new System.Windows.Forms.Button();
            this.TimeLab = new System.Windows.Forms.Label();
            this.BoxTime = new System.Windows.Forms.ComboBox();
            this.pa4Close = new System.Windows.Forms.Button();
            this.Pa5Name = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelBuf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butPanCreate
            // 
            this.butPanCreate.Location = new System.Drawing.Point(19, 241);
            this.butPanCreate.Name = "butPanCreate";
            this.butPanCreate.Size = new System.Drawing.Size(80, 29);
            this.butPanCreate.TabIndex = 0;
            this.butPanCreate.Text = "Создать файл";
            this.butPanCreate.UseVisualStyleBackColor = true;
            this.butPanCreate.UseWaitCursor = true;
            this.butPanCreate.Click += new System.EventHandler(this.butPanCreate_Click);
            // 
            // userDir
            // 
            this.userDir.Location = new System.Drawing.Point(19, 70);
            this.userDir.Name = "userDir";
            this.userDir.Size = new System.Drawing.Size(179, 23);
            this.userDir.TabIndex = 1;
            this.userDir.Text = "D:\\test";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.butPanRtf);
            this.panel1.Controls.Add(this.butPanClose);
            this.panel1.Controls.Add(this.butPanTxt);
            this.panel1.Controls.Add(this.butPanOpen);
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butPanCreate);
            this.panel1.Controls.Add(this.userDir);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 286);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // butPanRtf
            // 
            this.butPanRtf.Location = new System.Drawing.Point(118, 169);
            this.butPanRtf.Name = "butPanRtf";
            this.butPanRtf.Size = new System.Drawing.Size(80, 25);
            this.butPanRtf.TabIndex = 10;
            this.butPanRtf.Text = ".rtf";
            this.butPanRtf.UseVisualStyleBackColor = true;
            this.butPanRtf.Click += new System.EventHandler(this.butPanRtf_Click);
            // 
            // butPanClose
            // 
            this.butPanClose.BackColor = System.Drawing.Color.Tomato;
            this.butPanClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.butPanClose.Location = new System.Drawing.Point(194, 0);
            this.butPanClose.Name = "butPanClose";
            this.butPanClose.Size = new System.Drawing.Size(28, 25);
            this.butPanClose.TabIndex = 8;
            this.butPanClose.Text = "X";
            this.butPanClose.UseVisualStyleBackColor = false;
            this.butPanClose.Click += new System.EventHandler(this.butPanClose_Click);
            // 
            // butPanTxt
            // 
            this.butPanTxt.Enabled = false;
            this.butPanTxt.Location = new System.Drawing.Point(19, 169);
            this.butPanTxt.Name = "butPanTxt";
            this.butPanTxt.Size = new System.Drawing.Size(80, 25);
            this.butPanTxt.TabIndex = 9;
            this.butPanTxt.Text = ".txt";
            this.butPanTxt.UseVisualStyleBackColor = true;
            this.butPanTxt.Click += new System.EventHandler(this.butPanTxt_Click);
            // 
            // butPanOpen
            // 
            this.butPanOpen.Location = new System.Drawing.Point(118, 242);
            this.butPanOpen.Name = "butPanOpen";
            this.butPanOpen.Size = new System.Drawing.Size(80, 28);
            this.butPanOpen.TabIndex = 7;
            this.butPanOpen.Text = "Открыть";
            this.butPanOpen.UseVisualStyleBackColor = true;
            this.butPanOpen.Click += new System.EventHandler(this.butPanOpen_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(19, 212);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(0, 15);
            this.Info.TabIndex = 6;
            this.Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Создать новый файл";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(19, 122);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(179, 23);
            this.userName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя файла";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к файлу";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.richTextBoxCopy);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.FileText1);
            this.panel2.Controls.Add(this.Par2Close);
            this.panel2.Controls.Add(this.Pan2IsSaved);
            this.panel2.Controls.Add(this.FileText2);
            this.panel2.Controls.Add(this.butPan2File3);
            this.panel2.Controls.Add(this.butPan2File2);
            this.panel2.Controls.Add(this.butPan2File1);
            this.panel2.Controls.Add(this.butPan2Save);
            this.panel2.Controls.Add(this.openName);
            this.panel2.Controls.Add(this.panelBuf);
            this.panel2.Controls.Add(this.FileText3);
            this.panel2.Location = new System.Drawing.Point(260, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 513);
            this.panel2.TabIndex = 5;
            // 
            // richTextBoxCopy
            // 
            this.richTextBoxCopy.Location = new System.Drawing.Point(552, 485);
            this.richTextBoxCopy.Name = "richTextBoxCopy";
            this.richTextBoxCopy.Size = new System.Drawing.Size(31, 25);
            this.richTextBoxCopy.TabIndex = 1;
            this.richTextBoxCopy.Text = "";
            this.richTextBoxCopy.Visible = false;
            // 
            // butPa2Bold
            // 
            this.butPa2Bold.Location = new System.Drawing.Point(294, 49);
            this.butPa2Bold.Name = "butPa2Bold";
            this.butPa2Bold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butPa2Bold.Size = new System.Drawing.Size(35, 33);
            this.butPa2Bold.TabIndex = 16;
            this.butPa2Bold.Text = "ℝ";
            this.butPa2Bold.UseVisualStyleBackColor = true;
            this.butPa2Bold.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // butPa2Under
            // 
            this.butPa2Under.Location = new System.Drawing.Point(208, 49);
            this.butPa2Under.Name = "butPa2Under";
            this.butPa2Under.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butPa2Under.Size = new System.Drawing.Size(35, 33);
            this.butPa2Under.TabIndex = 15;
            this.butPa2Under.Text = " ͟ж͟";
            this.butPa2Under.UseVisualStyleBackColor = true;
            this.butPa2Under.Click += new System.EventHandler(this.button3_Click);
            // 
            // butPa2Strike
            // 
            this.butPa2Strike.Location = new System.Drawing.Point(135, 49);
            this.butPa2Strike.Name = "butPa2Strike";
            this.butPa2Strike.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butPa2Strike.Size = new System.Drawing.Size(35, 33);
            this.butPa2Strike.TabIndex = 13;
            this.butPa2Strike.Text = "Đ";
            this.butPa2Strike.UseVisualStyleBackColor = true;
            this.butPa2Strike.Click += new System.EventHandler(this.butPa2Strike_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.Pa3Save);
            this.panel3.Controls.Add(this.Pa3Stop);
            this.panel3.Controls.Add(this.Pan3);
            this.panel3.Controls.Add(this.Pan3Warning);
            this.panel3.Location = new System.Drawing.Point(112, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 133);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            // 
            // Pa3Save
            // 
            this.Pa3Save.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Pa3Save.Location = new System.Drawing.Point(231, 79);
            this.Pa3Save.Name = "Pa3Save";
            this.Pa3Save.Size = new System.Drawing.Size(75, 23);
            this.Pa3Save.TabIndex = 2;
            this.Pa3Save.Text = "Сохранить";
            this.Pa3Save.UseVisualStyleBackColor = false;
            this.Pa3Save.Click += new System.EventHandler(this.Pa3Save_Click);
            // 
            // Pa3Stop
            // 
            this.Pa3Stop.Location = new System.Drawing.Point(129, 79);
            this.Pa3Stop.Name = "Pa3Stop";
            this.Pa3Stop.Size = new System.Drawing.Size(75, 23);
            this.Pa3Stop.TabIndex = 3;
            this.Pa3Stop.Text = "Отмена";
            this.Pa3Stop.UseVisualStyleBackColor = true;
            this.Pa3Stop.Click += new System.EventHandler(this.Pa3Stop_Click);
            // 
            // Pan3
            // 
            this.Pan3.BackColor = System.Drawing.Color.Tomato;
            this.Pan3.Location = new System.Drawing.Point(26, 79);
            this.Pan3.Name = "Pan3";
            this.Pan3.Size = new System.Drawing.Size(75, 23);
            this.Pan3.TabIndex = 1;
            this.Pan3.Text = "Закрыть";
            this.Pan3.UseVisualStyleBackColor = false;
            this.Pan3.Click += new System.EventHandler(this.Pan3Close_Click);
            // 
            // Pan3Warning
            // 
            this.Pan3Warning.AutoSize = true;
            this.Pan3Warning.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Pan3Warning.Location = new System.Drawing.Point(99, 20);
            this.Pan3Warning.Name = "Pan3Warning";
            this.Pan3Warning.Size = new System.Drawing.Size(140, 30);
            this.Pan3Warning.TabIndex = 0;
            this.Pan3Warning.Text = "Этот файл не сохранен! \r\nЧто сделать:";
            this.Pan3Warning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FileText1
            // 
            this.FileText1.Location = new System.Drawing.Point(0, 113);
            this.FileText1.Name = "FileText1";
            this.FileText1.Size = new System.Drawing.Size(583, 400);
            this.FileText1.TabIndex = 9;
            this.FileText1.Text = "";
            this.FileText1.TextChanged += new System.EventHandler(this.FileText1_TextChanged);
            // 
            // Par2Close
            // 
            this.Par2Close.BackColor = System.Drawing.Color.Tomato;
            this.Par2Close.Location = new System.Drawing.Point(481, 10);
            this.Par2Close.Name = "Par2Close";
            this.Par2Close.Size = new System.Drawing.Size(102, 22);
            this.Par2Close.TabIndex = 9;
            this.Par2Close.Text = "Закрыть файл";
            this.Par2Close.UseVisualStyleBackColor = false;
            this.Par2Close.Click += new System.EventHandler(this.Pan2Close_Click);
            // 
            // Pan2IsSaved
            // 
            this.Pan2IsSaved.AutoSize = true;
            this.Pan2IsSaved.Location = new System.Drawing.Point(103, 14);
            this.Pan2IsSaved.Name = "Pan2IsSaved";
            this.Pan2IsSaved.Size = new System.Drawing.Size(68, 15);
            this.Pan2IsSaved.TabIndex = 8;
            this.Pan2IsSaved.Text = "Сохранено";
            // 
            // FileText2
            // 
            this.FileText2.Location = new System.Drawing.Point(0, 113);
            this.FileText2.Name = "FileText2";
            this.FileText2.Size = new System.Drawing.Size(586, 400);
            this.FileText2.TabIndex = 11;
            this.FileText2.Text = "";
            this.FileText2.Visible = false;
            this.FileText2.TextChanged += new System.EventHandler(this.FileText2_TextChanged);
            // 
            // butPan2File3
            // 
            this.butPan2File3.Location = new System.Drawing.Point(389, 10);
            this.butPan2File3.Name = "butPan2File3";
            this.butPan2File3.Size = new System.Drawing.Size(75, 23);
            this.butPan2File3.TabIndex = 7;
            this.butPan2File3.Text = "...";
            this.butPan2File3.UseVisualStyleBackColor = true;
            this.butPan2File3.Click += new System.EventHandler(this.butPan2File3_Click);
            // 
            // butPan2File2
            // 
            this.butPan2File2.Location = new System.Drawing.Point(297, 10);
            this.butPan2File2.Name = "butPan2File2";
            this.butPan2File2.Size = new System.Drawing.Size(75, 23);
            this.butPan2File2.TabIndex = 6;
            this.butPan2File2.Text = "...";
            this.butPan2File2.UseVisualStyleBackColor = true;
            this.butPan2File2.Click += new System.EventHandler(this.butPan2File2_Click);
            // 
            // butPan2File1
            // 
            this.butPan2File1.Enabled = false;
            this.butPan2File1.Location = new System.Drawing.Point(203, 9);
            this.butPan2File1.Name = "butPan2File1";
            this.butPan2File1.Size = new System.Drawing.Size(75, 23);
            this.butPan2File1.TabIndex = 5;
            this.butPan2File1.Text = "...";
            this.butPan2File1.UseVisualStyleBackColor = true;
            this.butPan2File1.Click += new System.EventHandler(this.butPan2File1_Click);
            // 
            // butPan2Save
            // 
            this.butPan2Save.Location = new System.Drawing.Point(13, 10);
            this.butPan2Save.Name = "butPan2Save";
            this.butPan2Save.Size = new System.Drawing.Size(75, 23);
            this.butPan2Save.TabIndex = 4;
            this.butPan2Save.Text = "Сохранить";
            this.butPan2Save.UseVisualStyleBackColor = true;
            this.butPan2Save.Click += new System.EventHandler(this.butPan2Save_Click);
            // 
            // openName
            // 
            this.openName.AutoSize = true;
            this.openName.Location = new System.Drawing.Point(274, 10);
            this.openName.Name = "openName";
            this.openName.Size = new System.Drawing.Size(0, 15);
            this.openName.TabIndex = 0;
            // 
            // panelBuf
            // 
            this.panelBuf.Controls.Add(this.butPa2Italic);
            this.panelBuf.Controls.Add(this.butPa2Strike);
            this.panelBuf.Controls.Add(this.butPa2Under);
            this.panelBuf.Controls.Add(this.butPa2Bold);
            this.panelBuf.Location = new System.Drawing.Point(3, 3);
            this.panelBuf.Name = "panelBuf";
            this.panelBuf.Size = new System.Drawing.Size(580, 90);
            this.panelBuf.TabIndex = 10;
            // 
            // butPa2Italic
            // 
            this.butPa2Italic.Location = new System.Drawing.Point(358, 49);
            this.butPa2Italic.Name = "butPa2Italic";
            this.butPa2Italic.Size = new System.Drawing.Size(35, 33);
            this.butPa2Italic.TabIndex = 0;
            this.butPa2Italic.Text = "//";
            this.butPa2Italic.UseVisualStyleBackColor = true;
            this.butPa2Italic.Click += new System.EventHandler(this.butPa2Italic_Click);
            // 
            // FileText3
            // 
            this.FileText3.Location = new System.Drawing.Point(0, 113);
            this.FileText3.Name = "FileText3";
            this.FileText3.Size = new System.Drawing.Size(586, 400);
            this.FileText3.TabIndex = 12;
            this.FileText3.Text = "";
            this.FileText3.Visible = false;
            this.FileText3.TextChanged += new System.EventHandler(this.FileText3_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.ErrorImage = global::Word.Properties.Resources.fire1;
            this.pictureBox1.Image = global::Word.Properties.Resources.fire1;
            this.pictureBox1.InitialImage = global::Word.Properties.Resources.fire1;
            this.pictureBox1.Location = new System.Drawing.Point(916, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.correctionToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newFileToolStripMenuItem.Text = "Создать файл";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openFileToolStripMenuItem.Text = "Открыть файл";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.formatToolStripMenuItem.Text = "Формат";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.formatToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.defaultToolStripMenuItem.Text = "Стандартный шрифт";
            // 
            // correctionToolStripMenuItem
            // 
            this.correctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тутПокаНичегоToolStripMenuItem});
            this.correctionToolStripMenuItem.Name = "correctionToolStripMenuItem";
            this.correctionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.correctionToolStripMenuItem.Text = "Правка";
            // 
            // тутПокаНичегоToolStripMenuItem
            // 
            this.тутПокаНичегоToolStripMenuItem.Name = "тутПокаНичегоToolStripMenuItem";
            this.тутПокаНичегоToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.тутПокаНичегоToolStripMenuItem.Text = "Тут пока ничего";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingToolStripMenuItem.Text = "Настройки";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.TextTypeBox);
            this.panel4.Controls.Add(this.TextTypeLab);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.buttonDark);
            this.panel4.Controls.Add(this.buttonLight);
            this.panel4.Controls.Add(this.TimeLab);
            this.panel4.Controls.Add(this.BoxTime);
            this.panel4.Controls.Add(this.pa4Close);
            this.panel4.Controls.Add(this.Pa5Name);
            this.panel4.Location = new System.Drawing.Point(15, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 324);
            this.panel4.TabIndex = 8;
            this.panel4.Visible = false;
            // 
            // TextTypeBox
            // 
            this.TextTypeBox.FormattingEnabled = true;
            this.TextTypeBox.Items.AddRange(new object[] {
            "Arial",
            "Elephant"});
            this.TextTypeBox.Location = new System.Drawing.Point(16, 214);
            this.TextTypeBox.Name = "TextTypeBox";
            this.TextTypeBox.Size = new System.Drawing.Size(177, 23);
            this.TextTypeBox.TabIndex = 10;
            this.TextTypeBox.Text = "Default";
            this.TextTypeBox.SelectedIndexChanged += new System.EventHandler(this.TextTypeBox_SelectedIndexChanged);
            // 
            // TextTypeLab
            // 
            this.TextTypeLab.AutoSize = true;
            this.TextTypeLab.Location = new System.Drawing.Point(16, 186);
            this.TextTypeLab.Name = "TextTypeLab";
            this.TextTypeLab.Size = new System.Drawing.Size(49, 15);
            this.TextTypeLab.TabIndex = 9;
            this.TextTypeLab.Text = "Шрифт ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тема оформления";
            // 
            // buttonDark
            // 
            this.buttonDark.Location = new System.Drawing.Point(115, 144);
            this.buttonDark.Name = "buttonDark";
            this.buttonDark.Size = new System.Drawing.Size(80, 23);
            this.buttonDark.TabIndex = 7;
            this.buttonDark.Text = "Тёмная";
            this.buttonDark.UseVisualStyleBackColor = true;
            this.buttonDark.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLight
            // 
            this.buttonLight.Location = new System.Drawing.Point(16, 144);
            this.buttonLight.Name = "buttonLight";
            this.buttonLight.Size = new System.Drawing.Size(75, 23);
            this.buttonLight.TabIndex = 6;
            this.buttonLight.Text = "Светлая";
            this.buttonLight.UseVisualStyleBackColor = true;
            this.buttonLight.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeLab
            // 
            this.TimeLab.AutoSize = true;
            this.TimeLab.Location = new System.Drawing.Point(16, 53);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(177, 15);
            this.TimeLab.TabIndex = 5;
            this.TimeLab.Text = "Частота сохранений в минутах";
            // 
            // BoxTime
            // 
            this.BoxTime.FormattingEnabled = true;
            this.BoxTime.Items.AddRange(new object[] {
            "1",
            "5 ",
            "10 ",
            "30 "});
            this.BoxTime.Location = new System.Drawing.Point(16, 80);
            this.BoxTime.Name = "BoxTime";
            this.BoxTime.Size = new System.Drawing.Size(177, 23);
            this.BoxTime.TabIndex = 4;
            this.BoxTime.Text = "1";
            this.BoxTime.SelectedIndexChanged += new System.EventHandler(this.BoxTime_SelectedIndexChanged);
            // 
            // pa4Close
            // 
            this.pa4Close.BackColor = System.Drawing.Color.Tomato;
            this.pa4Close.Location = new System.Drawing.Point(197, 0);
            this.pa4Close.Name = "pa4Close";
            this.pa4Close.Size = new System.Drawing.Size(22, 23);
            this.pa4Close.TabIndex = 1;
            this.pa4Close.Text = "X";
            this.pa4Close.UseVisualStyleBackColor = false;
            this.pa4Close.Click += new System.EventHandler(this.pa4Close_Click);
            // 
            // Pa5Name
            // 
            this.Pa5Name.AutoSize = true;
            this.Pa5Name.Location = new System.Drawing.Point(72, 15);
            this.Pa5Name.Name = "Pa5Name";
            this.Pa5Name.Size = new System.Drawing.Size(67, 15);
            this.Pa5Name.TabIndex = 0;
            this.Pa5Name.Text = "Настройки";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 114);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem2.Text = "Выделить всё";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem3.Text = "Копировать";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem4.Text = "Вставить";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem5.Text = "Вырезать";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem6.Text = "Формат";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem7.Text = "Default";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem8.Text = "Elephant";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1026, 711);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelBuf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butPanCreate;
        private System.Windows.Forms.TextBox userDir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label openName;
        private System.Windows.Forms.Button butPanOpen;
        private System.Windows.Forms.Button butPanClose;
        private System.Windows.Forms.Button butPan2Save;
        private System.Windows.Forms.Button butPan2File3;
        private System.Windows.Forms.Button butPan2File2;
        private System.Windows.Forms.Button butPan2File1;
        private System.Windows.Forms.Label Pan2IsSaved;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Par2Close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Pa3Stop;
        private System.Windows.Forms.Button Pa3Save;
        private System.Windows.Forms.Button Pan3;
        private System.Windows.Forms.Label Pan3Warning;
        private System.Windows.Forms.Panel panelBuf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тутПокаНичегоToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Pa5Name;
        private System.Windows.Forms.Button pa4Close;
        private System.Windows.Forms.RichTextBox FileText1;
        private System.Windows.Forms.Button butPanRtf;
        private System.Windows.Forms.Button butPanTxt;
        private System.Windows.Forms.RichTextBox FileText2;
        private System.Windows.Forms.RichTextBox FileText3;
        private System.Windows.Forms.ComboBox BoxTime;
        private System.Windows.Forms.Label TimeLab;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonDark;
        private System.Windows.Forms.Button buttonLight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TextTypeBox;
        private System.Windows.Forms.Label TextTypeLab;
        private System.Windows.Forms.Button butPa2Bold;
        private System.Windows.Forms.Button butPa2Under;
        private System.Windows.Forms.Button butPa2Strike;
        private System.Windows.Forms.Button butPa2Italic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.RichTextBox richTextBoxCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
    }
}

