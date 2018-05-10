using ActionAuthorization.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Context.Map
{
    class AuthorizationRoleMap : IEntityTypeConfiguration<AuthorizationRole>
    {
        public void Configure(EntityTypeBuilder<AuthorizationRole> builder)
        {
            builder.HasKey(p => p.RoleId);
            builder.Property(p => p.RoleName).HasMaxLength(50);
            builder.Property(p => p.RoleId).HasMaxLength(50);
        }
    }
}
