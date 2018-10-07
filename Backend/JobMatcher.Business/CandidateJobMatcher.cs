using JobMatcher.Data.DAL;
using JobMatcher.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMatcher.Business
{
    public class CandidateJobMatcher : ICandidateJobMatcher
    {
        readonly IRepository repository;

        public CandidateJobMatcher(IRepository _repository)
        {
            this.repository = _repository;
        }

        public List<CandidateJob> GetCandidateJobs()
        {
            List<Candidate> candidates = repository.GetCandidates().Result;
            List<Job> jobs = repository.GetJobs().Result;
            List<CandidateJob> candidateJobs = new List<CandidateJob>();

            candidates.ForEach(c =>
            {
                candidateJobs.Add(new CandidateJob
                {
                    Candidate = c,
                    Job = jobs[0]
                });
            });

            return candidateJobs;
        }
    }
}
