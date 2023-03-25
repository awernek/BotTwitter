using BotTwitter.Console.Interfaces;
using System;
using System.Text;

namespace BotTwitter.Console.Implementacoes
{
    public class ServicoBancoDados : IServicoBancoDados
    {
        private const string arquivoImagensNome = "ImagensBancoDados.txt";
        private const string arquivoMensagensNome = "MensagensBancoDados.txt";

        public string PegarDiretorioBancoDados()
        {
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory;
                StringBuilder stringBuilder = new StringBuilder(caminho);
                int indice = caminho.LastIndexOf(@"bin");

                while (indice < caminho.Length)
                {
                    stringBuilder[indice] = ' ';
                    indice++;
                }

                string caminhoDiretorio = new StringBuilder(stringBuilder.ToString().Trim()).Append(@"BancoDados").ToString();

                return caminhoDiretorio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PegarDiretorioImagens()
        {
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory;
                StringBuilder stringBuilder = new StringBuilder(caminho);
                int indice = caminho.LastIndexOf(@"bin");

                while (indice < caminho.Length)
                {
                    stringBuilder[indice] = ' ';
                    indice++;
                }

                string caminhoDiretorio = new StringBuilder(stringBuilder.ToString().Trim()).Append(@"Imagens").ToString();

                return caminhoDiretorio;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string PegarDiretorioMensagens()
        {
            try
            {
                return PegarDiretorioBancoDados() + arquivoMensagensNome;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
