using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbPhoto
    {
        public int PhotoId { get; set; }
        public string PhotoSrc { get; set; } = null!;
        public int TourId { get; set; }

        public virtual TbTour Tour { get; set; } = null!;
    }
}
