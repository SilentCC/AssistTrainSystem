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
    [Migration("20180117135533_ttt")]
    partial class ttt
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

            modelBuilder.Entity("AssistTrainSystem.Models.ComtrainAbilities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<DateTime>("create_time");

                    b.Property<int>("gunhurdle_score");

                    b.Property<double>("gunhurdle_time");

                    b.Property<int>("threehurdle_score");

                    b.Property<double>("threehurdle_time");

                    b.Property<int>("threeoffroad_score");

                    b.Property<double>("threeoffroad_time");

                    b.Property<int>("twohurdle_score");

                    b.Property<double>("twohurdle_time");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("ComtrainAbilities");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.EnergyAbility", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<DateTime>("create_time");

                    b.Property<int>("doubara_num");

                    b.Property<int>("doubara_score");

                    b.Property<int>("doubarb_num");

                    b.Property<int>("doubarb_score");

                    b.Property<int>("horbara_num");

                    b.Property<int>("horbara_score");

                    b.Property<int>("horbarb_num");

                    b.Property<int>("horbarb_score");

                    b.Property<int>("pushup_num");

                    b.Property<int>("pushup_score");

                    b.Property<int>("score");

                    b.Property<int>("situp_num");

                    b.Property<int>("situp_score");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("EnergyAbility");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.FiveoffroadAbilities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<DateTime>("create_time");

                    b.Property<int>("fiveoffroad_score");

                    b.Property<double>("fiveoffroad_time");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("FiveoffroadAbilities");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.FlexibleAbility", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<DateTime>("create_time");

                    b.Property<double>("flexible_num");

                    b.Property<double>("flexible_score");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("FlexiableAbility");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.FourhurdleAbilities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<DateTime>("create_time");

                    b.Property<int>("fourhurdle_score");

                    b.Property<double>("fourhurdle_time");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("FourhurdleAbilities");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.Horbara_Score", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<int>("num");

                    b.Property<int>("score");

                    b.HasKey("ID");

                    b.ToTable("Horbara_Score");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.NormalTrain", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Leg_train");

                    b.Property<int>("abdomen_train");

                    b.Property<int>("arm_train");

                    b.Property<int>("back_train");

                    b.Property<int>("chesk_train");

                    b.Property<DateTime>("create_time");

                    b.Property<int>("explosive_train");

                    b.Property<int>("shoulder_train");

                    b.Property<int>("stamina_train");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("NormalTrain");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.PersonalNormlTrain", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Leg_train");

                    b.Property<int>("abdomen_train");

                    b.Property<int>("arm_train");

                    b.Property<int>("back_train");

                    b.Property<int>("chesk_train");

                    b.Property<int>("explosive_train");

                    b.Property<int>("shoulder_train");

                    b.Property<int>("stamina_train");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("PersonalNormlTrain");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.PersonalPay", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("all_income");

                    b.Property<double>("breakfirset_income");

                    b.Property<string>("breakfirst");

                    b.Property<DateTime>("create_time");

                    b.Property<string>("dinner");

                    b.Property<double>("dinner_income");

                    b.Property<string>("lunch");

                    b.Property<double>("lunch_income");

                    b.Property<double>("pay");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("PersonalPay");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.SpeedAbility", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Gunrun_score");

                    b.Property<double>("Gunrun_time");

                    b.Property<int>("Trun_score");

                    b.Property<double>("Trun_time");

                    b.Property<DateTime>("create_time");

                    b.Property<int>("score");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("SpeedAbility");
                });

            modelBuilder.Entity("AssistTrainSystem.Models.StaminaAbility", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<DateTime>("create_time");

                    b.Property<int>("fourrun_score");

                    b.Property<double>("fourrun_time");

                    b.Property<int>("score");

                    b.Property<int>("threerun_score");

                    b.Property<double>("threerun_time");

                    b.Property<string>("user_id");

                    b.HasKey("ID");

                    b.ToTable("StaminaAbility");
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
