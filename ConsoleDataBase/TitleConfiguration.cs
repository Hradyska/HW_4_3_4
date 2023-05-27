using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ConsoleDataBase
{
    internal class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
                .ToTable("Title")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("TitleId")
                .ValueGeneratedNever();
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}