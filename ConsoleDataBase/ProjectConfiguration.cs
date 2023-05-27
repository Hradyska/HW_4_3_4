using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ConsoleDataBase
{
   public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .ToTable("Project")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("ProjectId")
                .ValueGeneratedNever();
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Budget)
                .HasColumnType("money");
        }
    }
}
