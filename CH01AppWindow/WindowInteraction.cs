/*
 * 这个小程序非注释代码运行结果是每次按下↑键或↓键，就会将窗口尺寸增大或减小10%
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CH01AppWindow
{
    class WindowInteraction : Window
    {
        [STAThread]
        static void Main(string[ ] args)
        {

            Application app = new Application();
            app.Run(new WindowInteraction());
        }

        public WindowInteraction()
        {
            double w = SystemParameters.PrimaryScreenWidth;
            double h = SystemParameters.PrimaryScreenHeight;
            double ww = SystemParameters.WorkArea.Width;
            double wh = SystemParameters.WorkArea.Height;
            double wl = SystemParameters.WorkArea.Left;
            double wt = SystemParameters.WorkArea.Top;
            double wb = SystemParameters.WorkArea.Bottom;
            double wr = SystemParameters.WorkArea.Right;

            this.Title = "Say Hello";

            Width = 800;
            Height = 300;

            //将窗口放在屏幕右下方
            //win.Left = w - win.Width;
            //win.Top = h - win.Height;

            //将窗口放在除任务栏区域的右下方
            //win.Left = ww - win.Width;
            //win.Top = wh - win.Height;

            //将窗口放在除任务栏区域的中间
            //win.Left = (ww - win.Width) / 2 + wl;
            //win.Top = (wh - win.Height) / 2 + wt;

            //此方法同样可以设置窗口启动时的位置
            //居中
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            //以下几个属性（包括但不限于）控制窗口的外观和行为
            //WindowStyle = WindowStyle.ToolWindow;
            //ResizeMode = ResizeMode.CanResizeWithGrip;
            //WindowState = WindowState.Maximized;
            //Topmost = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Key == Key.Up)
            {
                Left -= 0.05 * Width;
                Top -= 0.05 * Height;
                Width *= 1.1;
                Height *= 1.1;
            }
            else if (e.Key == Key.Down)
            {
                Left += 0.05 * (Width /= 1.1);
                Top += 0.05 * (Height /= 1.1);
            }
        }
    }
}
