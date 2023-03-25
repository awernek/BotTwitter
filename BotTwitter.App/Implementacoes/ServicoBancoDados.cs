using BotTwitter.App.Interfaces;
using System;
using System.IO;
using System.Text;

namespace BotTwitter.App.Implementacoes
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
                var stringBuilder = new StringBuilder(caminho);
                int indice = caminho.LastIndexOf(@"bin");

                while (indice < caminho.Length)
                {
                    stringBuilder[indice] = ' ';
                    indice++;
                }

                string caminhoDiretorio = new StringBuilder(stringBuilder.ToString().Trim()).Append(@"BancoDados\").ToString();

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
                var stringBuilder = new StringBuilder(caminho);
                int indice = caminho.LastIndexOf(@"bin");

                while (indice < caminho.Length)
                {
                    stringBuilder[indice] = ' ';
                    indice++;
                }

                string caminhoDiretorio = new StringBuilder(stringBuilder.ToString().Trim()).Append(@"Imagens\").ToString();

                return caminhoDiretorio;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string PegarDiretorioMensagensArquivo()
        {
            try
            {
                return PegarDiretorioBancoDados() + arquivoMensagensNome;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string PegarDiretorioImagensArquivo()
        {
            try
            {
                return PegarDiretorioBancoDados() + arquivoImagensNome;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CriarBancoDadosMensagens()
        {
            if (!VerificarBancoDadosMensagensExiste())
            {
                File.Create(PegarDiretorioMensagensArquivo()).Close();
            }
        }

        public void CriarBancoDadosImagens()
        {
            if (!VerificarBancoDadosImagensExiste())
            {
                File.Create(PegarDiretorioImagensArquivo()).Close();
            }
        }

        public bool VerificarBancoDadosMensagensExiste()
        {
            return File.Exists(PegarDiretorioMensagensArquivo());
        }

        public bool VerificarBancoDadosImagensExiste()
        {
            return File.Exists(PegarDiretorioImagensArquivo());
        }
    }
}
