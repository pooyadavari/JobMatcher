using JobMatcher.Data.DAL;
using JobMatcher.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<CandidateJob> GetCandidatesJobs()
        {
            List<Candidate> candidates = repository.GetCandidates().Result;
            List<Job> jobs = repository.GetJobs().Result;
            List<CandidateJob> candidatesJobs = new List<CandidateJob>();
            Candidate candidate = null;

            jobs.ForEach(j =>
            {
                candidate = candidates.OrderByDescending(c => c.SkillTagsList.Intersect(j.SkillsList).Count())
                          .First();

                candidatesJobs.Add(new CandidateJob
                {
                    JobName = j.Name,
                    JobCompany = j.Company,
                    JobSkills = j.Skills,

                    CandidateName = candidate.Name,
                    CandidateSkillTags = candidate.SkillTags
                });
            });

            return candidatesJobs;
        }
    }
}
