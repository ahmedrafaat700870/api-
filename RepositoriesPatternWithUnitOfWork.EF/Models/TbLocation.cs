using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbLocation
    {
        public TbLocation()
        {
            TbTours = new HashSet<TbTour>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; } = null!;

        public virtual ICollection<TbTour> TbTours { get; set; }
    }
}
