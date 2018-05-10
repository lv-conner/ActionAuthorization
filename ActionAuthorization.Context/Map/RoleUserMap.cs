using ActionAuthorization.Models.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Context.Map
{
    class RoleUserMap : IEntityTypeConfiguration<RoleUser>
    {
        public void Configure(EntityTypeBuilder<RoleUser> builder)
        {
            builder.HasKey(p => p.RoleUserId);
            builder.Property(p => p.RoleUserId).HasMaxLength(50);
        }
    }
}
