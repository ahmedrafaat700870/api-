using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class DepartmentModel
    {
        public DepartmentModel()
        {
            TbDepartmentTours = new HashSet<TbDepartmentTour>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;

        public virtual ICollection<TbDepartmentTour> TbDepartmentTours { get; set; }
    }
}
