using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace RF5_AutoFishing
{
	[HarmonyPatch(typeof(Fishing.FishingManager), nameof(Fishing.FishingManager.FishHit))]
	public class FishingManagerPatch
	{
		static void Postfix(Fishing.FishingManager __instance)
		{
			__instance.GetFish();
		}
	}
}
