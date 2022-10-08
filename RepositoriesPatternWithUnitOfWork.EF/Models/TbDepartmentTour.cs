using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbDepartmentTour
    {
        public int DepartmentTourId { get; set; }
        public int DepartmentId { get; set; }
        public int TourId { get; set; }

        public virtual DepartmentModel Department { get; set; } = null!;
        public virtual TbTour Tour { get; set; } = null!;
    }
}
