using JobMatcher.Business;
using JobMatcher.Data.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMatcher.Test
{
    [TestClass]
    public class CandidateJobMatcherTests
    {
        [TestMethod]
        public void TestGetCandidates()
        {
            IRepository rep = new Repository();
            ICandidateJobMatcher candidateJobMatcher = new CandidateJobMatcher(rep);

            Assert.IsTrue(candidateJobMatcher.GetCandidatesJobs().Count > 0);
        }
    }
}
