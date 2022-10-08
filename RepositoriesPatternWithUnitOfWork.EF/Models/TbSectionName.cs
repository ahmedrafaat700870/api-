using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbSectionName
    {
        public int Id { get; set; }
        public string PopuarSeaction { get; set; } = null!;
        public string SeaSection { get; set; } = null!;
        public string InstegramSeaction { get; set; } = null!;
        public string BlogSeaction { get; set; } = null!;
    }
}
