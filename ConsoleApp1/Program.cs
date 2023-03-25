using BotTwitter.Console.Implementacoes;
using BotTwitter.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Teste Post Twitter";

            IServicoTwitter servicoTwitter = new ServicoTwitter();

            while (true)
            {
                servicoTwitter.EnviarTweet();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[Program {0}] Função executada\n\n", DateTime.Now);
                Console.ResetColor();
                Thread.Sleep(600000);
            }
        }
    }
}
