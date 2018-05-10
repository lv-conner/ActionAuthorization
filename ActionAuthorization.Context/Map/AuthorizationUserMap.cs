using ActionAuthorization.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Context.Map
{
    class AuthorizationUserMap : IEntityTypeConfiguration<AuthorizationUser>
    {
        public void Configure(EntityTypeBuilder<AuthorizationUser> builder)
        {
            builder.HasKey(p => p.UserId);
            builder.Property(p => p.UserId).HasMaxLength(50);
            builder.Property(p => p.UserName).HasMaxLength(50);
            builder.Property(p => p.Password).HasMaxLength(500);
            builder.Property(p => p.PhoneNumber).HasMaxLength(20);
            builder.Property(p => p.Email).HasMaxLength(100);
        }
    }
}
