using HarmonyLib;

namespace RF5_AutoFishing;

[HarmonyPatch(typeof(Fishing.FishingManager), nameof(Fishing.FishingManager.FishHit))]
public class FishingManagerFishHit
{
	static void Postfix(Fishing.FishingManager __instance)
	{
		FishingManagerUpdate.CanPull = true;
	}
}

[HarmonyPatch(typeof(Fishing.FishingManager), nameof(Fishing.FishingManager.Update))]
public class FishingManagerUpdate
{
	public static bool CanPull = false;

	static void Postfix()
	{
		if (CanPull)
		{
			RF5Input.Pad.SetKey(RF5Input.Key.B);
		}
		CanPull = false;
	}
}
