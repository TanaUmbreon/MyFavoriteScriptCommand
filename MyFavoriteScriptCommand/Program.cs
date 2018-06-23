using System;
using MyFavoriteScriptCommand.Core;
using Tips.ConsoleApp;

namespace MyFavoriteScriptCommand
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var loop = new SceneLoop() { CurrentScene = new WishSelectionScene() };
                loop.Run();
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine();
                Console.WriteLine("操作はキャンセルされました");
            }
            finally
            {
                ConsoleEx.Timeout(milliseconds:10000);
            }
        }
    }
}
