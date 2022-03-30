using Exercise6v2.Core.Contacts;
using Exercise6v2.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Exercise6v2.Core.Helpers;

namespace Exercise6v2.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _httpClient;

        public StudentService()
        {
            _httpClient = new HttpClient() { BaseAddress = new System.Uri("https://localhost:44308/api/") };
        }

        public async Task<IEnumerable<StudentDto>> GetStudentsAsync()
        {
            var items = new List<StudentDto>();
            HttpResponseMessage response = await _httpClient.GetAsync("students");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                items = await Json.ToObjectAsync<List<StudentDto>>(content);
            }
            return items;
        }
    }
}
