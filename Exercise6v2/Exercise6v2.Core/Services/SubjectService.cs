using Exercise6v2.Core.Contacts;
using Exercise6v2.Core.Dtos;
using Exercise6v2.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6v2.Core.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly HttpClient _httpClient;
        HttpClientHandler clientHandler;
        public SubjectService()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            _httpClient = new HttpClient(clientHandler) { BaseAddress = new Uri("https://localhost:44308/api/") };
        }

        public async Task<IEnumerable<SubjectDto>> GetSubjectsAsync()
        {
            var items = new List<SubjectDto>();
            HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:44308/api/subjects");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                items = await Json.ToObjectAsync<List<SubjectDto>>(content);
            }
            return items;
        }
    }
}
