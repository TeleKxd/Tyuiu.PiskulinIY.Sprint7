using System.IO;
using Tyuiu.PiskulinIY.Sprint7.Task0.V13.Lib;
namespace Tyuiu.PiskulinIY.Sprint7.Task0.V13
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
            Application.Run(new FormMain());
        }
    }
}