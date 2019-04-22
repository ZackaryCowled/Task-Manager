namespace Task_Manager
{
    partial class TaskListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveTaskButton.Location = new System.Drawing.Point(154, 653);
            this.RemoveTaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(148, 45);
            this.RemoveTaskButton.TabIndex = 6;
            this.RemoveTaskButton.Text = "Remove Task";
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateTaskButton.Location = new System.Drawing.Point(2, 653);
            this.CreateTaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(148, 45);
            this.CreateTaskButton.TabIndex = 5;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // TaskList
            // 
            this.TaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskList.FormattingEnabled = true;
            this.TaskList.ItemHeight = 24;
            this.TaskList.Location = new System.Drawing.Point(3, 3);
            this.TaskList.Margin = new System.Windows.Forms.Padding(0);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(294, 652);
            this.TaskList.TabIndex = 4;
            this.TaskList.SelectedIndexChanged += new System.EventHandler(this.TaskList_SelectedIndexChanged);
            // 
            // TaskListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveTaskButton);
            this.Controls.Add(this.CreateTaskButton);
            this.Controls.Add(this.TaskList);
            this.Name = "TaskListControl";
            this.Size = new System.Drawing.Size(300, 700);
            this.Load += new System.EventHandler(this.TaskListControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveTaskButton;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.ListBox TaskList;
    }
}
