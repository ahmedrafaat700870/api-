using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbFaq
    {
        public int Id { get; set; }
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
    }
}
