using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbReview
    {
        public int ReviewId { get; set; }
        public string Name { get; set; } = null!;
        public string ReviewDescription { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime ReviewDate { get; set; }
        public int? TourId { get; set; }
        public int? CustomerId { get; set; }
        public int TbCustomerUsersId { get; set; }
        public int? BlogId { get; set; }

        public virtual TbBlog? Blog { get; set; }
        public virtual TbCustomer TbCustomerUsers { get; set; } = null!;
        public virtual TbTour? Tour { get; set; }
    }
}
