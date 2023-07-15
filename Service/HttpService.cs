using System;
using System.Text;
using System.Text.Json;
using GeraPadroesNumericos.Service.Model;

namespace GeraPadroesNumericos.Service
{
    public static class HttpService
    {

        private static readonly HttpClient client = new();

        public static async void SendResult(List<long> listNumber)
        {
            var result = PrepareListToSend(listNumber);

            var test = new ListModelDto
            {
                data = result
            };

            var json = JsonSerializer.Serialize(test);

            using StringContent jsonContent = new(json, Encoding.UTF8, "application/json");

            using HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:8000/data", jsonContent);

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"{jsonResponse}\n");

        }

        public static string PrepareListToSend(List<long> listNumber)
        {
            var result = new StringBuilder();

            for (int i = 0; i < listNumber.Count(); i++)
            {
                result.Append(listNumber[i]);
                if (i < (listNumber.Count() - 1))
                    result.Append(", ");
            }

            return result.ToString();
        }
    }
}

