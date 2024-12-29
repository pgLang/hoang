using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ThuVienOnline.Models
{
    public partial class ThuVienOnLineContext : DbContext
    {
        public ThuVienOnLineContext()
        {
        }

        public ThuVienOnLineContext(DbContextOptions<ThuVienOnLineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DUNGCOOL\\SQLEXPRESS;Database=ThuVienOnLine;Integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Anh).IsRequired();

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Mota).IsRequired();

                entity.Property(e => e.NgayPh)
                    .HasColumnType("date")
                    .HasColumnName("NgayPH");

                entity.Property(e => e.TacGia)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TheLoai)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__NguoiDun__1788CCACAAD96A69");

                entity.ToTable("NguoiDung");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Diachi).HasMaxLength(500);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
