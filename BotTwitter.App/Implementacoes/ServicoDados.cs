using BotTwitter.App.Interfaces;
using System;
using System.IO;

namespace BotTwitter.App.Implementacoes
{
    public class ServicoDados : IServicoDados
    {
        private IServicoBancoDados _servicoBancoDados = new ServicoBancoDados();

        public string PegarMensagem()
        {
            try
            {
                string mensagem = string.Empty;

                if (_servicoBancoDados.VerificarBancoDadosMensagensExiste())
                {
                    string[] listaMensagens = File.ReadAllLines(_servicoBancoDados.PegarDiretorioMensagensArquivo());
                    int indice = GerarIndice(listaMensagens.Length - 1);

                    mensagem = listaMensagens[indice];

                    return mensagem;
                }

                return mensagem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PegarUrlImagem()
        {
            try
            {
                string urlFoto = string.Empty;

                if (_servicoBancoDados.VerificarBancoDadosMensagensExiste())
                {
                    string diretorioImagens = _servicoBancoDados.PegarDiretorioImagens();
                    string[] listaUrl = File.ReadAllLines(_servicoBancoDados.PegarDiretorioImagensArquivo());
                    int indice = GerarIndice(listaUrl.Length - 1);

                    urlFoto = listaUrl[indice];

                    return diretorioImagens + urlFoto;
                }

                return urlFoto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int GerarIndice(int numeroMaximo)
        {
            return new Random().Next(0, numeroMaximo);
        }
    }
}
