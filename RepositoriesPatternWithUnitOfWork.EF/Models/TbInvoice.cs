using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbInvoice
    {
        public int InvoiceId { get; set; }
        public decimal Price { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public int TbCustomerUsersId { get; set; }
        public int TourId { get; set; }

        public virtual TbCustomer TbCustomerUsers { get; set; } = null!;
        public virtual TbTour Tour { get; set; } = null!;
    }
}
