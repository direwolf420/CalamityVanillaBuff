using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaBuff
{
	public class BuffPlayer : ModPlayer
	{
        public override void ModifyWeaponDamage(Item item, ref float add, ref float mult, ref float flat)
        {
            if (item.type < ItemID.Count) add += 0.2f;
        }
    }
}
