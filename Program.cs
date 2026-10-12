using System;
using System.Windows.Forms;
using PostServiceAppMax.Forms;

namespace PostServiceAppMax
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainListForm());
        }
    }
}