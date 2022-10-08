using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbOptionNeeded
    {
        public int NeedId { get; set; }
        public string TourNeededName { get; set; } = null!;
        public int OptionId { get; set; }

        public virtual TbTourOption Option { get; set; } = null!;
    }
}
