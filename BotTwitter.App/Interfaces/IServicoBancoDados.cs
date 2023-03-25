namespace BotTwitter.App.Interfaces
{
    public interface IServicoBancoDados
    {
        string PegarDiretorioBancoDados();
        string PegarDiretorioImagens();
        string PegarDiretorioMensagensArquivo();
        string PegarDiretorioImagensArquivo();
        void CriarBancoDadosMensagens();
        void CriarBancoDadosImagens();
        bool VerificarBancoDadosMensagensExiste();
        bool VerificarBancoDadosImagensExiste();
    }
}
