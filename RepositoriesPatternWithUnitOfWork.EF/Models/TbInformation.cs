using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbInformation
    {
        public int InformationId { get; set; }
        public string InformationPhone { get; set; } = null!;
        public string InformationEmail { get; set; } = null!;
        public string FaceBookAccount { get; set; } = null!;
        public string TwitterAcount { get; set; } = null!;
        public string InstagramAccount { get; set; } = null!;
        public string WebSiteName { get; set; } = null!;
        public string DescriptionInfo { get; set; } = null!;
        public string LogoImage { get; set; } = null!;
        public string FooterDescription { get; set; } = null!;
        public string FooterImage { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string? Facx { get; set; }
    }
}
