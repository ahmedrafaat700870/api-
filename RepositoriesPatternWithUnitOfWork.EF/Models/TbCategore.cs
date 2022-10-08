using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbCategore
    {
        public TbCategore()
        {
            TbTours = new HashSet<TbTour>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<TbTour> TbTours { get; set; }
    }
}
