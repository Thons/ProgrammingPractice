using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CH01AppWindow
{
    class InheritWin
    {
        [STAThread]
        static void Main(string[ ] args)
        {
            
            Application app = new Application();
            app.Run();
        }
    }
}
