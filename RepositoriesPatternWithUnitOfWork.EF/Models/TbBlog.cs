using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbBlog
    {
        public TbBlog()
        {
            TbBlogDescriptoinPhotos = new HashSet<TbBlogDescriptoinPhoto>();
            TbReviews = new HashSet<TbReview>();
        }

        public int BlogId { get; set; }
        public string BlogTitel { get; set; } = null!;
        public DateTime BlogCreatedDate { get; set; }
        public string BlogCreatedBy { get; set; } = null!;

        public virtual ICollection<TbBlogDescriptoinPhoto> TbBlogDescriptoinPhotos { get; set; }
        public virtual ICollection<TbReview> TbReviews { get; set; }
    }
}
