using FNAScreenSaver.Core;

namespace FNAScreenSaver
{
    /// <summary>
    /// Класс запуска программы
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Точка входа программы
        /// </summary>
        public static void Main(string[] args)
        {
            using (var screenSaver = new GameEngine())
            {
                screenSaver.Run();
            }
        }
    }

}
