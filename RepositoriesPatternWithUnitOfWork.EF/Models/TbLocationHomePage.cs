using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbLocationHomePage
    {
        public TbLocationHomePage()
        {
            TbTours = new HashSet<TbTour>();
        }

        public int LocationHomePageId { get; set; }
        public string LocationName { get; set; } = null!;

        public virtual ICollection<TbTour> TbTours { get; set; }
    }
}
