namespace BotTwitter.App.Interfaces
{
    public interface IServicoDados
    {
        string PegarMensagem();
        string PegarUrlImagem();
        int GerarIndice(int numeroMaximo);
    }
}
