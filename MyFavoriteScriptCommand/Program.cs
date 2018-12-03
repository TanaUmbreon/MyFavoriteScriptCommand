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
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
            finally
            {
                ConsoleEx.Timeout(milliseconds:15000);
            }
        }

        private static void ShowErrorMessage(Exception ex)
        {
            var before = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(ex.Message);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{AssemblyInfo.Title} は動作を停止しました。");

            Console.ForegroundColor = before;
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine();
        }
    }
}
