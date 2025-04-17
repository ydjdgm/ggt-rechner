namespace ggt
{
    internal static class Program
    {
        private static IModel model;
        private static IView view;
        private static IController controller;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            view = new View();
            controller = new Controller();
            //view.controller = controller;
            controller.view = view;
            view.controller = controller;

            Application.Run(new View());
        }
    }
}