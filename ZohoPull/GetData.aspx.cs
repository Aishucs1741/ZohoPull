using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var access_token = File.ReadAllText("access_token.txt");
        var invoices = GetInvoices(access_token).Result;
        Console.WriteLine($"Invoices: {invoices}");
    }

    static async Task<string> GetInvoices(string access_token)
    {
        var url = "https://books.zoho.com/api/v3/invoices";

        var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Zoho-authtoken", access_token);
        var response = await client.GetAsync(url);
        var responseBody = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
        {
            return responseBody;
        }
        else
        {
            throw new Exception($"Failed to get invoices: {responseBody}");
        }
    }
}
