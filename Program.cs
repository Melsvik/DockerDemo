using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DockerDemoPoker
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var name = "";
            var client = new HttpClient { BaseAddress = new Uri("https://mjolnerdockerdemo.azurewebsites.net/") };
            var response = await client.GetAsync($@"dockerdemo/GetToken?name={name}");

            if (response.IsSuccessStatusCode)
            {
                var token = await response.Content.ReadAsStringAsync();
                var content = new StringContent(JsonSerializer.Serialize(new Poke(name, token)), Encoding.UTF8, "application/json");
                response = await client.PutAsync(@"dockerdemo/Poke", content);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                    return;
                }
            }

            await LogError(response);
        }


        private static async Task LogError(HttpResponseMessage msg)
        {
            var json = await msg.Content.ReadAsStringAsync();
            var message = JsonSerializer.Deserialize<ServerResponse>(json);
            Console.WriteLine($"Error: {message.Detail}");
        }
    }
}
