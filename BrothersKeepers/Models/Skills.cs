using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrothersKeepers.Models
{
    public class Skills
    {
        public int SkillsId { get; set; }
        public string SkillsName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}