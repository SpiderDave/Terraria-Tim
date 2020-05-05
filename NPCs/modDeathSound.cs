using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tim.NPCs
{
	public class modDeathSound : GlobalNPC
	{
		public override void SetDefaults(NPC npc) 
		{
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCKilled, "Sounds/NPCKilled/aeuhhh").WithVolume(0.5f);
		}
	}
}