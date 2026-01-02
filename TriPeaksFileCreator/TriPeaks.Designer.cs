namespace TriPeaksSolver
{
    partial class TriPeaks
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
            listBox1 = new ListBox();
            btnClub = new Button();
            btnDiamond = new Button();
            btnHeart = new Button();
            btnSpade = new Button();
            pictureBox1 = new PictureBox();
            btnPile1 = new Button();
            btnPile2 = new Button();
            btnPile3 = new Button();
            btnPile4 = new Button();
            btnPile5 = new Button();
            btnPile6 = new Button();
            btnPile7 = new Button();
            btnPile8 = new Button();
            btnPile9 = new Button();
            btnPile10 = new Button();
            btnPile11 = new Button();
            btnPile12 = new Button();
            btnPile13 = new Button();
            btnPile14 = new Button();
            btnPile19 = new Button();
            btnPile20 = new Button();
            btnPile15 = new Button();
            btnPile21 = new Button();
            btnPile16 = new Button();
            btnPile22 = new Button();
            btnPile17 = new Button();
            btnPile23 = new Button();
            btnPile18 = new Button();
            btnPile24 = new Button();
            btnBoard1 = new Button();
            btnBoard2 = new Button();
            btnBoard3 = new Button();
            btnBoard4 = new Button();
            btnBoard5 = new Button();
            btnBoard6 = new Button();
            btnBoard7 = new Button();
            btnBoard8 = new Button();
            btnBoard9 = new Button();
            btnBoard10 = new Button();
            btnBoard13 = new Button();
            btnBoard11 = new Button();
            btnBoard14 = new Button();
            btnBoard12 = new Button();
            btnBoard15 = new Button();
            btnBoard16 = new Button();
            btnBoard17 = new Button();
            btnBoard18 = new Button();
            btnBoard19 = new Button();
            btnBoard22 = new Button();
            btnBoard25 = new Button();
            btnBoard20 = new Button();
            btnBoard23 = new Button();
            btnBoard26 = new Button();
            btnBoard21 = new Button();
            btnBoard24 = new Button();
            btnBoard27 = new Button();
            btnBoard28 = new Button();
            btnGenerate = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            clearBoardToolStripMenuItem = new ToolStripMenuItem();
            autoFillToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            insertLeftToolStripMenuItem = new ToolStripMenuItem();
            insertRightToolStripMenuItem = new ToolStripMenuItem();
            deleteLeftToolStripMenuItem = new ToolStripMenuItem();
            deleteRightToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            btnNone = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" });
            listBox1.Location = new Point(22, 102);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(32, 284);
            listBox1.TabIndex = 57;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            listBox1.KeyPress += ListBox1_KeyPress;
            // 
            // btnClub
            // 
            btnClub.BackColor = Color.White;
            btnClub.Image = Properties.Resources.club;
            btnClub.Location = new Point(60, 190);
            btnClub.Name = "btnClub";
            btnClub.Size = new Size(36, 40);
            btnClub.TabIndex = 53;
            btnClub.UseVisualStyleBackColor = false;
            btnClub.Click += Button1_Click;
            btnClub.KeyPress += ListBox1_KeyPress;
            // 
            // btnDiamond
            // 
            btnDiamond.BackColor = Color.White;
            btnDiamond.Image = Properties.Resources.diamond;
            btnDiamond.Location = new Point(60, 242);
            btnDiamond.Name = "btnDiamond";
            btnDiamond.Size = new Size(36, 40);
            btnDiamond.TabIndex = 54;
            btnDiamond.UseVisualStyleBackColor = false;
            btnDiamond.Click += Button2_Click;
            btnDiamond.KeyPress += ListBox1_KeyPress;
            // 
            // btnHeart
            // 
            btnHeart.BackColor = Color.White;
            btnHeart.Image = Properties.Resources.heart;
            btnHeart.Location = new Point(60, 294);
            btnHeart.Name = "btnHeart";
            btnHeart.Size = new Size(36, 40);
            btnHeart.TabIndex = 55;
            btnHeart.UseVisualStyleBackColor = false;
            btnHeart.Click += Button3_Click;
            btnHeart.KeyPress += ListBox1_KeyPress;
            // 
            // btnSpade
            // 
            btnSpade.BackColor = Color.White;
            btnSpade.Image = Properties.Resources.spade;
            btnSpade.Location = new Point(60, 346);
            btnSpade.Name = "btnSpade";
            btnSpade.Size = new Size(36, 40);
            btnSpade.TabIndex = 56;
            btnSpade.UseVisualStyleBackColor = false;
            btnSpade.Click += Button4_Click;
            btnSpade.KeyPress += ListBox1_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(60, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnPile1
            // 
            btnPile1.BackColor = Color.White;
            btnPile1.FlatStyle = FlatStyle.Popup;
            btnPile1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile1.Location = new Point(119, 433);
            btnPile1.Name = "btnPile1";
            btnPile1.Size = new Size(64, 84);
            btnPile1.TabIndex = 29;
            btnPile1.TextAlign = ContentAlignment.TopLeft;
            btnPile1.UseVisualStyleBackColor = false;
            btnPile1.Click += BoardButton_Click;
            btnPile1.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile2
            // 
            btnPile2.BackColor = Color.White;
            btnPile2.FlatStyle = FlatStyle.Popup;
            btnPile2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile2.Location = new Point(189, 433);
            btnPile2.Name = "btnPile2";
            btnPile2.Size = new Size(64, 84);
            btnPile2.TabIndex = 30;
            btnPile2.TextAlign = ContentAlignment.TopLeft;
            btnPile2.UseVisualStyleBackColor = false;
            btnPile2.Click += BoardButton_Click;
            btnPile2.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile3
            // 
            btnPile3.BackColor = Color.White;
            btnPile3.FlatStyle = FlatStyle.Popup;
            btnPile3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile3.Location = new Point(259, 433);
            btnPile3.Name = "btnPile3";
            btnPile3.Size = new Size(64, 84);
            btnPile3.TabIndex = 31;
            btnPile3.TextAlign = ContentAlignment.TopLeft;
            btnPile3.UseVisualStyleBackColor = false;
            btnPile3.Click += BoardButton_Click;
            btnPile3.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile4
            // 
            btnPile4.BackColor = Color.White;
            btnPile4.FlatStyle = FlatStyle.Popup;
            btnPile4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile4.Location = new Point(329, 433);
            btnPile4.Name = "btnPile4";
            btnPile4.Size = new Size(64, 84);
            btnPile4.TabIndex = 32;
            btnPile4.TextAlign = ContentAlignment.TopLeft;
            btnPile4.UseVisualStyleBackColor = false;
            btnPile4.Click += BoardButton_Click;
            btnPile4.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile5
            // 
            btnPile5.BackColor = Color.White;
            btnPile5.FlatStyle = FlatStyle.Popup;
            btnPile5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile5.Location = new Point(399, 433);
            btnPile5.Name = "btnPile5";
            btnPile5.Size = new Size(64, 84);
            btnPile5.TabIndex = 33;
            btnPile5.TextAlign = ContentAlignment.TopLeft;
            btnPile5.UseVisualStyleBackColor = false;
            btnPile5.Click += BoardButton_Click;
            btnPile5.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile6
            // 
            btnPile6.BackColor = Color.White;
            btnPile6.FlatStyle = FlatStyle.Popup;
            btnPile6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile6.Location = new Point(469, 433);
            btnPile6.Name = "btnPile6";
            btnPile6.Size = new Size(64, 84);
            btnPile6.TabIndex = 34;
            btnPile6.TextAlign = ContentAlignment.TopLeft;
            btnPile6.UseVisualStyleBackColor = false;
            btnPile6.Click += BoardButton_Click;
            btnPile6.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile7
            // 
            btnPile7.BackColor = Color.White;
            btnPile7.FlatStyle = FlatStyle.Popup;
            btnPile7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile7.Location = new Point(542, 433);
            btnPile7.Name = "btnPile7";
            btnPile7.Size = new Size(64, 84);
            btnPile7.TabIndex = 35;
            btnPile7.TextAlign = ContentAlignment.TopLeft;
            btnPile7.UseVisualStyleBackColor = false;
            btnPile7.Click += BoardButton_Click;
            btnPile7.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile8
            // 
            btnPile8.BackColor = Color.White;
            btnPile8.FlatStyle = FlatStyle.Popup;
            btnPile8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile8.Location = new Point(612, 433);
            btnPile8.Name = "btnPile8";
            btnPile8.Size = new Size(64, 84);
            btnPile8.TabIndex = 36;
            btnPile8.TextAlign = ContentAlignment.TopLeft;
            btnPile8.UseVisualStyleBackColor = false;
            btnPile8.Click += BoardButton_Click;
            btnPile8.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile9
            // 
            btnPile9.BackColor = Color.White;
            btnPile9.FlatStyle = FlatStyle.Popup;
            btnPile9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile9.Location = new Point(682, 433);
            btnPile9.Name = "btnPile9";
            btnPile9.Size = new Size(64, 84);
            btnPile9.TabIndex = 37;
            btnPile9.TextAlign = ContentAlignment.TopLeft;
            btnPile9.UseVisualStyleBackColor = false;
            btnPile9.Click += BoardButton_Click;
            btnPile9.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile10
            // 
            btnPile10.BackColor = Color.White;
            btnPile10.FlatStyle = FlatStyle.Popup;
            btnPile10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile10.Location = new Point(752, 433);
            btnPile10.Name = "btnPile10";
            btnPile10.Size = new Size(64, 84);
            btnPile10.TabIndex = 38;
            btnPile10.TextAlign = ContentAlignment.TopLeft;
            btnPile10.UseVisualStyleBackColor = false;
            btnPile10.Click += BoardButton_Click;
            btnPile10.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile11
            // 
            btnPile11.BackColor = Color.White;
            btnPile11.FlatStyle = FlatStyle.Popup;
            btnPile11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile11.Location = new Point(822, 433);
            btnPile11.Name = "btnPile11";
            btnPile11.Size = new Size(64, 84);
            btnPile11.TabIndex = 39;
            btnPile11.TextAlign = ContentAlignment.TopLeft;
            btnPile11.UseVisualStyleBackColor = false;
            btnPile11.Click += BoardButton_Click;
            btnPile11.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile12
            // 
            btnPile12.BackColor = Color.White;
            btnPile12.FlatStyle = FlatStyle.Popup;
            btnPile12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile12.Location = new Point(892, 433);
            btnPile12.Name = "btnPile12";
            btnPile12.Size = new Size(64, 84);
            btnPile12.TabIndex = 40;
            btnPile12.TextAlign = ContentAlignment.TopLeft;
            btnPile12.UseVisualStyleBackColor = false;
            btnPile12.Click += BoardButton_Click;
            btnPile12.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile13
            // 
            btnPile13.BackColor = Color.White;
            btnPile13.FlatStyle = FlatStyle.Popup;
            btnPile13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile13.Location = new Point(119, 523);
            btnPile13.Name = "btnPile13";
            btnPile13.Size = new Size(64, 84);
            btnPile13.TabIndex = 41;
            btnPile13.TextAlign = ContentAlignment.TopLeft;
            btnPile13.UseVisualStyleBackColor = false;
            btnPile13.Click += BoardButton_Click;
            btnPile13.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile14
            // 
            btnPile14.BackColor = Color.White;
            btnPile14.FlatStyle = FlatStyle.Popup;
            btnPile14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile14.Location = new Point(189, 523);
            btnPile14.Name = "btnPile14";
            btnPile14.Size = new Size(64, 84);
            btnPile14.TabIndex = 42;
            btnPile14.TextAlign = ContentAlignment.TopLeft;
            btnPile14.UseVisualStyleBackColor = false;
            btnPile14.Click += BoardButton_Click;
            btnPile14.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile19
            // 
            btnPile19.BackColor = Color.White;
            btnPile19.FlatStyle = FlatStyle.Popup;
            btnPile19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile19.Location = new Point(542, 523);
            btnPile19.Name = "btnPile19";
            btnPile19.Size = new Size(64, 84);
            btnPile19.TabIndex = 47;
            btnPile19.TextAlign = ContentAlignment.TopLeft;
            btnPile19.UseVisualStyleBackColor = false;
            btnPile19.Click += BoardButton_Click;
            btnPile19.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile20
            // 
            btnPile20.BackColor = Color.White;
            btnPile20.FlatStyle = FlatStyle.Popup;
            btnPile20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile20.Location = new Point(612, 523);
            btnPile20.Name = "btnPile20";
            btnPile20.Size = new Size(64, 84);
            btnPile20.TabIndex = 48;
            btnPile20.TextAlign = ContentAlignment.TopLeft;
            btnPile20.UseVisualStyleBackColor = false;
            btnPile20.Click += BoardButton_Click;
            btnPile20.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile15
            // 
            btnPile15.BackColor = Color.White;
            btnPile15.FlatStyle = FlatStyle.Popup;
            btnPile15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile15.Location = new Point(259, 523);
            btnPile15.Name = "btnPile15";
            btnPile15.Size = new Size(64, 84);
            btnPile15.TabIndex = 43;
            btnPile15.TextAlign = ContentAlignment.TopLeft;
            btnPile15.UseVisualStyleBackColor = false;
            btnPile15.Click += BoardButton_Click;
            btnPile15.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile21
            // 
            btnPile21.BackColor = Color.White;
            btnPile21.FlatStyle = FlatStyle.Popup;
            btnPile21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile21.Location = new Point(682, 523);
            btnPile21.Name = "btnPile21";
            btnPile21.Size = new Size(64, 84);
            btnPile21.TabIndex = 49;
            btnPile21.TextAlign = ContentAlignment.TopLeft;
            btnPile21.UseVisualStyleBackColor = false;
            btnPile21.Click += BoardButton_Click;
            btnPile21.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile16
            // 
            btnPile16.BackColor = Color.White;
            btnPile16.FlatStyle = FlatStyle.Popup;
            btnPile16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile16.Location = new Point(329, 523);
            btnPile16.Name = "btnPile16";
            btnPile16.Size = new Size(64, 84);
            btnPile16.TabIndex = 44;
            btnPile16.TextAlign = ContentAlignment.TopLeft;
            btnPile16.UseVisualStyleBackColor = false;
            btnPile16.Click += BoardButton_Click;
            btnPile16.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile22
            // 
            btnPile22.BackColor = Color.White;
            btnPile22.FlatStyle = FlatStyle.Popup;
            btnPile22.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile22.Location = new Point(752, 523);
            btnPile22.Name = "btnPile22";
            btnPile22.Size = new Size(64, 84);
            btnPile22.TabIndex = 50;
            btnPile22.TextAlign = ContentAlignment.TopLeft;
            btnPile22.UseVisualStyleBackColor = false;
            btnPile22.Click += BoardButton_Click;
            btnPile22.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile17
            // 
            btnPile17.BackColor = Color.White;
            btnPile17.FlatStyle = FlatStyle.Popup;
            btnPile17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile17.Location = new Point(399, 523);
            btnPile17.Name = "btnPile17";
            btnPile17.Size = new Size(64, 84);
            btnPile17.TabIndex = 45;
            btnPile17.TextAlign = ContentAlignment.TopLeft;
            btnPile17.UseVisualStyleBackColor = false;
            btnPile17.Click += BoardButton_Click;
            btnPile17.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile23
            // 
            btnPile23.BackColor = Color.White;
            btnPile23.FlatStyle = FlatStyle.Popup;
            btnPile23.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile23.Location = new Point(822, 523);
            btnPile23.Name = "btnPile23";
            btnPile23.Size = new Size(64, 84);
            btnPile23.TabIndex = 51;
            btnPile23.TextAlign = ContentAlignment.TopLeft;
            btnPile23.UseVisualStyleBackColor = false;
            btnPile23.Click += BoardButton_Click;
            btnPile23.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile18
            // 
            btnPile18.BackColor = Color.White;
            btnPile18.FlatStyle = FlatStyle.Popup;
            btnPile18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile18.Location = new Point(469, 523);
            btnPile18.Name = "btnPile18";
            btnPile18.Size = new Size(64, 84);
            btnPile18.TabIndex = 46;
            btnPile18.TextAlign = ContentAlignment.TopLeft;
            btnPile18.UseVisualStyleBackColor = false;
            btnPile18.Click += BoardButton_Click;
            btnPile18.KeyPress += ListBox1_KeyPress;
            // 
            // btnPile24
            // 
            btnPile24.BackColor = Color.White;
            btnPile24.FlatStyle = FlatStyle.Popup;
            btnPile24.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPile24.Location = new Point(892, 523);
            btnPile24.Name = "btnPile24";
            btnPile24.Size = new Size(64, 84);
            btnPile24.TabIndex = 52;
            btnPile24.TextAlign = ContentAlignment.TopLeft;
            btnPile24.UseVisualStyleBackColor = false;
            btnPile24.Click += BoardButton_Click;
            btnPile24.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard1
            // 
            btnBoard1.BackColor = Color.White;
            btnBoard1.FlatAppearance.BorderSize = 0;
            btnBoard1.FlatStyle = FlatStyle.Popup;
            btnBoard1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard1.Location = new Point(356, 36);
            btnBoard1.Name = "btnBoard1";
            btnBoard1.Size = new Size(64, 84);
            btnBoard1.TabIndex = 1;
            btnBoard1.TextAlign = ContentAlignment.TopLeft;
            btnBoard1.UseVisualStyleBackColor = false;
            btnBoard1.Click += BoardButton_Click;
            btnBoard1.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard2
            // 
            btnBoard2.BackColor = Color.White;
            btnBoard2.FlatAppearance.BorderSize = 0;
            btnBoard2.FlatStyle = FlatStyle.Popup;
            btnBoard2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard2.Location = new Point(569, 36);
            btnBoard2.Name = "btnBoard2";
            btnBoard2.Size = new Size(64, 84);
            btnBoard2.TabIndex = 2;
            btnBoard2.TextAlign = ContentAlignment.TopLeft;
            btnBoard2.UseVisualStyleBackColor = false;
            btnBoard2.Click += BoardButton_Click;
            btnBoard2.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard3
            // 
            btnBoard3.BackColor = Color.White;
            btnBoard3.FlatAppearance.BorderSize = 0;
            btnBoard3.FlatStyle = FlatStyle.Popup;
            btnBoard3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard3.Location = new Point(780, 36);
            btnBoard3.Name = "btnBoard3";
            btnBoard3.Size = new Size(64, 84);
            btnBoard3.TabIndex = 3;
            btnBoard3.TextAlign = ContentAlignment.TopLeft;
            btnBoard3.UseVisualStyleBackColor = false;
            btnBoard3.Click += BoardButton_Click;
            btnBoard3.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard4
            // 
            btnBoard4.BackColor = Color.White;
            btnBoard4.FlatAppearance.BorderSize = 0;
            btnBoard4.FlatStyle = FlatStyle.Popup;
            btnBoard4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard4.Location = new Point(322, 126);
            btnBoard4.Name = "btnBoard4";
            btnBoard4.Size = new Size(64, 84);
            btnBoard4.TabIndex = 4;
            btnBoard4.TextAlign = ContentAlignment.TopLeft;
            btnBoard4.UseVisualStyleBackColor = false;
            btnBoard4.Click += BoardButton_Click;
            btnBoard4.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard5
            // 
            btnBoard5.BackColor = Color.White;
            btnBoard5.FlatAppearance.BorderSize = 0;
            btnBoard5.FlatStyle = FlatStyle.Popup;
            btnBoard5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard5.Location = new Point(392, 126);
            btnBoard5.Name = "btnBoard5";
            btnBoard5.Size = new Size(64, 84);
            btnBoard5.TabIndex = 5;
            btnBoard5.TextAlign = ContentAlignment.TopLeft;
            btnBoard5.UseVisualStyleBackColor = false;
            btnBoard5.Click += BoardButton_Click;
            btnBoard5.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard6
            // 
            btnBoard6.BackColor = Color.White;
            btnBoard6.FlatAppearance.BorderSize = 0;
            btnBoard6.FlatStyle = FlatStyle.Popup;
            btnBoard6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard6.Location = new Point(534, 126);
            btnBoard6.Name = "btnBoard6";
            btnBoard6.Size = new Size(64, 84);
            btnBoard6.TabIndex = 6;
            btnBoard6.TextAlign = ContentAlignment.TopLeft;
            btnBoard6.UseVisualStyleBackColor = false;
            btnBoard6.Click += BoardButton_Click;
            btnBoard6.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard7
            // 
            btnBoard7.BackColor = Color.White;
            btnBoard7.FlatAppearance.BorderSize = 0;
            btnBoard7.FlatStyle = FlatStyle.Popup;
            btnBoard7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard7.Location = new Point(606, 126);
            btnBoard7.Name = "btnBoard7";
            btnBoard7.Size = new Size(64, 84);
            btnBoard7.TabIndex = 7;
            btnBoard7.TextAlign = ContentAlignment.TopLeft;
            btnBoard7.UseVisualStyleBackColor = false;
            btnBoard7.Click += BoardButton_Click;
            btnBoard7.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard8
            // 
            btnBoard8.BackColor = Color.White;
            btnBoard8.FlatAppearance.BorderSize = 0;
            btnBoard8.FlatStyle = FlatStyle.Popup;
            btnBoard8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard8.Location = new Point(746, 126);
            btnBoard8.Name = "btnBoard8";
            btnBoard8.Size = new Size(64, 84);
            btnBoard8.TabIndex = 8;
            btnBoard8.TextAlign = ContentAlignment.TopLeft;
            btnBoard8.UseVisualStyleBackColor = false;
            btnBoard8.Click += BoardButton_Click;
            btnBoard8.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard9
            // 
            btnBoard9.BackColor = Color.White;
            btnBoard9.FlatAppearance.BorderSize = 0;
            btnBoard9.FlatStyle = FlatStyle.Popup;
            btnBoard9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard9.Location = new Point(816, 126);
            btnBoard9.Name = "btnBoard9";
            btnBoard9.Size = new Size(64, 84);
            btnBoard9.TabIndex = 9;
            btnBoard9.TextAlign = ContentAlignment.TopLeft;
            btnBoard9.UseVisualStyleBackColor = false;
            btnBoard9.Click += BoardButton_Click;
            btnBoard9.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard10
            // 
            btnBoard10.BackColor = Color.White;
            btnBoard10.FlatAppearance.BorderSize = 0;
            btnBoard10.FlatStyle = FlatStyle.Popup;
            btnBoard10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard10.Location = new Point(289, 216);
            btnBoard10.Name = "btnBoard10";
            btnBoard10.Size = new Size(64, 84);
            btnBoard10.TabIndex = 10;
            btnBoard10.TextAlign = ContentAlignment.TopLeft;
            btnBoard10.UseVisualStyleBackColor = false;
            btnBoard10.Click += BoardButton_Click;
            btnBoard10.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard13
            // 
            btnBoard13.BackColor = Color.White;
            btnBoard13.FlatAppearance.BorderSize = 0;
            btnBoard13.FlatStyle = FlatStyle.Popup;
            btnBoard13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard13.Location = new Point(501, 216);
            btnBoard13.Name = "btnBoard13";
            btnBoard13.Size = new Size(64, 84);
            btnBoard13.TabIndex = 13;
            btnBoard13.TextAlign = ContentAlignment.TopLeft;
            btnBoard13.UseVisualStyleBackColor = false;
            btnBoard13.Click += BoardButton_Click;
            btnBoard13.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard11
            // 
            btnBoard11.BackColor = Color.White;
            btnBoard11.FlatAppearance.BorderSize = 0;
            btnBoard11.FlatStyle = FlatStyle.Popup;
            btnBoard11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard11.Location = new Point(359, 216);
            btnBoard11.Name = "btnBoard11";
            btnBoard11.Size = new Size(64, 84);
            btnBoard11.TabIndex = 11;
            btnBoard11.TextAlign = ContentAlignment.TopLeft;
            btnBoard11.UseVisualStyleBackColor = false;
            btnBoard11.Click += BoardButton_Click;
            btnBoard11.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard14
            // 
            btnBoard14.BackColor = Color.White;
            btnBoard14.FlatAppearance.BorderSize = 0;
            btnBoard14.FlatStyle = FlatStyle.Popup;
            btnBoard14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard14.Location = new Point(571, 216);
            btnBoard14.Name = "btnBoard14";
            btnBoard14.Size = new Size(64, 84);
            btnBoard14.TabIndex = 14;
            btnBoard14.TextAlign = ContentAlignment.TopLeft;
            btnBoard14.UseVisualStyleBackColor = false;
            btnBoard14.Click += BoardButton_Click;
            btnBoard14.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard12
            // 
            btnBoard12.BackColor = Color.White;
            btnBoard12.FlatAppearance.BorderSize = 0;
            btnBoard12.FlatStyle = FlatStyle.Popup;
            btnBoard12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard12.Location = new Point(429, 216);
            btnBoard12.Name = "btnBoard12";
            btnBoard12.Size = new Size(64, 84);
            btnBoard12.TabIndex = 12;
            btnBoard12.TextAlign = ContentAlignment.TopLeft;
            btnBoard12.UseVisualStyleBackColor = false;
            btnBoard12.Click += BoardButton_Click;
            btnBoard12.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard15
            // 
            btnBoard15.BackColor = Color.White;
            btnBoard15.FlatAppearance.BorderSize = 0;
            btnBoard15.FlatStyle = FlatStyle.Popup;
            btnBoard15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard15.Location = new Point(641, 216);
            btnBoard15.Name = "btnBoard15";
            btnBoard15.Size = new Size(64, 84);
            btnBoard15.TabIndex = 15;
            btnBoard15.TextAlign = ContentAlignment.TopLeft;
            btnBoard15.UseVisualStyleBackColor = false;
            btnBoard15.Click += BoardButton_Click;
            btnBoard15.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard16
            // 
            btnBoard16.BackColor = Color.White;
            btnBoard16.FlatAppearance.BorderSize = 0;
            btnBoard16.FlatStyle = FlatStyle.Popup;
            btnBoard16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard16.Location = new Point(712, 216);
            btnBoard16.Name = "btnBoard16";
            btnBoard16.Size = new Size(64, 84);
            btnBoard16.TabIndex = 16;
            btnBoard16.TextAlign = ContentAlignment.TopLeft;
            btnBoard16.UseVisualStyleBackColor = false;
            btnBoard16.Click += BoardButton_Click;
            btnBoard16.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard17
            // 
            btnBoard17.BackColor = Color.White;
            btnBoard17.FlatAppearance.BorderSize = 0;
            btnBoard17.FlatStyle = FlatStyle.Popup;
            btnBoard17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard17.Location = new Point(782, 216);
            btnBoard17.Name = "btnBoard17";
            btnBoard17.Size = new Size(64, 84);
            btnBoard17.TabIndex = 17;
            btnBoard17.TextAlign = ContentAlignment.TopLeft;
            btnBoard17.UseVisualStyleBackColor = false;
            btnBoard17.Click += BoardButton_Click;
            btnBoard17.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard18
            // 
            btnBoard18.BackColor = Color.White;
            btnBoard18.FlatAppearance.BorderSize = 0;
            btnBoard18.FlatStyle = FlatStyle.Popup;
            btnBoard18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard18.Location = new Point(852, 216);
            btnBoard18.Name = "btnBoard18";
            btnBoard18.Size = new Size(64, 84);
            btnBoard18.TabIndex = 18;
            btnBoard18.TextAlign = ContentAlignment.TopLeft;
            btnBoard18.UseVisualStyleBackColor = false;
            btnBoard18.Click += BoardButton_Click;
            btnBoard18.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard19
            // 
            btnBoard19.BackColor = Color.White;
            btnBoard19.FlatAppearance.BorderSize = 0;
            btnBoard19.FlatStyle = FlatStyle.Popup;
            btnBoard19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard19.Location = new Point(255, 306);
            btnBoard19.Name = "btnBoard19";
            btnBoard19.Size = new Size(64, 84);
            btnBoard19.TabIndex = 19;
            btnBoard19.TextAlign = ContentAlignment.TopLeft;
            btnBoard19.UseVisualStyleBackColor = false;
            btnBoard19.Click += BoardButton_Click;
            btnBoard19.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard22
            // 
            btnBoard22.BackColor = Color.White;
            btnBoard22.FlatAppearance.BorderSize = 0;
            btnBoard22.FlatStyle = FlatStyle.Popup;
            btnBoard22.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard22.Location = new Point(467, 306);
            btnBoard22.Name = "btnBoard22";
            btnBoard22.Size = new Size(64, 84);
            btnBoard22.TabIndex = 22;
            btnBoard22.TextAlign = ContentAlignment.TopLeft;
            btnBoard22.UseVisualStyleBackColor = false;
            btnBoard22.Click += BoardButton_Click;
            btnBoard22.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard25
            // 
            btnBoard25.BackColor = Color.White;
            btnBoard25.FlatAppearance.BorderSize = 0;
            btnBoard25.FlatStyle = FlatStyle.Popup;
            btnBoard25.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard25.Location = new Point(678, 306);
            btnBoard25.Name = "btnBoard25";
            btnBoard25.Size = new Size(64, 84);
            btnBoard25.TabIndex = 25;
            btnBoard25.TextAlign = ContentAlignment.TopLeft;
            btnBoard25.UseVisualStyleBackColor = false;
            btnBoard25.Click += BoardButton_Click;
            btnBoard25.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard20
            // 
            btnBoard20.BackColor = Color.White;
            btnBoard20.FlatAppearance.BorderSize = 0;
            btnBoard20.FlatStyle = FlatStyle.Popup;
            btnBoard20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard20.Location = new Point(325, 306);
            btnBoard20.Name = "btnBoard20";
            btnBoard20.Size = new Size(64, 84);
            btnBoard20.TabIndex = 20;
            btnBoard20.TextAlign = ContentAlignment.TopLeft;
            btnBoard20.UseVisualStyleBackColor = false;
            btnBoard20.Click += BoardButton_Click;
            btnBoard20.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard23
            // 
            btnBoard23.BackColor = Color.White;
            btnBoard23.FlatAppearance.BorderSize = 0;
            btnBoard23.FlatStyle = FlatStyle.Popup;
            btnBoard23.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard23.Location = new Point(537, 306);
            btnBoard23.Name = "btnBoard23";
            btnBoard23.Size = new Size(64, 84);
            btnBoard23.TabIndex = 23;
            btnBoard23.TextAlign = ContentAlignment.TopLeft;
            btnBoard23.UseVisualStyleBackColor = false;
            btnBoard23.Click += BoardButton_Click;
            btnBoard23.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard26
            // 
            btnBoard26.BackColor = Color.White;
            btnBoard26.FlatAppearance.BorderSize = 0;
            btnBoard26.FlatStyle = FlatStyle.Popup;
            btnBoard26.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard26.Location = new Point(748, 306);
            btnBoard26.Name = "btnBoard26";
            btnBoard26.Size = new Size(64, 84);
            btnBoard26.TabIndex = 26;
            btnBoard26.TextAlign = ContentAlignment.TopLeft;
            btnBoard26.UseVisualStyleBackColor = false;
            btnBoard26.Click += BoardButton_Click;
            btnBoard26.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard21
            // 
            btnBoard21.BackColor = Color.White;
            btnBoard21.FlatAppearance.BorderSize = 0;
            btnBoard21.FlatStyle = FlatStyle.Popup;
            btnBoard21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard21.Location = new Point(395, 306);
            btnBoard21.Name = "btnBoard21";
            btnBoard21.Size = new Size(64, 84);
            btnBoard21.TabIndex = 21;
            btnBoard21.TextAlign = ContentAlignment.TopLeft;
            btnBoard21.UseVisualStyleBackColor = false;
            btnBoard21.Click += BoardButton_Click;
            btnBoard21.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard24
            // 
            btnBoard24.BackColor = Color.White;
            btnBoard24.FlatAppearance.BorderSize = 0;
            btnBoard24.FlatStyle = FlatStyle.Popup;
            btnBoard24.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard24.Location = new Point(607, 306);
            btnBoard24.Name = "btnBoard24";
            btnBoard24.Size = new Size(64, 84);
            btnBoard24.TabIndex = 24;
            btnBoard24.TextAlign = ContentAlignment.TopLeft;
            btnBoard24.UseVisualStyleBackColor = false;
            btnBoard24.Click += BoardButton_Click;
            btnBoard24.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard27
            // 
            btnBoard27.BackColor = Color.White;
            btnBoard27.FlatAppearance.BorderSize = 0;
            btnBoard27.FlatStyle = FlatStyle.Popup;
            btnBoard27.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard27.Location = new Point(818, 306);
            btnBoard27.Name = "btnBoard27";
            btnBoard27.Size = new Size(64, 84);
            btnBoard27.TabIndex = 27;
            btnBoard27.TextAlign = ContentAlignment.TopLeft;
            btnBoard27.UseVisualStyleBackColor = false;
            btnBoard27.Click += BoardButton_Click;
            btnBoard27.KeyPress += ListBox1_KeyPress;
            // 
            // btnBoard28
            // 
            btnBoard28.BackColor = Color.White;
            btnBoard28.FlatAppearance.BorderSize = 0;
            btnBoard28.FlatStyle = FlatStyle.Popup;
            btnBoard28.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBoard28.Location = new Point(888, 306);
            btnBoard28.Name = "btnBoard28";
            btnBoard28.Size = new Size(64, 84);
            btnBoard28.TabIndex = 28;
            btnBoard28.TextAlign = ContentAlignment.TopLeft;
            btnBoard28.UseVisualStyleBackColor = false;
            btnBoard28.Click += BoardButton_Click;
            btnBoard28.KeyPress += ListBox1_KeyPress;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(22, 615);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(934, 34);
            btnGenerate.TabIndex = 60;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(184, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(184, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(184, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F4;
            closeToolStripMenuItem.Size = new Size(184, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(184, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearBoardToolStripMenuItem, autoFillToolStripMenuItem, toolStripMenuItem2, undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem3, insertLeftToolStripMenuItem, insertRightToolStripMenuItem, deleteLeftToolStripMenuItem, deleteRightToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // clearBoardToolStripMenuItem
            // 
            clearBoardToolStripMenuItem.Name = "clearBoardToolStripMenuItem";
            clearBoardToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            clearBoardToolStripMenuItem.Size = new Size(196, 22);
            clearBoardToolStripMenuItem.Text = "Clear Board";
            clearBoardToolStripMenuItem.Click += ClearBoardToolStripMenuItem_Click;
            // 
            // autoFillToolStripMenuItem
            // 
            autoFillToolStripMenuItem.Name = "autoFillToolStripMenuItem";
            autoFillToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            autoFillToolStripMenuItem.Size = new Size(196, 22);
            autoFillToolStripMenuItem.Text = "Auto-Fill";
            autoFillToolStripMenuItem.Click += AutoFillToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(193, 6);
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(196, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += UndoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(196, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += RedoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(193, 6);
            // 
            // insertLeftToolStripMenuItem
            // 
            insertLeftToolStripMenuItem.Name = "insertLeftToolStripMenuItem";
            insertLeftToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.A;
            insertLeftToolStripMenuItem.Size = new Size(196, 22);
            insertLeftToolStripMenuItem.Text = "Insert Left";
            insertLeftToolStripMenuItem.Click += InsertLeftToolStripMenuItem_Click;
            // 
            // insertRightToolStripMenuItem
            // 
            insertRightToolStripMenuItem.Name = "insertRightToolStripMenuItem";
            insertRightToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D;
            insertRightToolStripMenuItem.Size = new Size(196, 22);
            insertRightToolStripMenuItem.Text = "Insert Right";
            insertRightToolStripMenuItem.Click += InsertRightToolStripMenuItem_Click;
            // 
            // deleteLeftToolStripMenuItem
            // 
            deleteLeftToolStripMenuItem.Name = "deleteLeftToolStripMenuItem";
            deleteLeftToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.A;
            deleteLeftToolStripMenuItem.Size = new Size(196, 22);
            deleteLeftToolStripMenuItem.Text = "Pop Left";
            deleteLeftToolStripMenuItem.Click += DeleteLeftToolStripMenuItem_Click;
            // 
            // deleteRightToolStripMenuItem
            // 
            deleteRightToolStripMenuItem.Name = "deleteRightToolStripMenuItem";
            deleteRightToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.D;
            deleteRightToolStripMenuItem.Size = new Size(196, 22);
            deleteRightToolStripMenuItem.Text = "Pop Right";
            deleteRightToolStripMenuItem.Click += DeleteRightToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F1;
            aboutToolStripMenuItem.Size = new Size(149, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // btnNone
            // 
            btnNone.BackColor = Color.White;
            btnNone.Location = new Point(60, 102);
            btnNone.Name = "btnNone";
            btnNone.Size = new Size(36, 40);
            btnNone.TabIndex = 0;
            btnNone.UseVisualStyleBackColor = false;
            btnNone.Click += BtnNone_Click;
            btnNone.KeyPress += ListBox1_KeyPress;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(30, 30);
            label1.TabIndex = 6;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TriPeaks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(btnBoard28);
            Controls.Add(btnBoard27);
            Controls.Add(btnBoard18);
            Controls.Add(btnBoard24);
            Controls.Add(btnBoard15);
            Controls.Add(btnBoard9);
            Controls.Add(btnBoard21);
            Controls.Add(btnBoard12);
            Controls.Add(btnBoard6);
            Controls.Add(btnBoard3);
            Controls.Add(btnPile24);
            Controls.Add(btnPile12);
            Controls.Add(btnPile18);
            Controls.Add(btnPile6);
            Controls.Add(btnBoard26);
            Controls.Add(btnBoard17);
            Controls.Add(btnBoard23);
            Controls.Add(btnBoard14);
            Controls.Add(btnBoard20);
            Controls.Add(btnBoard11);
            Controls.Add(btnBoard8);
            Controls.Add(btnBoard5);
            Controls.Add(btnBoard2);
            Controls.Add(btnPile23);
            Controls.Add(btnBoard25);
            Controls.Add(btnBoard16);
            Controls.Add(btnPile11);
            Controls.Add(btnBoard22);
            Controls.Add(btnBoard13);
            Controls.Add(btnPile17);
            Controls.Add(btnBoard19);
            Controls.Add(btnBoard7);
            Controls.Add(btnBoard10);
            Controls.Add(btnPile5);
            Controls.Add(btnBoard4);
            Controls.Add(btnBoard1);
            Controls.Add(btnPile22);
            Controls.Add(btnPile10);
            Controls.Add(btnPile16);
            Controls.Add(btnPile4);
            Controls.Add(btnPile21);
            Controls.Add(btnPile9);
            Controls.Add(btnPile15);
            Controls.Add(btnPile3);
            Controls.Add(btnPile20);
            Controls.Add(btnPile8);
            Controls.Add(btnPile19);
            Controls.Add(btnPile7);
            Controls.Add(btnPile14);
            Controls.Add(btnPile13);
            Controls.Add(btnPile2);
            Controls.Add(btnPile1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSpade);
            Controls.Add(btnHeart);
            Controls.Add(btnDiamond);
            Controls.Add(btnNone);
            Controls.Add(btnClub);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TriPeaks";
            Text = "TriPeaks Solver";
            Load += TriPeaks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnClub;
        private Button btnDiamond;
        private Button btnHeart;
        private Button btnSpade;
        private PictureBox pictureBox1;
        private Button btnPile1;
        private Button btnPile2;
        private Button btnPile3;
        private Button btnPile4;
        private Button btnPile5;
        private Button btnPile6;
        private Button btnPile7;
        private Button btnPile8;
        private Button btnPile9;
        private Button btnPile10;
        private Button btnPile11;
        private Button btnPile12;
        private Button btnPile13;
        private Button btnPile14;
        private Button btnPile19;
        private Button btnPile20;
        private Button btnPile15;
        private Button btnPile21;
        private Button btnPile16;
        private Button btnPile22;
        private Button btnPile17;
        private Button btnPile23;
        private Button btnPile18;
        private Button btnPile24;
        private Button btnBoard1;
        private Button btnBoard2;
        private Button btnBoard3;
        private Button btnBoard4;
        private Button btnBoard5;
        private Button btnBoard6;
        private Button btnBoard7;
        private Button btnBoard8;
        private Button btnBoard9;
        private Button btnBoard10;
        private Button btnBoard13;
        private Button btnBoard11;
        private Button btnBoard14;
        private Button btnBoard12;
        private Button btnBoard15;
        private Button btnBoard16;
        private Button btnBoard17;
        private Button btnBoard18;
        private Button btnBoard19;
        private Button btnBoard22;
        private Button btnBoard25;
        private Button btnBoard20;
        private Button btnBoard23;
        private Button btnBoard26;
        private Button btnBoard21;
        private Button btnBoard24;
        private Button btnBoard27;
        private Button btnBoard28;
        private Button btnGenerate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnNone;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem clearBoardToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem autoFillToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem insertLeftToolStripMenuItem;
        private ToolStripMenuItem insertRightToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem deleteLeftToolStripMenuItem;
        private ToolStripMenuItem deleteRightToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
    }
}
