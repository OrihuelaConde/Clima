using System;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace Clima
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ClimaDTO ClimaDTO = new ClimaDTO();
            await ObtenerClima("Chivilcoy");

            Console.WriteLine(ClimaDTO.Region);
            Console.Write("Humedad: ");
            Console.WriteLine(ClimaDTO.CurrentConditions.Humidity);
            Console.WriteLine();
            Console.WriteLine("Próximos 7 días: ");
            foreach(NextDay nextDay in ClimaDTO.NextDays)
            {
                Console.Write($"{nextDay.Day}: ");
                Console.WriteLine($"Mínima {nextDay.MinTemp.C}° - Máxima {nextDay.MinTemp.C}°");
            }

            // Método para obtener los datos del clima desde una API
            async Task ObtenerClima(string ciudad)
            {
                var client = new RestClient("https://weatherdbi.herokuapp.com/data/weather");
                var request = new RestRequest(ciudad);
                var response = await client.GetAsync(request);
                ClimaDTO = JsonSerializer.Deserialize<ClimaDTO>(response.Content);
            }
        }
    }
}
