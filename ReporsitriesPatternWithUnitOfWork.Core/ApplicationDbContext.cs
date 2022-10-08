using Microsoft.EntityFrameworkCore;

namespace RepositoriesPatternWithUnitOfWork.EF.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DepartmentModel> DepartmentModels { get; set; } = null!;
        public virtual DbSet<TbBlog> TbBlogs { get; set; } = null!;
        public virtual DbSet<TbBlogDescriptoinPhoto> TbBlogDescriptoinPhotos { get; set; } = null!;
        public virtual DbSet<TbCategore> TbCategores { get; set; } = null!;
        public virtual DbSet<TbConcat> TbConcats { get; set; } = null!;
        public virtual DbSet<TbCustomer> TbCustomers { get; set; } = null!;
        public virtual DbSet<TbDepartmentTour> TbDepartmentTours { get; set; } = null!;
        public virtual DbSet<TbFaq> TbFaqs { get; set; } = null!;
        public virtual DbSet<TbHomePageImage> TbHomePageImages { get; set; } = null!;
        public virtual DbSet<TbInetegram> TbInetegrams { get; set; } = null!;
        public virtual DbSet<TbInfoTeamPage> TbInfoTeamPages { get; set; } = null!;
        public virtual DbSet<TbInformation> TbInformations { get; set; } = null!;
        public virtual DbSet<TbInvoice> TbInvoices { get; set; } = null!;
        public virtual DbSet<TbLocation> TbLocations { get; set; } = null!;
        public virtual DbSet<TbLocationHomePage> TbLocationHomePages { get; set; } = null!;
        public virtual DbSet<TbOptionNeeded> TbOptionNeededs { get; set; } = null!;
        public virtual DbSet<TbPhoto> TbPhotos { get; set; } = null!;
        public virtual DbSet<TbReview> TbReviews { get; set; } = null!;
        public virtual DbSet<TbReviewBage> TbReviewBages { get; set; } = null!;
        public virtual DbSet<TbSectionName> TbSectionNames { get; set; } = null!;
        public virtual DbSet<TbTeamMember> TbTeamMembers { get; set; } = null!;
        public virtual DbSet<TbTour> TbTours { get; set; } = null!;
        public virtual DbSet<TbTourOption> TbTourOptions { get; set; } = null!;
        public virtual DbSet<TbbOptionIncluded> TbbOptionIncludeds { get; set; } = null!;
        public virtual DbSet<VbToursLocationCategory> VbToursLocationCategories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentModel>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.Property(e => e.DepartmentName).HasMaxLength(250);
            });

            modelBuilder.Entity<TbBlog>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.ToTable("TbBlog");

                entity.Property(e => e.BlogCreatedBy).HasMaxLength(250);

                entity.Property(e => e.BlogCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.BlogTitel).HasMaxLength(250);
            });

            modelBuilder.Entity<TbBlogDescriptoinPhoto>(entity =>
            {
                entity.HasKey(e => e.BlogPhotoId);

                entity.ToTable("TbBlogDescriptoinPhoto");

                entity.HasIndex(e => e.BlogId, "IX_TbBlogDescriptoinPhoto_BlogId");

                entity.Property(e => e.BlogDescription).IsUnicode(false);

                entity.Property(e => e.BlogPhotoSrc).HasMaxLength(250);

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.TbBlogDescriptoinPhotos)
                    .HasForeignKey(d => d.BlogId);
            });

            modelBuilder.Entity<TbCategore>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryName).HasMaxLength(250);
            });

            modelBuilder.Entity<TbConcat>(entity =>
            {
                entity.ToTable("TbConcat");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.FirsName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.Message).HasMaxLength(250);

                entity.Property(e => e.PhoneNumber).HasMaxLength(250);
            });

            modelBuilder.Entity<TbCustomer>(entity =>
            {
                entity.HasKey(e => e.UsersId);

                entity.ToTable("TbCustomer");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.PhoneNumber).HasMaxLength(250);
            });

            modelBuilder.Entity<TbDepartmentTour>(entity =>
            {
                entity.HasKey(e => e.DepartmentTourId);

                entity.ToTable("TbDepartmentTour");

                entity.HasIndex(e => e.DepartmentId, "IX_TbDepartmentTour_DepartmentId");

                entity.HasIndex(e => e.TourId, "IX_TbDepartmentTour_TourId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TbDepartmentTours)
                    .HasForeignKey(d => d.DepartmentId);

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TbDepartmentTours)
                    .HasForeignKey(d => d.TourId);
            });

            modelBuilder.Entity<TbFaq>(entity =>
            {
                entity.ToTable("TbFAQ");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer).IsUnicode(false);

                entity.Property(e => e.Question)
                    .IsUnicode(false)
                    .HasColumnName("question");
            });

            modelBuilder.Entity<TbHomePageImage>(entity =>
            {
                entity.HasKey(e => e.HomePageImageId);

                entity.HasIndex(e => e.MainImage, "IX_TbHomePageImages_MainImage")
                    .IsUnique();

                entity.HasIndex(e => e.SubImage1, "IX_TbHomePageImages_SubImage1")
                    .IsUnique();

                entity.Property(e => e.MainImage).HasMaxLength(250);

                entity.Property(e => e.SubImage1).HasMaxLength(250);

                entity.Property(e => e.SubImage2).HasMaxLength(250);
            });

            modelBuilder.Entity<TbInetegram>(entity =>
            {
                entity.HasKey(e => e.InstagramId);

                entity.ToTable("TbInetegram");

                entity.Property(e => e.InstagramSrc).IsUnicode(false);

                entity.Property(e => e.PhotoSrc).IsUnicode(false);
            });

            modelBuilder.Entity<TbInfoTeamPage>(entity =>
            {
                entity.HasKey(e => e.InfoId);

                entity.ToTable("TbInfoTeamPage");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.PagePhoto).HasMaxLength(250);

                entity.Property(e => e.PageTitel).HasMaxLength(250);
            });

            modelBuilder.Entity<TbInformation>(entity =>
            {
                entity.HasKey(e => e.InformationId);

                entity.ToTable("TbInformation");

                entity.Property(e => e.DescriptionInfo).IsUnicode(false);

                entity.Property(e => e.FaceBookAccount).IsUnicode(false);

                entity.Property(e => e.Facx).HasMaxLength(250);

                entity.Property(e => e.FooterDescription).IsUnicode(false);

                entity.Property(e => e.FooterImage).HasMaxLength(250);

                entity.Property(e => e.InformationEmail).IsUnicode(false);

                entity.Property(e => e.InformationPhone).HasMaxLength(250);

                entity.Property(e => e.InstagramAccount).IsUnicode(false);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.LogoImage).HasMaxLength(250);

                entity.Property(e => e.TwitterAcount).IsUnicode(false);

                entity.Property(e => e.WebSiteName).HasMaxLength(250);
            });

            modelBuilder.Entity<TbInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("TbInvoice");

                entity.HasIndex(e => e.TbCustomerUsersId, "IX_TbInvoice_TbCustomerUsersId");

                entity.HasIndex(e => e.TourId, "IX_TbInvoice_TourId");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.TbCustomerUsers)
                    .WithMany(p => p.TbInvoices)
                    .HasForeignKey(d => d.TbCustomerUsersId);

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TbInvoices)
                    .HasForeignKey(d => d.TourId);
            });

            modelBuilder.Entity<TbLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("TbLocation");

                entity.Property(e => e.LocationName).HasMaxLength(250);
            });

            modelBuilder.Entity<TbLocationHomePage>(entity =>
            {
                entity.HasKey(e => e.LocationHomePageId);

                entity.ToTable("TbLocationHomePage");

                entity.Property(e => e.LocationName).HasMaxLength(250);
            });

            modelBuilder.Entity<TbOptionNeeded>(entity =>
            {
                entity.HasKey(e => e.NeedId);

                entity.ToTable("TbOptionNeeded");

                entity.HasIndex(e => e.OptionId, "IX_TbOptionNeeded_OptionId");

                entity.Property(e => e.TourNeededName)
                    .HasMaxLength(250)
                    .HasColumnName("tourNeededName");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.TbOptionNeededs)
                    .HasForeignKey(d => d.OptionId);
            });

            modelBuilder.Entity<TbPhoto>(entity =>
            {
                entity.HasKey(e => e.PhotoId);

                entity.HasIndex(e => e.TourId, "IX_TbPhotos_TourId");

                entity.Property(e => e.PhotoSrc).HasMaxLength(250);

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TbPhotos)
                    .HasForeignKey(d => d.TourId);
            });

            modelBuilder.Entity<TbReview>(entity =>
            {
                entity.HasKey(e => e.ReviewId);

                entity.HasIndex(e => e.BlogId, "IX_TbReviews_BlogId");

                entity.HasIndex(e => e.TbCustomerUsersId, "IX_TbReviews_TbCustomerUsersId");

                entity.HasIndex(e => e.TourId, "IX_TbReviews_TourId");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.ReviewDescription).IsUnicode(false);

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.TbReviews)
                    .HasForeignKey(d => d.BlogId);

                entity.HasOne(d => d.TbCustomerUsers)
                    .WithMany(p => p.TbReviews)
                    .HasForeignKey(d => d.TbCustomerUsersId);

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TbReviews)
                    .HasForeignKey(d => d.TourId);
            });

            modelBuilder.Entity<TbReviewBage>(entity =>
            {
                entity.ToTable("TbReviewBage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CretaedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DisLike).HasColumnName("disLike");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.Src)
                    .HasMaxLength(250)
                    .HasColumnName("src");
            });

            modelBuilder.Entity<TbSectionName>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BlogSeaction).HasMaxLength(250);

                entity.Property(e => e.InstegramSeaction).HasMaxLength(250);

                entity.Property(e => e.PopuarSeaction).HasMaxLength(250);

                entity.Property(e => e.SeaSection).HasMaxLength(250);
            });

            modelBuilder.Entity<TbTeamMember>(entity =>
            {
                entity.HasKey(e => e.TeamMeberId);

                entity.ToTable("TbTeamMember");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.TeamMeberName).HasMaxLength(250);

                entity.Property(e => e.TeamMebmerJob).HasMaxLength(250);

                entity.Property(e => e.TeamMemberJobDescription).IsUnicode(false);

                entity.Property(e => e.TeamMemberPhoto).HasMaxLength(250);
            });

            modelBuilder.Entity<TbTour>(entity =>
            {
                entity.HasKey(e => e.TourId);

                entity.HasIndex(e => e.CategoryId, "IX_TbTours_CategoryId");

                entity.HasIndex(e => e.LocationHomePageId, "IX_TbTours_LocationHomePageId");

                entity.HasIndex(e => e.LocationId, "IX_TbTours_LocationId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsNew).HasColumnName("isNew");

                entity.Property(e => e.Sale).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TourPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TourTitel).HasMaxLength(250);

                entity.Property(e => e.VideoSrc).IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbTours)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.LocationHomePage)
                    .WithMany(p => p.TbTours)
                    .HasForeignKey(d => d.LocationHomePageId);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.TbTours)
                    .HasForeignKey(d => d.LocationId);
            });

            modelBuilder.Entity<TbTourOption>(entity =>
            {
                entity.HasKey(e => e.TourOptionId);

                entity.ToTable("TbTourOption");

                entity.HasIndex(e => e.TourId, "IX_TbTourOption_TourId");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsSelected).HasColumnName("isSelected");

                entity.Property(e => e.OptionDescription).IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TbTourOptions)
                    .HasForeignKey(d => d.TourId);
            });

            modelBuilder.Entity<TbbOptionIncluded>(entity =>
            {
                entity.HasKey(e => e.IncludedId);

                entity.ToTable("TbbOptionIncluded");

                entity.HasIndex(e => e.OptionId, "IX_TbbOptionIncluded_OptionId");

                entity.Property(e => e.IncludedName).HasMaxLength(250);

                entity.Property(e => e.IsIncluded).HasColumnName("isIncluded");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.TbbOptionIncludeds)
                    .HasForeignKey(d => d.OptionId);
            });

            modelBuilder.Entity<VbToursLocationCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VbToursLocationCategory");

                entity.Property(e => e.CategoryName).HasMaxLength(250);

                entity.Property(e => e.IsNew).HasColumnName("isNew");

                entity.Property(e => e.LocationName).HasMaxLength(250);

                entity.Property(e => e.Sale).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TourPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TourTitel).HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
