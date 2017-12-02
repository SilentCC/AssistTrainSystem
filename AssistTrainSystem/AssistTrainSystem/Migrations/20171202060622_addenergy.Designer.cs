﻿// <auto-generated />
using AssistTrainSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AssistTrainSystem.Migrations
{
    [DbContext(typeof(SystemContext))]
    [Migration("20171202060622_addenergy")]
    partial class addenergy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssistTrainSystem.Models.BodyAbility", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<double>("bfp");

                    b.Property<double>("bmi");

                    b.Property<DateTime>("create_time");

                    b.Property<double>("height");

                    b.Property<string>("user_id");

                    b.Property<double>("waist");

                    b.Property<double>("weight");

                    b.HasKey("ID");

                    b.ToTable("BodyAbility");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.User", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.HasKey("ID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
