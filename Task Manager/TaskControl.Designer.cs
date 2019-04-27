namespace Task_Manager
{
    partial class TaskControl
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.CompleteCheckbox = new System.Windows.Forms.CheckBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.AddTaskItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 7);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextbox.Location = new System.Drawing.Point(73, 3);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(490, 29);
            this.NameTextbox.TabIndex = 1;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // CompleteCheckbox
            // 
            this.CompleteCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteCheckbox.AutoSize = true;
            this.CompleteCheckbox.Location = new System.Drawing.Point(582, 7);
            this.CompleteCheckbox.Name = "CompleteCheckbox";
            this.CompleteCheckbox.Size = new System.Drawing.Size(122, 29);
            this.CompleteCheckbox.TabIndex = 3;
            this.CompleteCheckbox.Text = "Complete";
            this.CompleteCheckbox.UseVisualStyleBackColor = true;
            this.CompleteCheckbox.CheckedChanged += new System.EventHandler(this.CompleteCheckbox_CheckedChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 63);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(115, 25);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.AcceptsReturn = true;
            this.DescriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextbox.Location = new System.Drawing.Point(8, 91);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextbox.Size = new System.Drawing.Size(689, 116);
            this.DescriptionTextbox.TabIndex = 5;
            this.DescriptionTextbox.TextChanged += new System.EventHandler(this.DescriptionTextbox_TextChanged);
            // 
            // AddTaskItemButton
            // 
            this.AddTaskItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTaskItemButton.Location = new System.Drawing.Point(8, 654);
            this.AddTaskItemButton.Name = "AddTaskItemButton";
            this.AddTaskItemButton.Size = new System.Drawing.Size(694, 45);
            this.AddTaskItemButton.TabIndex = 7;
            this.AddTaskItemButton.Text = "Add Task Item";
            this.AddTaskItemButton.UseVisualStyleBackColor = true;
            this.AddTaskItemButton.Click += new System.EventHandler(this.AddTaskItemButton_Click);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddTaskItemButton);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.CompleteCheckbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.NameLabel);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(700, 700);
            this.Load += new System.EventHandler(this.TaskControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.CheckBox CompleteCheckbox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.Button AddTaskItemButton;
    }
}
