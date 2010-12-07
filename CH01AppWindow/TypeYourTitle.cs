using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CH01AppWindow
{
    class TypeYourTitle:Window
    {
        [STAThread]
        static void Main(string[ ] args)
        {
            Application app = new Application();
            app.Run(new TypeYourTitle());
        }

        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            base.OnTextInput(e);

            if (e.Text == "\b" && Title.Length > 0)
                Title = Title.Substring(0, Title.Length - 1);
            else if (e.Text.Length > 0 && !Char.IsControl(e.Text[0]))
                Title += e.Text;
        }
    }
}
