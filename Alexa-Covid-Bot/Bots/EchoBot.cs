using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Alexa.NET.Response;
using Alexa.NET.Response.Directive;
using Alexa.NET.Response.Directive.Templates;
using Alexa.NET.Response.Directive.Templates.Types;
using Bot.Builder.Community.Adapters.Alexa.Core.Attachments;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;

namespace Bot.Builder.Community.Samples.Alexa.Bots
{
    public class EchoBot : ActivityHandler
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private const string endpointVar = "https://covidchatbotqnamaker.azurewebsites.net";
        private const string endpointKeyVar = "95798391-19fd-4463-bffa-3e64cfc182ef";
        private const string kbIdVar = "3d465425-0ccf-4b24-8f26-e360b7b75203";

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            switch (turnContext.Activity.Text.ToLower())
            {
                case "99":
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Here is the Privacy Policy."), cancellationToken);
                    break;
                default:
                    var uri = endpointVar + "/qnamaker/knowledgebases/" + kbIdVar + "/generateAnswer";

                    // JSON format for passing question to service
                    string question = @"{'question': '" + turnContext.Activity.Text + "'}";

                    // Create http client
                    using (var client = new HttpClient())
                    using (var request = new HttpRequestMessage())
                    {
                        // POST method
                        request.Method = HttpMethod.Post;

                        // Add host + service to get full URI
                        request.RequestUri = new Uri(uri);

                        // set question
                        request.Content = new StringContent(question, Encoding.UTF8, "application/json");

                        // set authorization
                        request.Headers.Add("Authorization", "EndpointKey " + endpointKeyVar);

                        // Send request to Azure service, get response
                        var response = client.SendAsync(request).Result;
                        var jsonResponse = response.Content.ReadAsStringAsync().Result;

                        // Output JSON response
                        Console.WriteLine(jsonResponse);
                        var qnaModel = JsonConvert.DeserializeObject<QnAModel>(jsonResponse);

                        await turnContext.SendActivityAsync(MessageFactory.Text($"{qnaModel.answers[0].answer}. What else can I do for you?", inputHint: InputHints.ExpectingInput), cancellationToken);
                        break;
                    }
            }
        }

        protected override async Task OnEventActivityAsync(ITurnContext<IEventActivity> turnContext, CancellationToken cancellationToken)
        {
            await turnContext.SendActivityAsync(
                $"Event received. Name: {turnContext.Activity.Name}. Value: {turnContext.Activity.Value}").ConfigureAwait(false);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Welcome to the Government's Automated Channel for guidance & information on our response to Coronavirus (COVID-19). \nSay something like 'Get me the active cases as of 13 march 2020'."), cancellationToken);
                }
            }
        }
    }

    public class QnAModel
    {
        public List<Answers> answers { get; set; }
    }

    public class Answers
    {
        public string answer { get; set; }
    }
}
