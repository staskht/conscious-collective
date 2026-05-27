namespace Services;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ServiceContracts;
using ServiceContracts.DTOs;
using ServiceContracts.Options;
using System.Net.Http.Json;

public class WikiRateClient : IWikiRateAnswerService
{
    private readonly HttpClient _httpClient;
    private readonly WikiRateOptions _options;

    public WikiRateClient(HttpClient httpClient, IOptions<WikiRateOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;

    }

    public async Task<WikiRateAnswerDto?> GetFashionTransparencyIndex(string companyName)
    {
        string url = $"{_options.BaseUrl}+{companyName}+2025.json?api_key={_options.ApiKey}";
        
        HttpResponseMessage responseMessage = await _httpClient.GetAsync(url);

        if (!responseMessage.IsSuccessStatusCode) 
        {
            return null;
        }
       
        WikiRateAnswerDto? dto = 
            await responseMessage.Content.ReadFromJsonAsync<WikiRateAnswerDto>();

        return dto;
    }
}
