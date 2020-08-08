using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class CommandsTypeMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.CommandsType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.CommandsType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("commands_type", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "commands_type";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        #endregion
    }
}