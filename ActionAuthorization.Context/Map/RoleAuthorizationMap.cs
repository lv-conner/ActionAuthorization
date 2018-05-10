using ActionAuthorization.Models.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Context.Map
{
    class RoleAuthorizationMap : IEntityTypeConfiguration<RoleAuthorization>
    {
        public void Configure(EntityTypeBuilder<RoleAuthorization> builder)
        {
            builder.HasKey(p => p.RoleAuthorizationId);
            builder.Property(p => p.RoleId).HasMaxLength(50);
        }
    }
}
