﻿using UnityEngine;
using STRINGS;

namespace RollerSnake
{
    public class BabySteelRollerSnakeConfig : IEntityConfig
    {
        public const string Id = "RollerSnakeSteelBaby";
        public static string Name = UI.FormatAsLink("Tough Roller Snakelet", SteelRollerSnakeConfig.Id.ToUpper());
        public static string Description = $"The young of a {SteelRollerSnakeConfig.Name}. Smaller and has trouble rolling up into an actual loop. ";

        public GameObject CreatePrefab()
        {
            GameObject rollerSnake = SteelRollerSnakeConfig.CreateSteelRollerSnake(Id, Name, Description, "babyrollersnake_kanim", true);
            EntityTemplates.ExtendEntityToBeingABaby(rollerSnake, SteelRollerSnakeConfig.Id, null);
            return rollerSnake;
        }

        public void OnPrefabInit(GameObject inst)
        {
        }

        public void OnSpawn(GameObject inst)
        {
        }
    }
}
