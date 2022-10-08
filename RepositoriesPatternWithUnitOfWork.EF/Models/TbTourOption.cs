using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbTourOption
    {
        public TbTourOption()
        {
            TbOptionNeededs = new HashSet<TbOptionNeeded>();
            TbbOptionIncludeds = new HashSet<TbbOptionIncluded>();
        }

        public int TourOptionId { get; set; }
        public int MaxPeople { get; set; }
        public int MinPeople { get; set; }
        public decimal Price { get; set; }
        public int MinAge { get; set; }
        public DateTime StartDate { get; set; }
        public string OptionDescription { get; set; } = null!;
        public DateTime EndDate { get; set; }
        public int Rate { get; set; }
        public int DayCount { get; set; }
        public int HourCount { get; set; }
        public bool IsSelected { get; set; }
        public int TourId { get; set; }

        public virtual TbTour Tour { get; set; } = null!;
        public virtual ICollection<TbOptionNeeded> TbOptionNeededs { get; set; }
        public virtual ICollection<TbbOptionIncluded> TbbOptionIncludeds { get; set; }
    }
}
