using JobMatcher.Data.DAL;
using JobMatcher.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobMatcher.Test
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public void TestGetCandidates()
        {
            IRepository rep = new Repository();
            Task<List<Candidate>> candidates = rep.GetCandidates();
            Assert.IsTrue(candidates.Result.Count > 0);
        }

        [TestMethod]
        public void TestGetJobs()
        {
            IRepository rep = new Repository();
            Task<List<Job>> jobs = rep.GetJobs();
            Assert.IsTrue(jobs.Result.Count > 0);
        }
    }
}
