using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbConcat
    {
        public int Id { get; set; }
        public string FirsName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
