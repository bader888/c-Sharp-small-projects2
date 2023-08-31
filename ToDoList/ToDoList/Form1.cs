using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// =====================================
        /// =====>((functionality of App))<======
        /// =====================================
        /// 
        ///======>[[[  (1)- Add New Task:                  ]]]<======
        ///======>[[[  (2)- Remove Task:                   ]]]<======
        ///======>[[[  (3)- Mark as Completed/Uncompleted: ]]]<======
        ///======>[[[  (4)- Update Task:                   ]]]<======
        ///======>[[[  (5)- Dark-Light Mode:               ]]]<======
        ///======>[[[  (6)- Task Reminder:                 ]]]<======
        ///
        /// ===============================================
        /// =====>((More Features You Can Add ))<==========
        /// ===============================================
        /// 1-Search about Task
        /// 2-Sorting Tasks
        /// 
        /// ===================================
        /// =====>((Keyboard Shortcuts))<======
        /// ===================================
        /// 
        /// Add New Task: [ Ctrl + D ]
        /// 
        /// Remove Task:  [ Delete key ]
        /// 
        /// Mark as Completed/Uncompleted:[ Ctrl + M ]
        /// 
        /// Update Task: [ Ctrl + U ]
        /// 
        /// Dark-Light Mode: [ f1==dark ,, f2==light]
        ///
        /// Task Reminder: [ Ctrl + R ] 
        /// 
        /// 
        /// ===================================
        /// =====>((Used Controls ))<==========
        /// ===================================
        /// 1-Lable
        /// 2-text Box
        /// 3-Buttom
        /// 4-DataTimePicker
        /// 5-Panel
        /// 6-Listview
        /// 7-NumerckUpDown
        /// 8-MenuStrip
        /// 9-ErrorProvider
        /// 10-NotifiyIcon
        /// 11-Timer
        /// ====================================
        ///  

        /// ====>((Made by Bader Hadier ))<======
        /// Contact With Me ==>[ Insta:014b_ || Telegram:014b_ ]
        /// 
        /// </summary>



        //***************************************// 
        //*************((Global))***************// 
        //*************************************// 

        ListViewGroup group1 = new ListViewGroup("Completed", HorizontalAlignment.Left);

        stTask Task;
        stTimer Timer;
        stRemaindTime RemaindTime;

        struct stTask
        {
            public string Text;
            public string Date;
            public string Time;
            public bool Update;

        }

        struct stRemaindTime
        {
            public int Hour;
            public int Min;
            public int Counter;
        }

        struct stTimer
        {
            public int sec;
            public int min;
            public int hour;
            public stTask task;
        }

        private void TimerReset()
        {
            Timer.sec = 0;
            Timer.min = 0;
            Timer.hour = 0;
        }

        private void ShowNotifcation()
        {
            stTask SelectedTaskData = GetTaskData(GetTheSelectedTask());

            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Reminde you";
            notifyIcon1.BalloonTipText = $"You Should Do:{SelectedTaskData.Text}";
            notifyIcon1.ShowBalloonTip(1000);

            TimerReset();
        }

        private stTask GetTaskData(ListViewItem Item)
        {
            stTask Task = new stTask();

            Task.Text = Item.Text;
            Task.Date = Item.SubItems[0].Text;
            Task.Time = Item.SubItems[1].Text;

            return Task;
        }

        private ListViewItem GetTheSelectedTask()
        {
            ListViewItem selectedItem = new ListViewItem();

            if (listViewTasks.SelectedItems.Count > 0)
            {

                selectedItem = listViewTasks.SelectedItems[0];


            }

            return selectedItem;
        }

        private stTask GetNewTaskData()
        {
            stTask task = new stTask();

            task.Text = txtInputTask.Text;
            task.Date = dateTimePicker.Value.ToShortDateString();
            task.Time = dateTimePicker.Value.ToShortTimeString();

            return task;
        }

        private ListViewItem CreateNewTask(stTask TaskData)
        {

            ListViewItem NewItem = new ListViewItem();

            //set the user input in new item 
            NewItem.Text = TaskData.Text;
            NewItem.SubItems.Add(TaskData.Date);
            NewItem.SubItems.Add(TaskData.Time);


            //return the new item
            return NewItem;

        }

        private void RemoveItemFromDefultGroup(ListViewItem item)
        {
            //remove the selected item from the defult group

            listViewTasks.Items.Remove(item);
        }

        private void RemoveTaskFromCompletedGroup()
        {
            ListViewItem UnCompletedTask = GetTheSelectedTask();

            //remove the completed task
            RemoveTask();

            //add task to defult group 
            listViewTasks.Items.Add(UnCompletedTask);

            //make task Uncheck 
            UnCompletedTask.Checked = false;

        }

        private void AddNewTaskToCompletedGroup()
        {
            //if there is no group ==> create one
            if (listViewTasks.Groups.Count < 1)
            {
                listViewTasks.Groups.Add(group1);
            }

            // Create new task
            ListViewItem CompletedTask = GetTheSelectedTask();

            //remove task from the Defult group
            RemoveItemFromDefultGroup(CompletedTask);


            //add new task to the completed group
            group1.Items.Add(CompletedTask);

            //add new task to the list
            listViewTasks.Items.Add(CompletedTask);

            //make task checked 
            CompletedTask.Checked = true;



        }

        //***************************************// 
        //*************((ACTIONS))**************// 
        //*************************************// 

        private void AddNewTask()
        {

            //up date mode
            if (Task.Update)
            {
                UpdateTask();

                return;

            }
            stTask NewTaskData = GetNewTaskData();

            //create new task
            ListViewItem NewTask = CreateNewTask(NewTaskData);

            //add new Task to the list
            listViewTasks.Items.Add(NewTask);

        }

        private void RemoveTask()
        {
            //remove more than one item  
            //loop on each Item , if item Selected Remove it from the list 
            for (int i = listViewTasks.Items.Count - 1; i >= 0; i--)
            {
                if (listViewTasks.Items[i].Selected)
                {
                    listViewTasks.Items.RemoveAt(i);
                }
            }
        }

        private void MarkTaskAsUnCompleted()
        {

            RemoveTaskFromCompletedGroup();

        }

        private void MarkTaskAsCompleted()
        {

            AddNewTaskToCompletedGroup();


        }

        private void RemaindMe()
        {

            ShowNotifcation();

            //stop the timer
            timer1.Enabled = false;

            return;

        }

        private void UpdateTask()
        {

            btnAddNewTask.Text = "Add";
            Task.Update = false;

            if (listViewTasks.SelectedItems.Count > 0)
            {
                //get updated date 
                stTask latestData = GetNewTaskData();

                ListViewItem SelectedItem = GetTheSelectedTask();

                //clear old data
                SelectedItem.SubItems.Clear();

                //add new data to task
                SelectedItem.Text = latestData.Text;
                SelectedItem.SubItems.Add(latestData.Date);
                SelectedItem.SubItems.Add(latestData.Time);
            }
        }


        //**************************************// 
        //*************((EVENR))***************// 
        //*************************************//


        //add btn 
        private void btnAddNewTask_Click(object sender, System.EventArgs e)
        {

            //check if the text box is empty
            if (string.IsNullOrWhiteSpace(txtInputTask.Text))
            {
                errorProvider1.SetError(btnAddNewTask, "Write Task First");
            }
            else
            {
                errorProvider1.Clear();

                //add new task
                AddNewTask();

                txtInputTask.Clear();
                txtInputTask.Focus();
            }

        }

        //remove btn
        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count == 0)
            {

                errorProvider1.SetError(btnRemove, "Select Task First");

            }
            else
            {
                if ((MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    errorProvider1.Clear();


                    RemoveTask();


                }

            }

        }

        //update btn
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {


            if (listViewTasks.SelectedItems.Count == 0)
            {
                errorProvider1.SetError(btnUpdate, "You Can Update One item each Time!");

                return;
            }

            if (listViewTasks.SelectedItems.Count > 1)
            {
                errorProvider1.SetError(btnUpdate, "You Can Update One item each Time!");

            }
            else
            {

                //remove the error Icon
                errorProvider1.Clear();

                Task.Update = true;

                //change the add btn text from add to Update
                btnAddNewTask.Text = "Update";

                //get the text of selected item and set it in input text 
                txtInputTask.Text = listViewTasks.SelectedItems[0].Text;

                txtInputTask.Focus();


            }
        }

        //completed btn
        private void btnComplete_Click(object sender, System.EventArgs e)
        {

            if (listViewTasks.SelectedItems.Count > 1 || listViewTasks.SelectedItems.Count == 0)
            {
                errorProvider1.SetError(btnComplete, "Selecte One item!");

            }
            else
            {
                if (btnComplete.Tag == "Completed")
                {
                    MarkTaskAsCompleted();

                    //remove the error Icon
                    errorProvider1.Clear();
                    return;
                }

                if (btnComplete.Tag == "UnCompleted")
                {

                    MarkTaskAsUnCompleted();

                    //remove the error Icon
                    errorProvider1.Clear();
                    return;
                }
            }

        }

        //remaind me btn
        private void btnRemaindMe_Click(object sender, System.EventArgs e)
        {

            if (listViewTasks.SelectedItems.Count > 1 || listViewTasks.SelectedItems.Count == 0)
            {
                errorProvider1.SetError(btnRemindMe, "Selecte One item!");
            }
            else
            {
                //show the Remaind me box
                plRemaindMe.Visible = true;

                ListViewItem SelectedTask = GetTheSelectedTask();

                Timer.task = GetTaskData(SelectedTask);

                //remove the error Icon
                errorProvider1.Clear();


                //timer start when start btn click

            }


        }

        //misc
        private void btnSaveTime_Click(object sender, System.EventArgs e)
        {

            //get the hour and min that user chose
            RemaindTime.Hour = int.Parse(NumericUpDownHour.Value.ToString());
            RemaindTime.Min = int.Parse(NumericUpDownMin.Value.ToString());

            //start the timer
            timer1.Enabled = true;

            //hide the Remaind me box
            plRemaindMe.Visible = false;


        }

        private void btnCancelTime_Click(object sender, System.EventArgs e)
        {
            plRemaindMe.Visible = false;

        }

        private void dateTimePicker_ValueChanged(object sender, System.EventArgs e)
        {
            Task.Date = dateTimePicker.Value.ToShortDateString().ToString();
        }

        private void listViewTasks_SelectedIndexChanged(object sender, System.EventArgs e)
        {


            ListViewItem SelectedItem = GetTheSelectedTask();

            //check the item is completed or not --> if item check it mean completed
            if (SelectedItem.Checked)
            {
                btnComplete.Text = "UnCompleted";
                btnComplete.Tag = "UnCompleted";
                OptionsToolStripMenuItem.DropDownItems[4].Text = "Mark As UnCompleted";
            }
            else
            {
                btnComplete.Text = "Completed";
                btnComplete.Tag = "Completed";
                OptionsToolStripMenuItem.DropDownItems[4].Text = "Mark As Completed";

            }

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            Timer.sec++;

            if (Timer.sec == 60)
            {
                Timer.sec = 0;
                Timer.min++;
            }
            if (Timer.min == 60)
            {
                Timer.sec = 0;
                Timer.min = 0;
                Timer.hour++;
            }

            if (Timer.hour == 12)
            {
                Timer.sec = 0;
                Timer.min = 0;
                Timer.hour = 0;
                return;
            }
            if (Timer.min == RemaindTime.Min && Timer.hour == RemaindTime.Hour)
            {
                RemaindMe();
            }

        }


        //************************************************// 
        //*************((Dark/Light Mood))***************// 
        //**********************************************// 


        private void ChangeTextColor(int red, int green, int blue)
        {
            //lable text color
            lblTitle.ForeColor = Color.FromArgb(red, green, blue);
            lblMin.ForeColor = Color.FromArgb(red, green, blue);
            lblHour.ForeColor = Color.FromArgb(red, green, blue);
            lblRemaind.ForeColor = Color.FromArgb(red, green, blue);

            //menuItem text color
            OptionsToolStripMenuItem.ForeColor = Color.FromArgb(red, green, blue);

            //btns text color
            btnAddNewTask.ForeColor = Color.FromArgb(red, green, blue);

            btnComplete.ForeColor = Color.FromArgb(red, green, blue);
            btnUpdate.ForeColor = Color.FromArgb(red, green, blue);
            btnRemove.ForeColor = Color.FromArgb(red, green, blue);
            btnComplete.ForeColor = Color.FromArgb(red, green, blue);
            btnRemindMe.ForeColor = Color.FromArgb(red, green, blue);
            btnSaveTime.ForeColor = Color.FromArgb(red, green, blue);
            btnCancelTime.ForeColor = Color.FromArgb(red, green, blue);

            //color font of textBox
            txtInputTask.ForeColor = Color.FromArgb(red, green, blue);

            //tasks color
            ChangeTaskColor(red, green, blue);

            //text stripMenuItem
            addToolStripMenuItem.ForeColor = Color.FromArgb(red, green, blue);
            remindMeToolStripMenuItem.ForeColor = Color.FromArgb(red, green, blue);
            removeToolStripMenuItem.ForeColor = Color.FromArgb(red, green, blue);
            markAsCompletedToolStripMenuItem.ForeColor = Color.FromArgb(red, green, blue);
            updateToolStripMenuItem.ForeColor = Color.FromArgb(red, green, blue);


            lightModeToolStripMenuItem.ForeColor = Color.FromArgb(red, green, blue);
            darkModeToolStripMenuItem.ForeColor = Color.FromArgb(red, green, blue);

            //text numericUpDown 
            NumericUpDownHour.ForeColor = Color.FromArgb(red, green, blue);
            NumericUpDownMin.ForeColor = Color.FromArgb(red, green, blue);


        }

        private void ChangeMenuStripAndBtnsColor(int red, int green, int blue)
        {
            //menuStrip
            menuStrip.BackColor = Color.FromArgb(red, green, blue);

            //btn text
            btnAddNewTask.FlatAppearance.BorderColor = Color.FromArgb(red, green, blue);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(red, green, blue);
            btnRemove.FlatAppearance.BorderColor = Color.FromArgb(red, green, blue);
            btnComplete.FlatAppearance.BorderColor = Color.FromArgb(red, green, blue);
            btnAddNewTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(red, green, blue);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(red, green, blue);
            btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(red, green, blue);
            btnComplete.FlatAppearance.MouseOverBackColor = Color.FromArgb(red, green, blue);


            btnSaveTime.FlatAppearance.BorderColor = Color.FromArgb(red, green, blue);
            btnRemindMe.FlatAppearance.BorderColor = Color.FromArgb(red, green, blue);
            btnCancelTime.FlatAppearance.BorderColor = Color.FromArgb(red, green, blue);
            btnSaveTime.FlatAppearance.MouseOverBackColor = Color.FromArgb(red, green, blue);
            btnRemindMe.FlatAppearance.MouseOverBackColor = Color.FromArgb(red, green, blue);
            btnCancelTime.FlatAppearance.MouseOverBackColor = Color.FromArgb(red, green, blue);

        }

        private void ChangeMainPanalAndRemaindMePanalColor(int red, int green, int blue)
        {

            plRemaindMe.BackColor = Color.FromArgb(red, green, blue);
            plMain.BackColor = Color.FromArgb(red, green, blue);
        }

        private void ChangeListViewTasksAndActionsPanalColor(int red, int green, int blue)
        {
            listViewTasks.BackColor = Color.FromArgb(red, green, blue);
            plActions.BackColor = Color.FromArgb(red, green, blue);
            NumericUpDownHour.BackColor = Color.FromArgb(red, green, blue);
            NumericUpDownMin.BackColor = Color.FromArgb(red, green, blue);

        }

        private void ChangeTaskColor(int red, int green, int blue)
        {
            //loop on each Item  , and change the bgColor
            for (int i = listViewTasks.Items.Count - 1; i >= 0; i--)
            {

                listViewTasks.Items[i].ForeColor = Color.FromArgb(red, green, blue);

            }
        }

        private void ChangeStripMenuItemsColor(int red, int green, int blue)
        {
            addToolStripMenuItem.BackColor = Color.FromArgb(red, green, blue);
            remindMeToolStripMenuItem.BackColor = Color.FromArgb(red, green, blue);
            removeToolStripMenuItem.BackColor = Color.FromArgb(red, green, blue);
            markAsCompletedToolStripMenuItem.BackColor = Color.FromArgb(red, green, blue);
            updateToolStripMenuItem.BackColor = Color.FromArgb(red, green, blue);

            lightModeToolStripMenuItem.BackColor = Color.FromArgb(red, green, blue);
            darkModeToolStripMenuItem.BackColor = Color.FromArgb(red, green, blue);

        }

        private void DarkMode()
        {

            //all text 
            ChangeTextColor(255, 255, 255);

            //text box 
            txtInputTask.BackColor = Color.FromArgb(43, 43, 43);

            //containers
            ChangeMainPanalAndRemaindMePanalColor(25, 16, 16);
            ChangeListViewTasksAndActionsPanalColor(43, 43, 43);

            //menuStrip  and border btn
            ChangeMenuStripAndBtnsColor(58, 33, 33);

            ChangeStripMenuItemsColor(43, 43, 43);
        }

        private void lightMode()
        {
            //all text 
            ChangeTextColor(0, 0, 0);

            //text box 
            txtInputTask.BackColor = Color.FromArgb(217, 226, 239);

            //containers 
            ChangeMainPanalAndRemaindMePanalColor(250, 247, 247);
            ChangeListViewTasksAndActionsPanalColor(217, 226, 239);

            //menuStrip  and btn border
            ChangeMenuStripAndBtnsColor(30, 115, 175);

            // StripMenuItem
            ChangeStripMenuItemsColor(250, 247, 247);

        }

        private void darkModeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DarkMode();
            lightModeToolStripMenuItem.Checked = false;
            darkModeToolStripMenuItem.Checked = true;
        }

        private void lightModeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            lightMode();
            lightModeToolStripMenuItem.Checked = true;
            darkModeToolStripMenuItem.Checked = false;
        }

        //***************************************************************// 
        //*************((Do Action From Tool Strip Menu))***************// 
        //*************************************************************//

        //remove
        private void removeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            btnRemove.PerformClick();
        }

        //Add
        private void addToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            btnAddNewTask.PerformClick();
        }

        //Update
        private void updateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            btnUpdate.PerformClick();
        }

        //remaind Me
        private void remindMeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            btnRemindMe.PerformClick();
        }

        //mark as Completed
        private void MarkTaskAsCompletedToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            btnComplete.PerformClick();

        }
    }
}
