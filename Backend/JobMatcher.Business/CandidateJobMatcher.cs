using JobMatcher.Data.DAL;
using JobMatcher.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMatcher.Business
{
    public class CandidateJobMatcher
    {
        readonly IRepository rep;

        public CandidateJobMatcher(IRepository repository)
        {
            this.rep = repository;
        }

        public List<CandidateJob> GetCandidateJobs()
        {
            List<Candidate> candidates = rep.GetCandidates().Result;
            List<Job> jobs = rep.GetJobs().Result;
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
