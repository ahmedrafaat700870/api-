using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbHomePageImage
    {
        public int HomePageImageId { get; set; }
        public string MainImage { get; set; } = null!;
        public string SubImage1 { get; set; } = null!;
        public string? SubImage2 { get; set; }
    }
}
