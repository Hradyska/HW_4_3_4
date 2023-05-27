using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ConsoleDataBase
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
                .ToTable("EmployeeProject")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeProjectId")
                .ValueGeneratedNever();
            builder.Property(p => p.Rate)
               .HasColumnType("money");
        }
    }
}
