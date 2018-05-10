using ActionAuthorization.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Context.Map
{
    internal class AuthorizationModelMap : IEntityTypeConfiguration<AuthorizationModel>
    {
        public void Configure(EntityTypeBuilder<AuthorizationModel> builder)
        {
            builder.HasKey(p => p.AuthorizationModelId);
            builder.Property(p => p.AuthorizationModelId).HasMaxLength(50);
            builder.Property(p => p.SystemName).HasMaxLength(50);
            builder.Property(p => p.SystemNo).HasMaxLength(50);
            builder.Property(p => p.ModuleName).HasMaxLength(50);
            builder.Property(p => p.ModuleNo).HasMaxLength(50);
            builder.Property(p => p.ActionName).HasMaxLength(50);
            builder.Property(p => p.ActionNo).HasMaxLength(50);
        }
    }
}
