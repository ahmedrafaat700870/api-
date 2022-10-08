using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbInfoTeamPage
    {
        public int InfoId { get; set; }
        public string Description { get; set; } = null!;
        public string PageTitel { get; set; } = null!;
        public string PagePhoto { get; set; } = null!;
    }
}
