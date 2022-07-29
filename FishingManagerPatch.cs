using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace RF5_AutoFishing
{
	[HarmonyPatch(typeof(Fishing.FishingManager), nameof(Fishing.FishingManager.FishHit))]
	public class FishingManagerFishHit
	{
		static void Postfix(Fishing.FishingManager __instance)
		{
			// 开始咬饵，但没完全咬住
			// __instance.GetFish();
			// RF5Input.Pad.SetKey(RF5Input.Key.B);
			FishingManagerUpdate.CanPull = true;
		}
	}

	[HarmonyPatch(typeof(Fishing.FishingManager), nameof(Fishing.FishingManager.Update))]
	public class FishingManagerUpdate
	{
		public static bool CanPull = false;

		static void Postfix()
		{
			// 完全咬住时再收杠，如果失不会收起来
			if(CanPull)
				RF5Input.Pad.SetKey(RF5Input.Key.B);
			CanPull = false;
		}
	}
}
