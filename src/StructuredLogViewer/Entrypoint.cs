using System;
using System.Reflection;
using System.Windows;

namespace StructuredLogViewer
{
    public class Entrypoint
    {
        [STAThread]
        public static void Main(string[] args)
        {
            ExceptionHandler.Initialize();
            DialogService.ShowMessageBoxEvent += message => MessageBox.Show(message);
            ClipboardService.Set += Clipboard.SetText;

            var app = new Application();
            var window = new MainWindow();
            app.Run(window);
        }
    }
}
