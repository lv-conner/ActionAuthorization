using ActionAuthorization.Models.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Context.Map
{
    class UserAuthorizationMap : IEntityTypeConfiguration<UserAuthorization>
    {
        public void Configure(EntityTypeBuilder<UserAuthorization> builder)
        {
            builder.HasKey(p => p.AuthorizationId);
            builder.Property(p => p.AuthorizationId).HasMaxLength(50);
        }
    }
}
