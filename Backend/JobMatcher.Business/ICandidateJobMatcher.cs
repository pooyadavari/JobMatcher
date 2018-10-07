using JobMatcher.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMatcher.Business
{
    public interface ICandidateJobMatcher
    {
        List<CandidateJob> GetCandidateJobs();
    }
}
