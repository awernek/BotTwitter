namespace BotTwitter.Console.Interfaces
{
    public interface IServicoBancoDados
    {
        string PegarDiretorioBancoDados();
        string PegarDiretorioImagens();
        string PegarDiretorioMensagens();
        bool VerificarBancoDadosMensagensExiste();
        string PegarDiretorioArquivoMensagens();
    }
}
