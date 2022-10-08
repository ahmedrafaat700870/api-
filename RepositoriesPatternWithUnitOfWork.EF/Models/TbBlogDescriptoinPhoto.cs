using System;
using System.Collections.Generic;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class TbBlogDescriptoinPhoto
    {
        public int BlogPhotoId { get; set; }
        public string BlogPhotoSrc { get; set; } = null!;
        public string BlogDescription { get; set; } = null!;
        public int BlogId { get; set; }

        public virtual TbBlog Blog { get; set; } = null!;
    }
}
