using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbInetegram
    {
        public int InstagramId { get; set; }
        public string InstagramSrc { get; set; } = null!;
        public string PhotoSrc { get; set; } = null!;
    }
}
