using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class FrogMask : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 20;
			item.height = 24;
			item.rare = 1;
			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frog Mask");
			Tooltip.SetDefault("");
		}

	}
}
