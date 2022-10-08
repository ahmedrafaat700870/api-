using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbTour
    {
        public TbTour()
        {
            TbDepartmentTours = new HashSet<TbDepartmentTour>();
            TbInvoices = new HashSet<TbInvoice>();
            TbPhotos = new HashSet<TbPhoto>();
            TbReviews = new HashSet<TbReview>();
            TbTourOptions = new HashSet<TbTourOption>();
        }

        public int TourId { get; set; }
        public bool IsNew { get; set; }
        public decimal? Sale { get; set; }
        public string Description { get; set; } = null!;
        public decimal TourPrice { get; set; }
        public string TourTitel { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public string? VideoSrc { get; set; }
        public int CategoryId { get; set; }
        public int LocationId { get; set; }
        public int? LocationHomePageId { get; set; }

        public virtual TbCategore Category { get; set; } = null!;
        public virtual TbLocation Location { get; set; } = null!;
        public virtual TbLocationHomePage? LocationHomePage { get; set; }
        public virtual ICollection<TbDepartmentTour> TbDepartmentTours { get; set; }
        public virtual ICollection<TbInvoice> TbInvoices { get; set; }
        public virtual ICollection<TbPhoto> TbPhotos { get; set; }
        public virtual ICollection<TbReview> TbReviews { get; set; }
        public virtual ICollection<TbTourOption> TbTourOptions { get; set; }
    }
}
