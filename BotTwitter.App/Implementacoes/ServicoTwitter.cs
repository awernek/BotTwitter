using BotTwitter.App.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using TweetSharp;

namespace BotTwitter.App.Implementacoes
{
    public class ServicoTwitter : IServicoTwitter
    {
        private const string consumerKey = "";
        private const string consumerSecret = "";
        private const string accessToken = "";
        private const string accessTokenSecret = "";
        private const string hashTags = "";

        private readonly IServicoDados _servicoDados = new ServicoDados();

        public TwitterService ConfigurarUsuarioTwitter()
        {
            TwitterService service = new TwitterService(consumerKey, consumerSecret, accessToken, accessTokenSecret);

            return service;
        }

        public void EnviarTweet()
        {
            string urlFoto = _servicoDados.PegarUrlImagem();
            string mensagem = _servicoDados.PegarMensagem();
            string tweet = MontarTweet(mensagem, hashTags);

            try
            {
                using (var fileStream = new FileStream(urlFoto, FileMode.Open))
                {
                    TwitterService twitterService = ConfigurarUsuarioTwitter();

                    twitterService.BeginSendTweetWithMedia(new SendTweetWithMediaOptions
                    {
                        Status = tweet,
                        Images = new Dictionary<string, Stream> { { urlFoto, fileStream } }
                    });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private string MontarTweet(string mensagem, string hashTags)
        {
            return mensagem + "\n" + hashTags;
        }
    }
}
