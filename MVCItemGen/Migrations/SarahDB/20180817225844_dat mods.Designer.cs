﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MVCItemGen.Model;
using System;

namespace MVCItemGen.Migrations.SarahDB
{
    [DbContext(typeof(SarahDBContext))]
    [Migration("20180817225844_dat mods")]
    partial class datmods
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCItemGen.Model.SarahsItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime?>("DateCompleted");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("TypeOfItem");

                    b.HasKey("Id");

                    b.ToTable("SarahsItems");
                });
#pragma warning restore 612, 618
        }
    }
}
