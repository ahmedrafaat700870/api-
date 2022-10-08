using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbReviewBage
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Like { get; set; }
        public int DisLike { get; set; }
        public string Src { get; set; } = null!;
        public DateTime CretaedDate { get; set; }
    }
}
