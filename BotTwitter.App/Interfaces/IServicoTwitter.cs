using TweetSharp;

namespace BotTwitter.App.Interfaces
{
    public interface IServicoTwitter
    {
        TwitterService ConfigurarUsuarioTwitter();

        void EnviarTweet();
    }
}
