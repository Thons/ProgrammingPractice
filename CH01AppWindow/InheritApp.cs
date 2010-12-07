using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CH01AppWindow
{
    class InheritApp : Application
    {
        [STAThread]
        static void Main(string[ ] args)
        {
            InheritApp app = new InheritApp();
            app.Run();

            app.Exit += new ExitEventHandler(app_Exit);
        }

        static void app_Exit(object sender, ExitEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("您想要保存数据吗？", Application.Current.MainWindow.Title, MessageBoxButton.YesNoCancel, MessageBoxImage.Question, defaultResult: MessageBoxResult.Cancel);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window win = new Window();
            win.Title = "Inherit Applition";
            win.Show();
        }

        protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
        {
            base.OnSessionEnding(e);

            MessageBoxResult result = MessageBox.Show("您想要保存数据吗？", MainWindow.Title, MessageBoxButton.YesNoCancel, MessageBoxImage.Question, defaultResult: MessageBoxResult.Cancel);
            e.Cancel = (result == MessageBoxResult.Cancel);
        }

    }
}