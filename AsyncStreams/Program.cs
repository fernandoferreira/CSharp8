using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreams
{
    class Program
    {
        //Forma tradicional
        //  private async static IEnumerable<int> GetHeartBeat()
        //         {
        //             await Task.Delay(3000);
        //             Console.WriteLine($"Last check: {DateTime.Now}");
        //              yield return new Random().Next(40, 250);
        //         }

        //Utiliazndo IAsyncEnumerable
        private async static IAsyncEnumerable<int> GetHeartBeatAsync()
        {
            await Task.Delay(3000);
            Console.WriteLine($"Last check: {DateTime.Now}");
            yield return new Random().Next(40, 250);
        }

        private async static void ShowHeartBeatAsync()
        {
            for (int i = 0; i < 5; i++)
            {

                await foreach (var item in GetHeartBeatAsync())
                {
                    Console.WriteLine($"Current heart beat: {item}\n");
                }
            }
        }

        static void Main(string[] args)
        {
            ShowHeartBeatAsync();
            Console.ReadLine();
        }
    }
}
