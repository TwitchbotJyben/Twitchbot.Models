using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Mapping
{
    public partial class ActionsMap
        : IEntityTypeConfiguration<Twitchbot.Common.Models.Data.Entities.Actions>
        {
            public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Common.Models.Data.Entities.Actions> builder)
            {
                #region Generated Configure
            // table
            builder.ToTable("actions", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            // relationships
            #endregion
            }

            #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "actions";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Name = "name";
        }
        #endregion
        }
}