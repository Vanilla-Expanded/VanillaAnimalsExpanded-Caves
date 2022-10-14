using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;
using System.Reflection.Emit;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Verse.AI;

namespace VAECaves
{

    [HarmonyPatch(typeof(MapTemperature))]
    [HarmonyPatch("SeasonAcceptableFor")]
    public static class MagicalMenagerie_MapTemperature_SeasonAcceptableFor_Patch
    {
        [HarmonyPostfix]
        public static void AllowAnimalSpawns(ThingDef animalRace, ref bool __result, Map ___map)

        {

            if(animalRace != null && animalRace.defName.Contains("VAECaves_"))
                    {
                if (!Find.World.HasCaves(___map.Tile))
                {
                    __result= false;
                }

            }

           


        }
    }





}
