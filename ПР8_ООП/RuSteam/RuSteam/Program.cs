namespace RuSteam
{
    public static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new First_form());

        }
    }
}