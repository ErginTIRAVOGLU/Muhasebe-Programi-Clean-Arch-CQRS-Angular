using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Domain.CompanyEntities;
using Proje.Persistance.Constans;

namespace Proje.Persistance.Configuration
{
    public sealed class UCAFConfiguration : IEntityTypeConfiguration<UniformCartOfAccount>
    {
        public void Configure(EntityTypeBuilder<UniformCartOfAccount> builder)
        {
            builder.ToTable(TableNames.UniformCartOfAccounts);
            builder.HasKey(p => p.Id);
        }
    }
}
