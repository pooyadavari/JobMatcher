using JobMatcher.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobMatcher.Data.DAL
{
    public interface IRepository
    {        
        Task<List<Job>> GetJobs();
        Task<List<Candidate>> GetCandidates();        
    }
}
