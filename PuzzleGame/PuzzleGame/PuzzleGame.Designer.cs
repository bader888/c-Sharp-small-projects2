namespace PuzzleGame
{
    partial class PuzzleGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleGame));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStartGame = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboWordType = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPagePlayGame = new System.Windows.Forms.TabPage();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.lblFailedAttempts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeighScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panalBody = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackWord = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRefrsh = new System.Windows.Forms.Button();
            this.TableTobLetters = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picHint = new System.Windows.Forms.PictureBox();
            this.btnHint = new System.Windows.Forms.Button();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.tabPageFinalResult = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFinalFailedAttempts = new System.Windows.Forms.Label();
            this.lblFinalHightScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageStartGame.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPagePlayGame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panalBody.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.TableTobLetters.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHint)).BeginInit();
            this.groupBoxTimer.SuspendLayout();
            this.tabPageFinalResult.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStartGame);
            this.tabControlMain.Controls.Add(this.tabPagePlayGame);
            this.tabControlMain.Controls.Add(this.tabPageFinalResult);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(541, 451);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageStartGame
            // 
            this.tabPageStartGame.Controls.Add(this.panel4);
            this.tabPageStartGame.Controls.Add(this.panel3);
            this.tabPageStartGame.Location = new System.Drawing.Point(4, 22);
            this.tabPageStartGame.Name = "tabPageStartGame";
            this.tabPageStartGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStartGame.Size = new System.Drawing.Size(533, 425);
            this.tabPageStartGame.TabIndex = 0;
            this.tabPageStartGame.Text = "Start";
            this.tabPageStartGame.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(288, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 419);
            this.panel4.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "WORD PUZZLE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(163)))), ((int)(((byte)(172)))));
            this.groupBox2.Controls.Add(this.btnPlayGame);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboWordType);
            this.groupBox2.Location = new System.Drawing.Point(21, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 242);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Options";
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(106)))), ((int)(((byte)(88)))));
            this.btnPlayGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayGame.Location = new System.Drawing.Point(54, 138);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(93, 32);
            this.btnPlayGame.TabIndex = 4;
            this.btnPlayGame.Text = "PLay";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Word Type";
            // 
            // comboWordType
            // 
            this.comboWordType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(163)))), ((int)(((byte)(172)))));
            this.comboWordType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboWordType.FormattingEnabled = true;
            this.comboWordType.Items.AddRange(new object[] {
            "Food",
            "Animal"});
            this.comboWordType.Location = new System.Drawing.Point(20, 89);
            this.comboWordType.Name = "comboWordType";
            this.comboWordType.Size = new System.Drawing.Size(160, 21);
            this.comboWordType.TabIndex = 1;
            this.comboWordType.Text = "Food";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 419);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPagePlayGame
            // 
            this.tabPagePlayGame.BackColor = System.Drawing.Color.Black;
            this.tabPagePlayGame.Controls.Add(this.progressBarMain);
            this.tabPagePlayGame.Controls.Add(this.lblFailedAttempts);
            this.tabPagePlayGame.Controls.Add(this.label5);
            this.tabPagePlayGame.Controls.Add(this.lblHeighScore);
            this.tabPagePlayGame.Controls.Add(this.label4);
            this.tabPagePlayGame.Controls.Add(this.label3);
            this.tabPagePlayGame.Controls.Add(this.panel1);
            this.tabPagePlayGame.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayGame.Name = "tabPagePlayGame";
            this.tabPagePlayGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayGame.Size = new System.Drawing.Size(533, 425);
            this.tabPagePlayGame.TabIndex = 1;
            this.tabPagePlayGame.Text = "Play";
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(16, 72);
            this.progressBarMain.Maximum = 50;
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(501, 10);
            this.progressBarMain.Step = 1;
            this.progressBarMain.TabIndex = 21;
            // 
            // lblFailedAttempts
            // 
            this.lblFailedAttempts.AutoSize = true;
            this.lblFailedAttempts.ForeColor = System.Drawing.Color.White;
            this.lblFailedAttempts.Location = new System.Drawing.Point(386, 89);
            this.lblFailedAttempts.Name = "lblFailedAttempts";
            this.lblFailedAttempts.Size = new System.Drawing.Size(13, 13);
            this.lblFailedAttempts.TabIndex = 20;
            this.lblFailedAttempts.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(295, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Failed  Attempts:";
            // 
            // lblHeighScore
            // 
            this.lblHeighScore.AutoSize = true;
            this.lblHeighScore.ForeColor = System.Drawing.Color.White;
            this.lblHeighScore.Location = new System.Drawing.Point(214, 89);
            this.lblHeighScore.Name = "lblHeighScore";
            this.lblHeighScore.Size = new System.Drawing.Size(13, 13);
            this.lblHeighScore.TabIndex = 18;
            this.lblHeighScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(134, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Highest Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 51);
            this.label3.TabIndex = 16;
            this.label3.Text = "WORD PUZZLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panalBody);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtWord);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 301);
            this.panel1.TabIndex = 12;
            // 
            // panalBody
            // 
            this.panalBody.Controls.Add(this.tableLayoutPanel3);
            this.panalBody.Controls.Add(this.TableTobLetters);
            this.panalBody.Location = new System.Drawing.Point(140, 75);
            this.panalBody.Name = "panalBody";
            this.panalBody.Size = new System.Drawing.Size(342, 204);
            this.panalBody.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89971F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.76791F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33238F));
            this.tableLayoutPanel3.Controls.Add(this.btnBackWord, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSubmit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRefrsh, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(-3, 155);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.2987F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(349, 50);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // btnBackWord
            // 
            this.btnBackWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBackWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackWord.BackgroundImage")));
            this.btnBackWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackWord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBackWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackWord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackWord.Location = new System.Drawing.Point(294, 3);
            this.btnBackWord.Name = "btnBackWord";
            this.btnBackWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBackWord.Size = new System.Drawing.Size(52, 44);
            this.btnBackWord.TabIndex = 2;
            this.btnBackWord.Text = " ";
            this.btnBackWord.UseVisualStyleBackColor = false;
            this.btnBackWord.Click += new System.EventHandler(this.btnBackWord_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(54, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(234, 44);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = " Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnRefrsh
            // 
            this.btnRefrsh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnRefrsh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefrsh.BackgroundImage")));
            this.btnRefrsh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefrsh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrsh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefrsh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefrsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrsh.Location = new System.Drawing.Point(3, 3);
            this.btnRefrsh.Name = "btnRefrsh";
            this.btnRefrsh.Size = new System.Drawing.Size(45, 44);
            this.btnRefrsh.TabIndex = 0;
            this.btnRefrsh.UseVisualStyleBackColor = false;
            this.btnRefrsh.Click += new System.EventHandler(this.btnRefrsh_Click);
            // 
            // TableTobLetters
            // 
            this.TableTobLetters.BackColor = System.Drawing.Color.Transparent;
            this.TableTobLetters.ColumnCount = 4;
            this.TableTobLetters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableTobLetters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableTobLetters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableTobLetters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableTobLetters.Controls.Add(this.button4, 0, 1);
            this.TableTobLetters.Controls.Add(this.button3, 0, 1);
            this.TableTobLetters.Controls.Add(this.button2, 0, 1);
            this.TableTobLetters.Controls.Add(this.button1, 0, 1);
            this.TableTobLetters.Controls.Add(this.button8, 3, 0);
            this.TableTobLetters.Controls.Add(this.button7, 2, 0);
            this.TableTobLetters.Controls.Add(this.button6, 1, 0);
            this.TableTobLetters.Controls.Add(this.button5, 0, 0);
            this.TableTobLetters.Location = new System.Drawing.Point(-3, 0);
            this.TableTobLetters.Name = "TableTobLetters";
            this.TableTobLetters.RowCount = 2;
            this.TableTobLetters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.2987F));
            this.TableTobLetters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.TableTobLetters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TableTobLetters.Size = new System.Drawing.Size(349, 149);
            this.TableTobLetters.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 65);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnLetter_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(90, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 65);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnLetter_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(177, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 65);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnLetter_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(264, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 65);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLetter_Tick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(264, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 72);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnLetter_Tick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(177, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 72);
            this.button7.TabIndex = 2;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnLetter_Tick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(90, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 72);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnLetter_Tick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 72);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnLetter_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBoxTimer);
            this.panel2.Location = new System.Drawing.Point(17, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 275);
            this.panel2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picHint);
            this.groupBox1.Controls.Add(this.btnHint);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 157);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hint";
            // 
            // picHint
            // 
            this.picHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.picHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHint.Image = ((System.Drawing.Image)(resources.GetObject("picHint.Image")));
            this.picHint.Location = new System.Drawing.Point(3, 17);
            this.picHint.Name = "picHint";
            this.picHint.Size = new System.Drawing.Size(93, 107);
            this.picHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHint.TabIndex = 13;
            this.picHint.TabStop = false;
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHint.BackgroundImage")));
            this.btnHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(3, 124);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(93, 30);
            this.btnHint.TabIndex = 12;
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxTimer.Controls.Add(this.btnPause);
            this.groupBoxTimer.Controls.Add(this.lblTimer);
            this.groupBoxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxTimer.ForeColor = System.Drawing.Color.White;
            this.groupBoxTimer.Location = new System.Drawing.Point(1, 3);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(99, 85);
            this.groupBoxTimer.TabIndex = 14;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "Timer";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(3, 52);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(93, 30);
            this.btnPause.TabIndex = 14;
            this.btnPause.Tag = "Stop";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(34, 29);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(29, 15);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "(00)";
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.ForeColor = System.Drawing.Color.White;
            this.txtWord.Location = new System.Drawing.Point(140, 26);
            this.txtWord.MaxLength = 10;
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(343, 43);
            this.txtWord.TabIndex = 9;
            this.txtWord.Text = "Click Letter To Select";
            // 
            // tabPageFinalResult
            // 
            this.tabPageFinalResult.Controls.Add(this.panel6);
            this.tabPageFinalResult.Controls.Add(this.panel5);
            this.tabPageFinalResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageFinalResult.Name = "tabPageFinalResult";
            this.tabPageFinalResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinalResult.Size = new System.Drawing.Size(533, 425);
            this.tabPageFinalResult.TabIndex = 2;
            this.tabPageFinalResult.Text = "Final Result";
            this.tabPageFinalResult.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(7)))), ((int)(((byte)(4)))));
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(313, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(217, 419);
            this.panel6.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(63, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "FINAL RESULT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "WORD PUZZLE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblFinalFailedAttempts);
            this.groupBox3.Controls.Add(this.lblFinalHightScore);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnPlayAgain);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(14, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 283);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Result";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Failed  Attempts:";
            // 
            // lblFinalFailedAttempts
            // 
            this.lblFinalFailedAttempts.AutoSize = true;
            this.lblFinalFailedAttempts.Location = new System.Drawing.Point(85, 162);
            this.lblFinalFailedAttempts.Name = "lblFinalFailedAttempts";
            this.lblFinalFailedAttempts.Size = new System.Drawing.Size(19, 13);
            this.lblFinalFailedAttempts.TabIndex = 8;
            this.lblFinalFailedAttempts.Text = "(5)";
            // 
            // lblFinalHightScore
            // 
            this.lblFinalHightScore.AutoSize = true;
            this.lblFinalHightScore.Location = new System.Drawing.Point(82, 87);
            this.lblFinalHightScore.Name = "lblFinalHightScore";
            this.lblFinalHightScore.Size = new System.Drawing.Size(25, 13);
            this.lblFinalHightScore.TabIndex = 6;
            this.lblFinalHightScore.Text = "(00)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hight Score";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(88)))));
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btnPlayAgain.Location = new System.Drawing.Point(48, 216);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(93, 32);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 419);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 419);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 451);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(557, 490);
            this.MinimumSize = new System.Drawing.Size(557, 490);
            this.Name = "PuzzleGame";
            this.Text = "Puzzle Game";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStartGame.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPagePlayGame.ResumeLayout(false);
            this.tabPagePlayGame.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panalBody.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.TableTobLetters.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHint)).EndInit();
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            this.tabPageFinalResult.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStartGame;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPagePlayGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picHint;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TabPage tabPageFinalResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboWordType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panalBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnBackWord;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRefrsh;
        private System.Windows.Forms.TableLayoutPanel TableTobLetters;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHeighScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFailedAttempts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblFinalHightScore;
        private System.Windows.Forms.Label lblFinalFailedAttempts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

