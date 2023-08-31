namespace ToDoList
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtInputTask = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remindMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeaderTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.plMain = new System.Windows.Forms.Panel();
            this.plRemaindMe = new System.Windows.Forms.Panel();
            this.btnCancelTime = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.NumericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.btnSaveTime = new System.Windows.Forms.Button();
            this.lblRemaind = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.NumericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.plActions = new System.Windows.Forms.Panel();
            this.btnRemindMe = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.plMain.SuspendLayout();
            this.plRemaindMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHour)).BeginInit();
            this.plActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 150;
            // 
            // txtInputTask
            // 
            this.txtInputTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.txtInputTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputTask.ForeColor = System.Drawing.Color.Black;
            this.txtInputTask.Location = new System.Drawing.Point(56, 73);
            this.txtInputTask.Multiline = true;
            this.txtInputTask.Name = "txtInputTask";
            this.txtInputTask.Size = new System.Drawing.Size(445, 30);
            this.txtInputTask.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(855, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.remindMeToolStripMenuItem,
            this.markAsCompletedToolStripMenuItem,
            this.toolStripMenuItem1,
            this.lightModeToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.OptionsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.OptionsToolStripMenuItem.Text = "&Options";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.removeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // remindMeToolStripMenuItem
            // 
            this.remindMeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.remindMeToolStripMenuItem.Name = "remindMeToolStripMenuItem";
            this.remindMeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.remindMeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.remindMeToolStripMenuItem.Text = "Remind &Me";
            this.remindMeToolStripMenuItem.Click += new System.EventHandler(this.remindMeToolStripMenuItem_Click);
            // 
            // markAsCompletedToolStripMenuItem
            // 
            this.markAsCompletedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.markAsCompletedToolStripMenuItem.Name = "markAsCompletedToolStripMenuItem";
            this.markAsCompletedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.markAsCompletedToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.markAsCompletedToolStripMenuItem.Text = "MarkAs&Completed";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 6);
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lightModeToolStripMenuItem.Checked = true;
            this.lightModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.lightModeToolStripMenuItem.Text = "&Light Mode";
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.darkModeToolStripMenuItem.Text = "&Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker.CustomFormat = "00/00/00";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider1.SetIconAlignment(this.dateTimePicker, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.dateTimePicker.Location = new System.Drawing.Point(667, 73);
            this.dateTimePicker.MaxDate = new System.DateTime(2024, 8, 23, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2023, 8, 23, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(127, 26);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2023, 8, 23, 0, 0, 0, 0);
            // 
            // listViewTasks
            // 
            this.listViewTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.listViewTasks.BackgroundImageTiled = true;
            this.listViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTask,
            this.columnHeaderDate,
            this.columnHeaderTime});
            this.listViewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTasks.ForeColor = System.Drawing.Color.Black;
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTasks.HideSelection = false;
            this.errorProvider1.SetIconPadding(this.listViewTasks, 5);
            this.listViewTasks.Location = new System.Drawing.Point(56, 109);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(605, 291);
            this.listViewTasks.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTasks.TabIndex = 4;
            this.listViewTasks.TileSize = new System.Drawing.Size(10, 10);
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.SelectedIndexChanged += new System.EventHandler(this.listViewTasks_SelectedIndexChanged);
            // 
            // columnHeaderTask
            // 
            this.columnHeaderTask.Text = "Task";
            this.columnHeaderTask.Width = 300;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.Width = 150;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(78)))));
            this.btnAddNewTask.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.btnAddNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTask.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewTask.Location = new System.Drawing.Point(507, 73);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(154, 30);
            this.btnAddNewTask.TabIndex = 0;
            this.btnAddNewTask.Tag = "Add";
            this.btnAddNewTask.Text = "Add";
            this.btnAddNewTask.UseVisualStyleBackColor = false;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.plMain.Controls.Add(this.plRemaindMe);
            this.plMain.Controls.Add(this.plActions);
            this.plMain.Controls.Add(this.lblTitle);
            this.plMain.Controls.Add(this.dateTimePicker);
            this.plMain.Controls.Add(this.listViewTasks);
            this.plMain.Controls.Add(this.btnAddNewTask);
            this.plMain.Controls.Add(this.txtInputTask);
            this.plMain.Controls.Add(this.menuStrip);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(855, 451);
            this.plMain.TabIndex = 2;
            // 
            // plRemaindMe
            // 
            this.plRemaindMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.plRemaindMe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plRemaindMe.Controls.Add(this.btnCancelTime);
            this.plRemaindMe.Controls.Add(this.lblMin);
            this.plRemaindMe.Controls.Add(this.NumericUpDownMin);
            this.plRemaindMe.Controls.Add(this.btnSaveTime);
            this.plRemaindMe.Controls.Add(this.lblRemaind);
            this.plRemaindMe.Controls.Add(this.lblHour);
            this.plRemaindMe.Controls.Add(this.NumericUpDownHour);
            this.plRemaindMe.Location = new System.Drawing.Point(186, 173);
            this.plRemaindMe.Name = "plRemaindMe";
            this.plRemaindMe.Size = new System.Drawing.Size(337, 188);
            this.plRemaindMe.TabIndex = 11;
            this.plRemaindMe.Visible = false;
            // 
            // btnCancelTime
            // 
            this.btnCancelTime.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(78)))));
            this.btnCancelTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCancelTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.btnCancelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTime.ForeColor = System.Drawing.Color.Black;
            this.btnCancelTime.Location = new System.Drawing.Point(177, 138);
            this.btnCancelTime.Name = "btnCancelTime";
            this.btnCancelTime.Size = new System.Drawing.Size(111, 29);
            this.btnCancelTime.TabIndex = 15;
            this.btnCancelTime.Text = "Cancel";
            this.btnCancelTime.UseVisualStyleBackColor = false;
            this.btnCancelTime.Click += new System.EventHandler(this.btnCancelTime_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Black;
            this.lblMin.Location = new System.Drawing.Point(109, 84);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(33, 17);
            this.lblMin.TabIndex = 14;
            this.lblMin.Text = "Min";
            // 
            // NumericUpDownMin
            // 
            this.NumericUpDownMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.NumericUpDownMin.ForeColor = System.Drawing.Color.Black;
            this.NumericUpDownMin.Location = new System.Drawing.Point(160, 82);
            this.NumericUpDownMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownMin.Name = "NumericUpDownMin";
            this.NumericUpDownMin.Size = new System.Drawing.Size(66, 20);
            this.NumericUpDownMin.TabIndex = 12;
            this.NumericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSaveTime
            // 
            this.btnSaveTime.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(78)))));
            this.btnSaveTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSaveTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.btnSaveTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTime.ForeColor = System.Drawing.Color.Black;
            this.btnSaveTime.Location = new System.Drawing.Point(47, 138);
            this.btnSaveTime.Name = "btnSaveTime";
            this.btnSaveTime.Size = new System.Drawing.Size(111, 29);
            this.btnSaveTime.TabIndex = 11;
            this.btnSaveTime.Text = "Save";
            this.btnSaveTime.UseVisualStyleBackColor = false;
            this.btnSaveTime.Click += new System.EventHandler(this.btnSaveTime_Click);
            // 
            // lblRemaind
            // 
            this.lblRemaind.AutoSize = true;
            this.lblRemaind.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaind.ForeColor = System.Drawing.Color.Black;
            this.lblRemaind.Location = new System.Drawing.Point(89, 19);
            this.lblRemaind.Name = "lblRemaind";
            this.lblRemaind.Size = new System.Drawing.Size(177, 34);
            this.lblRemaind.TabIndex = 9;
            this.lblRemaind.Text = "Reminde me after ";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.Black;
            this.lblHour.Location = new System.Drawing.Point(103, 59);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(43, 17);
            this.lblHour.TabIndex = 10;
            this.lblHour.Text = "Hour";
            // 
            // NumericUpDownHour
            // 
            this.NumericUpDownHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.NumericUpDownHour.ForeColor = System.Drawing.Color.Black;
            this.NumericUpDownHour.Location = new System.Drawing.Point(160, 56);
            this.NumericUpDownHour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumericUpDownHour.Name = "NumericUpDownHour";
            this.NumericUpDownHour.Size = new System.Drawing.Size(66, 20);
            this.NumericUpDownHour.TabIndex = 8;
            this.NumericUpDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plActions
            // 
            this.plActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.plActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plActions.Controls.Add(this.btnRemindMe);
            this.plActions.Controls.Add(this.btnComplete);
            this.plActions.Controls.Add(this.btnUpdate);
            this.plActions.Controls.Add(this.btnRemove);
            this.plActions.Location = new System.Drawing.Point(667, 109);
            this.plActions.Name = "plActions";
            this.plActions.Size = new System.Drawing.Size(127, 291);
            this.plActions.TabIndex = 3;
            // 
            // btnRemindMe
            // 
            this.btnRemindMe.BackColor = System.Drawing.Color.Transparent;
            this.btnRemindMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemindMe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(78)))));
            this.btnRemindMe.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRemindMe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemindMe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.btnRemindMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemindMe.ForeColor = System.Drawing.Color.Black;
            this.btnRemindMe.Location = new System.Drawing.Point(17, 226);
            this.btnRemindMe.Name = "btnRemindMe";
            this.btnRemindMe.Size = new System.Drawing.Size(92, 40);
            this.btnRemindMe.TabIndex = 3;
            this.btnRemindMe.Text = "Remind Me";
            this.btnRemindMe.UseVisualStyleBackColor = false;
            this.btnRemindMe.Click += new System.EventHandler(this.btnRemaindMe_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(78)))));
            this.btnComplete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnComplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnComplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.ForeColor = System.Drawing.Color.Black;
            this.btnComplete.Location = new System.Drawing.Point(17, 157);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(92, 40);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Tag = "Completed";
            this.btnComplete.Text = "Completed";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(78)))));
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(17, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(78)))));
            this.btnRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(17, 25);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 40);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(53, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Add New Task";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 451);
            this.Controls.Add(this.plMain);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.plMain.ResumeLayout(false);
            this.plMain.PerformLayout();
            this.plRemaindMe.ResumeLayout(false);
            this.plRemaindMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHour)).EndInit();
            this.plActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.TextBox txtInputTask;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remindMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel plRemaindMe;
        private System.Windows.Forms.Button btnCancelTime;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown NumericUpDownMin;
        private System.Windows.Forms.Button btnSaveTime;
        private System.Windows.Forms.Label lblRemaind;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.NumericUpDown NumericUpDownHour;
        private System.Windows.Forms.Panel plActions;
        private System.Windows.Forms.Button btnRemindMe;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeaderTask;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
    }
}

