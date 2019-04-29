namespace Task_Manager
{
    partial class ThemedTaskManagerForm
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
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeLabel.Location = new System.Drawing.Point(301, 46);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(0, 42);
            this.ThemeLabel.TabIndex = 3;
            // 
            // ThemedTaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 704);
            this.Controls.Add(this.ThemeLabel);
            this.Name = "ThemedTaskManagerForm";
            this.Text = "ThemedTaskManagerForm";
            this.Controls.SetChildIndex(this.ThemeLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label ThemeLabel;
    }
}