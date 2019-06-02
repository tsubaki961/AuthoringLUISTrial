using Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring;
using System;
using System.Threading.Tasks;

namespace AuthoringLUISTrial
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Type App Id");
            var appId = Guid.Parse(Console.ReadLine());

            Console.WriteLine("Type Authoring Key");
            var authoringKey = Console.ReadLine();

            // Create Authoring Client
            using (var client = new LUISAuthoringClient(new ApiKeyServiceClientCredentials(authoringKey)) { Endpoint = "https://westus.api.cognitive.microsoft.com" })
            {
                // Get App
                var app = await client.Apps.GetAsync(appId);

                // Get ActiveVersion
                var activeVersion = app.ActiveVersion;
            }
        }
    }
}
