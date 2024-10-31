using System;
using System.Windows.Forms;
using WidnowsFormsUI;

namespace WindowsFormsUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentMenuForm()); 
        }
    }
}
