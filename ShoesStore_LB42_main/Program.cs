namespace ShoesStore_LB42_main
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            bool exitProgram = false;

            while(!exitProgram)
            {
                using (var formLogin = new FormLogin())
                {
                    if (formLogin.ShowDialog() == DialogResult.OK)
                    {
                        using (var FormMenu = new FormMenu(
                            formLogin.CurrentUser,
                            formLogin.IsGuest))
                        {
                            if (FormMenu.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                            else
                            {
                                exitProgram = true;
                            }
                        }
                    }
                    else
                    {
                        exitProgram = true;
                    }
                }
            }
		}
	}
}
