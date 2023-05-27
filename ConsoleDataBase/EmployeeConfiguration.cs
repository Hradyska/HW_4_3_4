using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ConsoleDataBase
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("Employee")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeId")
                .ValueGeneratedNever();
            builder
                .Property(p => p.DateOfBirth)
                .HasColumnType("date")
                .IsRequired(false);
            builder.Property(p => p.FirstName)
               .IsRequired()
               .HasMaxLength(50);
            builder.Property(p => p.LastName)
               .IsRequired()
               .HasMaxLength(50);
        }
    }
}
