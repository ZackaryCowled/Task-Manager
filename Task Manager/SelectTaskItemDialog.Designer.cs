namespace Task_Manager
{
    partial class SelectTaskItemDialog
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
            this.TaskItemTypeList = new System.Windows.Forms.ListBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.TerminateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskItemTypeList
            // 
            this.TaskItemTypeList.FormattingEnabled = true;
            this.TaskItemTypeList.ItemHeight = 24;
            this.TaskItemTypeList.Location = new System.Drawing.Point(13, 13);
            this.TaskItemTypeList.Name = "TaskItemTypeList";
            this.TaskItemTypeList.Size = new System.Drawing.Size(751, 124);
            this.TaskItemTypeList.TabIndex = 0;
            this.TaskItemTypeList.SelectedIndexChanged += new System.EventHandler(this.TaskItemTypeList_SelectedIndexChanged);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(389, 143);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(375, 40);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // TerminateButton
            // 
            this.TerminateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TerminateButton.Location = new System.Drawing.Point(12, 143);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size(375, 40);
            this.TerminateButton.TabIndex = 2;
            this.TerminateButton.Text = "Cancel";
            this.TerminateButton.UseVisualStyleBackColor = true;
            // 
            // SelectTaskItemDialog
            // 
            this.AcceptButton = this.SelectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 186);
            this.Controls.Add(this.TerminateButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.TaskItemTypeList);
            this.Name = "SelectTaskItemDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Task Item";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TaskItemTypeList;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button TerminateButton;
    }
}