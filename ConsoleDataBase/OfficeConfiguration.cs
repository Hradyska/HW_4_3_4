using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace ConsoleDataBase
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
                .ToTable("Office")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("OfficeId")
                .ValueGeneratedNever();
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.Location)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}