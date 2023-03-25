using BotTwitter.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotTwitter.Console.Implementacoes
{
    public class ServicoDados : IServicoDados
    {
        private IServicoBancoDados _servicoBancoDados = new ServicoBancoDados();
        
        public string PegarMensagem()
        {
            try
            {
                string mensagem = String.Empty;

                if (_servicoBancoDados.VerificarBancoDadosMensagensExiste())
                {
                    string[] listaMensagens = File.ReadAllLines(_servicoBancoDados.PegarDiretorioArquivoMensagens());
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
                string urlFoto = String.Empty;

                if (_servicoBancoDados.VerificarBancoDadosMensagensExiste())
                {
                    string diretorioImagens = _servicoBancoDados.PegarDiretorioImagens();
                    string[] listaMensagens = File.ReadAllLines(_servicoBancoDados.PegarDiretorioImagens());
                    int indice = GerarIndice(listaMensagens.Length - 1);
                    urlFoto = listaMensagens[indice];
                    return diretorioImagens + urlFoto;
                }

                return urlFoto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int GerarIndice(int v)
        {
            throw new NotImplementedException();
        }
    }
}
