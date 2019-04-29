using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class ValentinesTaskManagerForm : ThemedTaskManagerForm
    {
        public ValentinesTaskManagerForm()
        {
            //Initialize and setup valentines task manager form
            InitializeComponent();
            ThemeLabel.Text = "Happy Valentines Day!";
        }
    }
}
