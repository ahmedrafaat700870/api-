using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbTeamMember
    {
        public int TeamMeberId { get; set; }
        public string TeamMeberName { get; set; } = null!;
        public string TeamMemberPhoto { get; set; } = null!;
        public string TeamMebmerJob { get; set; } = null!;
        public string TeamMemberJobDescription { get; set; } = null!;
        public bool IsAdmin { get; set; }
    }
}
