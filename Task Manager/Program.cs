using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SpecialEventHandler specialEventHandler = new SpecialEventHandler();
            Type taskManagerFormType = specialEventHandler.GetEventValue(DateTime.Now);
            Application.Run((TaskManagerForm)Activator.CreateInstance(taskManagerFormType));
        }
    }
}
