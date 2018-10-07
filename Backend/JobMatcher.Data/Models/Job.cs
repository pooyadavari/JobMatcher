
using System;
using System.Collections.Generic;
using System.Linq;

namespace JobMatcher.Data.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Skills { get; set; }

        public List<string> skillsList
        {
            get
            {
                return Array.ConvertAll(Skills.Split(','), p => p.Trim()).ToList();
            }
        }
    }
}
