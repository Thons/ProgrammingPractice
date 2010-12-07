using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CH01AppWindow
{
    class MyWindow : Window
    {
        public MyWindow()
        {
            Title = "Inherit App and Window";
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);

            string msg = String.Format("Window clicked with {0} button at point ({1})", e.ChangedButton, e.GetPosition(this));
            MessageBox.Show(msg, Title);
        }
    }
}
