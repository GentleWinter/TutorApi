using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutor.Domain.Entities;

namespace Tutor.Infra.Mapper
{
    internal class TutorMapper : IEntityTypeConfiguration<TutorEntity>
    {
        public void Configure(EntityTypeBuilder<TutorEntity> builder)
        {
            builder
                .ToTable("TB_TUTOR")
                .HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(255).IsRequired();
            builder.Property(x => x.BirthDate).HasColumnName("BIRTH_DATE").IsRequired();
            builder.Property(x => x.Email).HasColumnName("EMAIL").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Document).HasColumnName("DOCUMENT").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Password).HasColumnName("PASSWORD").HasMaxLength(255).IsRequired();
        }
    }
}
