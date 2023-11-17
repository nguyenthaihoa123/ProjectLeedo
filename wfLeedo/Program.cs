using wfLeedo.view;

namespace wfLeedo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new fLogin());
            //Application.Run(new fKho());
            //Application.Run(new fThemNhanVien());
            //Application.Run(new fDonHang());
            Application.Run(new fThongKe());
        }
    }
}