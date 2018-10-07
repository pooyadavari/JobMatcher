using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobMatcher.Data.DAL;
using JobMatcher.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobMatcher.Controllers
{
    [Produces("application/json")]
    [Route("api/candidatesjobs")]
    public class CandidateJobController : Controller
    {
        readonly Business.ICandidateJobMatcher candidateJobMatcher;

        public CandidateJobController(Business.ICandidateJobMatcher _candidateJobMatcher)
        {
            this.candidateJobMatcher = _candidateJobMatcher;
        }

        // GET: api/candidatesjobs
        [HttpGet]
        public ActionResult Get()
        {
            List<CandidateJob> candidatesJobs = candidateJobMatcher.GetCandidateJobs();
            return Ok(candidatesJobs);
        }        
    }
}
