using System;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

public class HttpClientDemo
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task Main()
    {
        Console.WriteLine("Check LOCATION of an IPv4");
        Console.WriteLine("\nENTER the IPv4 you want to know about location of that IP:");
        string ipCheck = Console.ReadLine();
        string info = "https://ipinfo.io/" + ipCheck + "/geo";

        Console.WriteLine("\nIPv4's location information:\n\n");
        HttpResponseMessage response = await client.GetAsync(info);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
    }
}
