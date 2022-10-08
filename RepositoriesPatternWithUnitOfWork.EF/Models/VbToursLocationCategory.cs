using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class VbToursLocationCategory
    {
        public int TourId { get; set; }
        public bool IsNew { get; set; }
        public decimal? Sale { get; set; }
        public decimal TourPrice { get; set; }
        public string TourTitel { get; set; } = null!;
        public int LocationId { get; set; }
        public int CategoryId { get; set; }
        public string LocationName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
    }
}
