using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CH01AppWindow
{
    class InheritAppAndWindow
    {
        [STAThread]
        static void Main(string[ ] args)
        {
            MyApplication app = new MyApplication();
            app.Run();
        }
    }
}
