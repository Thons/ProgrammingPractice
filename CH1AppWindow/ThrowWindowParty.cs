using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CH01AppWindow
{
    class ThrowWindowParty : Application
    {
        [STAThread]
        static void Main(string[ ] args)
        {
            ThrowWindowParty app = new ThrowWindowParty();
            //app.ShutdownMode = ShutdownMode.OnMainWindowClose;
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window winMain = new Window();
            winMain.Title = "Main Window";
            winMain.MouseDown += new MouseButtonEventHandler(winMain_MouseDown);
            winMain.Show();

            for (int i = 0; i < 2; i++)
            {
                Window win = new Window();
                win.Title = "Extra window " + (i + 1);
                win.Show();
                win.ShowInTaskbar = false;
                //MainWindow = win;
                win.Owner = winMain;
            }
        }

        void winMain_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            win.Title = "Model dialog box";
            win.ShowDialog();
        }
    }
}