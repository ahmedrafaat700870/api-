using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbbOptionIncluded
    {
        public int IncludedId { get; set; }
        public string IncludedName { get; set; } = null!;
        public bool IsIncluded { get; set; }
        public int OptionId { get; set; }

        public virtual TbTourOption Option { get; set; } = null!;
    }
}
