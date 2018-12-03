using System;
using MyFavoriteScriptCommand.Core;
using MyFavoriteScriptCommand.Scenes;
using Tips.ConsoleApp;

namespace MyFavoriteScriptCommand
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var loop = new MainLoop()
                {
                    NextSceneSet = new MethodOfOperationScene(),
                };
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
