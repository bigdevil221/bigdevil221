namespace demo3
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
            //Application.Run(new Form1());
            //Application.Run(new tableave());
            //Application.Run(new LinksMove());
            //Application.Run(new LocationMove());
            //Application.Run(new textboxRgx());
            //Application.Run(new HighLight());
            //Application.Run(new selectFouce());
            //Application.Run(new EnterTable());
              Application.Run(new close());

        }
    }
}