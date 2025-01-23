namespace NoteAppUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool result;
            Mutex mutex = new(true, "UniqueAppId", out result);
            if (!result)
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            GC.KeepAlive(mutex);
        }
    }
}