﻿// <auto-generated />
using System;
using System.Reflection;
using IATechamp.Models;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace ProductService.Infrastructure
{
    internal partial class ScoreboardModelEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "IATechamp.Models.ScoreboardModel",
                typeof(ScoreboardModel),
                baseEntityType,
                discriminatorProperty: "Discriminator");

            var gamePlayed = runtimeEntityType.AddProperty(
                "GamePlayed",
                typeof(int),
                propertyInfo: typeof(ScoreboardModel).GetProperty("GamePlayed", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ScoreboardModel).GetField("<GamePlayed>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            gamePlayed.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var gamePoints = runtimeEntityType.AddProperty(
                "GamePoints",
                typeof(int),
                propertyInfo: typeof(ScoreboardModel).GetProperty("GamePoints", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ScoreboardModel).GetField("<GamePoints>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            gamePoints.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var idScoreboard = runtimeEntityType.AddProperty(
                "IdScoreboard",
                typeof(int),
                propertyInfo: typeof(ScoreboardModel).GetProperty("IdScoreboard", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ScoreboardModel).GetField("<IdScoreboard>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            idScoreboard.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var playerPoints = runtimeEntityType.AddProperty(
                "PlayerPoints",
                typeof(int),
                propertyInfo: typeof(ScoreboardModel).GetProperty("PlayerPoints", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ScoreboardModel).GetField("<PlayerPoints>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            playerPoints.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var setPoints = runtimeEntityType.AddProperty(
                "SetPoints",
                typeof(int),
                propertyInfo: typeof(ScoreboardModel).GetProperty("SetPoints", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ScoreboardModel).GetField("<SetPoints>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            setPoints.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("DiscriminatorValue", "ScoreboardModel");
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Player");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
