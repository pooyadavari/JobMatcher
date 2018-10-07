using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JobMatcher.Data.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JobMatcher.Data.DAL
{
    public class Repository : IRepository
    {
        HttpClient client = new HttpClient();

        public Repository()
        {
            client.BaseAddress = new Uri("http://private-76432-jobadder1.apiary-mock.com/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Job>> GetJobs()
        {
            HttpResponseMessage response = await client.GetAsync("jobs");
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Job>>(stringResult);
            }
            return new List<Job>();
        }

        public async Task<List<Candidate>> GetCandidates()
        {            
            HttpResponseMessage response = await client.GetAsync("candidates");
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Candidate>>(stringResult);
            }
            return new List<Candidate>();
        }
    }
}
