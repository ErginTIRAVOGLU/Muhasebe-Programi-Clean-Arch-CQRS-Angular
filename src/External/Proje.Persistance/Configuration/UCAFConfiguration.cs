using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Domain.CompanyEntities;
using Proje.Persistance.Constans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistance.Configuration
{
    public sealed class UCAFConfiguration : IEntityTypeConfiguration<UniformCartOfAccount>
    {
        public void Configure(EntityTypeBuilder<UniformCartOfAccount> builder)
        {
            builder.ToTable(TableNames.UniformCartOdAccounts);
            builder.HasKey(p => p.Id);
        }
    }
}
