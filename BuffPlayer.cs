using Terraria;
using Terraria.ModLoader;

namespace CalamityVanillaBuff
{
	public class BuffPlayer : ModPlayer
	{
        public override void ModifyWeaponDamage(Item item, ref float add, ref float mult, ref float flat)
        {
            add += 0.2f;
        }
    }
}
