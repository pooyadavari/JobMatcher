using System;
using System.Collections.Generic;
using System.Linq;

namespace JobMatcher.Data.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string SkillTags { get; set; }

        public List<string> skillTagsList
        {
            get
            {               
                return Array.ConvertAll(SkillTags.Split(','), p => p.Trim()).ToList();
            }
        }
    }
}
