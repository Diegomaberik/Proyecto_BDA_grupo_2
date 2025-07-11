using System;
using System.Windows.Forms;

namespace CView
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoginEvento()); // Aquí usamos el nombre correcto
        }
    }
}
