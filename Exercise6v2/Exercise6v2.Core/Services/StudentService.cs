using Exercise6v2.Core.Contacts;
using Exercise6v2.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Exercise6v2.Core.Helpers;

namespace Exercise6v2.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _httpClient;
        HttpClientHandler clientHandler;
        public StudentService()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            _httpClient = new HttpClient(clientHandler) { BaseAddress = new Uri("https://localhost:44308/api/") };
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

        public async Task<StudentDto> CreateStudentAsync(StudentDto student)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync($"students", student);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<StudentDto>();
        }

        public async Task<bool> DeleteStudentAsync(StudentDto student)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"students/{student.StudentId}");
            return response.IsSuccessStatusCode;
        }
    }
}
