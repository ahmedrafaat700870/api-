using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbCustomer
    {
        public TbCustomer()
        {
            TbInvoices = new HashSet<TbInvoice>();
            TbReviews = new HashSet<TbReview>();
        }

        public int UsersId { get; set; }
        public bool IsAdmin { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public virtual ICollection<TbInvoice> TbInvoices { get; set; }
        public virtual ICollection<TbReview> TbReviews { get; set; }
    }
}
