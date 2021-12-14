using System;
using System.Threading;
using System.Windows.Forms;

namespace LookItUp
{
    public class ExceptionHandler
    {
        public static void Init()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException -= Handle;
            Application.ThreadException += Handle;
            AppDomain.CurrentDomain.UnhandledException -= CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                while (ex.InnerException != null)
                    ex = ex.InnerException;
            }

            MessageBox.Show(e.ExceptionObject.ToString());
        }

        private static void Handle(object sender, ThreadExceptionEventArgs e)
        {
            var ex = e.Exception;
            while (ex.InnerException != null)
                ex = ex.InnerException;


            using (var exceptionDlg = new ThreadExceptionDialog(ex))
            {

                var res = exceptionDlg.ShowDialog();
                if (res == DialogResult.Abort)
                    Application.Exit();
            }
        }
    }
}