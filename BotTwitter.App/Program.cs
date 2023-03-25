using BotTwitter.App.Implementacoes;
using BotTwitter.App.Interfaces;
using System;
using System.Threading;

namespace BotTwitter.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Teste bot twitter";

                IServicoTwitter servicoTwitter = new ServicoTwitter();

                while (true)
                {
                    servicoTwitter.EnviarTweet();

                    Thread.Sleep(600000);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
