using IBM.WatsonDeveloperCloud.Assistant.v2;
using IBM.WatsonDeveloperCloud.Assistant.v2.Model;

namespace WatsonLib
{

    public class WatsonProsadorInstancia
    {

        string password;
        string assistantId;
        string pergunta;
        string url;
        string username;


        public WatsonProsadorInstancia()
        {
            pergunta = "";
            url = "https://gateway.watsonplatform.net/assistant/api";
            username = "apikey";
            password = "u38Mpwg9ObVHv78IrJvNtBIO9n85VJBUydh3ta6QwRCL";
            assistantId = "d7e27d20-2763-4647-9bc2-5eb1b613eb36";

            var conv = new AssistantServiceExample(url, username, password, assistantId);
        }

        //string workspaceId = "Customer Service - Sample";

        //var conv = new AssistantServiceExample(url, username, password, assistantId);


        //    pergunta = "Boa Noite";
        //        var retorno = conv.CallAssistant(pergunta);
        //    Console.WriteLine(retorno);
        //        Console.Read();
    }

    public class AssistantServiceExample
    {
        private AssistantService _assistant;
        private string _assistantId;

        private string _sessionId;

        public AssistantServiceExample(string url, string username, string password, string assistantId)
        {
            //The current version for V1 is 2018 - 09 - 20.
            //The only supported version for V2 is 2018 - 11 - 08.
            //The "Try it out" pane in the Watson Assistant tooling is using version 2018 - 07 - 10.

            _assistant = new AssistantService("apikey", "u38Mpwg9ObVHv78IrJvNtBIO9n85VJBUydh3ta6QwRCL", "2018-11-08");
            _assistant.SetEndpoint(url);

            _assistantId = assistantId;

            var session = _assistant.CreateSession(_assistantId);
            _sessionId = session.SessionId;

        }

        public string CallAssistant(string pergunta)
        {
            MessageRequest messageRequest = new MessageRequest()
            {
                Input = new MessageInput()
                {
                    Text = pergunta
                }
            };

            var result = _assistant.Message(_assistantId, _sessionId, messageRequest);
            string resposta = result.Output.Generic[0].Text;

            if (pergunta.Length > 1)
            {
                // CallAssistant(pergunta);
            }
            else
            {
                _assistant.DeleteSession(_assistantId, _sessionId);

            }

            return resposta;
        }
    }
}
