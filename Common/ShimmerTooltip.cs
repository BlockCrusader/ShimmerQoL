using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShimmerQoL.Common
{
	public class ShimmerTooltip : GlobalItem
	{
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            int transumtationItemID = ShimmerHelpers.TransumtationID(item);
            if (transumtationItemID != -1 && !item.social && ModContent.GetInstance<Config>().transmuteTooltip)
            {
                int insertIndex = FindTooltipIndex(tooltips, out bool hasMaterialTip);
                if(insertIndex == -1)
                {
                    tooltips.Add(new TooltipLine(Mod, "transumtationTip", Language.GetTextValue("Mods.ShimmerQoL.CommonItemTooltip.TransmutableTip")));
                }
                else
                {
                    try
                    {
                        if (hasMaterialTip && ModContent.GetInstance<Config>().compoundTooltip)
                        {
                            TooltipLine target = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Material", default);
                            tooltips.Insert(insertIndex, new TooltipLine(Mod, "transumtableMaterial", Language.GetTextValue("Mods.ShimmerQoL.CommonItemTooltip.TransumtableMaterialTip")));
                            tooltips.Remove(target); // Removes vanilla line
                        }
                        else
                        {
                            tooltips.Insert(insertIndex + 1, new TooltipLine(Mod, "transumtationTip", Language.GetTextValue("Mods.ShimmerQoL.CommonItemTooltip.TransmutableTip")));
                        }
                        
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        if (hasMaterialTip && ModContent.GetInstance<Config>().compoundTooltip)
                        {
                            TooltipLine target = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Material", default);
                            tooltips.Add(new TooltipLine(Mod, "transumtableMaterial", Language.GetTextValue("Mods.ShimmerQoL.CommonItemTooltip.TransumtableMaterialTip")));
                            tooltips.Remove(target); // Removes vanilla line
                        }
                        else
                        {
                            tooltips.Add(new TooltipLine(Mod, "transumtationTip", Language.GetTextValue("Mods.ShimmerQoL.CommonItemTooltip.TransmutableTip")));
                        }
                    }
                }
            }
        }

        private int FindTooltipIndex(List<TooltipLine> tooltips, out bool hasMaterialTip)
        {
            hasMaterialTip = false;
            TooltipLine material = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Material", default);
            if (material != default(TooltipLine))
            {
                hasMaterialTip = true;
                return tooltips.IndexOf(material);
            }

            TooltipLine consumable = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Consumable", default);
            if (consumable != default(TooltipLine))
            {
                return tooltips.IndexOf(consumable);
            }

            TooltipLine ammo = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Ammo", default);
            if (ammo != default(TooltipLine))
            {
                return tooltips.IndexOf(ammo);
            }

            TooltipLine placeable = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Placeable", default);
            if (placeable != default(TooltipLine))
            {
                return tooltips.IndexOf(placeable);
            }

            TooltipLine useMana = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "UseMana", default);
            if (useMana != default(TooltipLine))
            {
                return tooltips.IndexOf(useMana);
            }

            TooltipLine healMana = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "HealMana", default);
            if (healMana != default(TooltipLine))
            {
                return tooltips.IndexOf(healMana);
            }

            TooltipLine healLife = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "HealLife", default);
            if (healLife != default(TooltipLine))
            {
                return tooltips.IndexOf(healLife);
            }

            TooltipLine tileBoost = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "TileBoost", default);
            if (tileBoost != default(TooltipLine))
            {
                return tooltips.IndexOf(tileBoost);
            }

            TooltipLine hammerPower = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "HammerPower", default);
            if (hammerPower != default(TooltipLine))
            {
                return tooltips.IndexOf(hammerPower);
            }

            TooltipLine axePower = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "AxePower", default);
            if (axePower != default(TooltipLine))
            {
                return tooltips.IndexOf(axePower);
            }

            TooltipLine pickPower = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "PickPower", default);
            if (pickPower != default(TooltipLine))
            {
                return tooltips.IndexOf(pickPower);
            }

            TooltipLine defense = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Defense", default);
            if (defense != default(TooltipLine))
            {
                return tooltips.IndexOf(defense);
            }

            TooltipLine vanity = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Vanity", default);
            if (vanity != default(TooltipLine))
            {
                return tooltips.IndexOf(vanity);
            }

            TooltipLine quest = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Quest", default);
            if (quest != default(TooltipLine))
            {
                return tooltips.IndexOf(quest);
            }

            TooltipLine wandConsumes = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "WandConsumes", default);
            if (wandConsumes != default(TooltipLine))
            {
                return tooltips.IndexOf(wandConsumes);
            }

            TooltipLine equipable = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Equipable", default);
            if (equipable != default(TooltipLine))
            {
                return tooltips.IndexOf(equipable);
            }

            TooltipLine baitPower = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "BaitPower", default);
            if (baitPower != default(TooltipLine))
            {
                return tooltips.IndexOf(baitPower);
            }

            TooltipLine needsBait = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "NeedsBait", default);
            if (needsBait != default(TooltipLine))
            {
                return tooltips.IndexOf(needsBait);
            }

            TooltipLine fishingPower = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "FishingPower", default);
            if (fishingPower != default(TooltipLine))
            {
                return tooltips.IndexOf(fishingPower);
            }

            TooltipLine knockback = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Knockback", default);
            if (knockback != default(TooltipLine))
            {
                return tooltips.IndexOf(knockback);
            }

            TooltipLine specialSpeedScaling = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "SpecialSpeedScaling", default);
            if (specialSpeedScaling != default(TooltipLine))
            {
                return tooltips.IndexOf(specialSpeedScaling);
            }

            TooltipLine noSpeedScaling = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "NoSpeedScaling", default);
            if (noSpeedScaling != default(TooltipLine))
            {
                return tooltips.IndexOf(noSpeedScaling);
            }

            TooltipLine speed = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Speed", default);
            if (speed != default(TooltipLine))
            {
                return tooltips.IndexOf(speed);
            }

            TooltipLine critChance = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "CritChance", default);
            if (critChance != default(TooltipLine))
            {
                return tooltips.IndexOf(critChance);
            }

            TooltipLine damage = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "Damage", default);
            if (damage != default(TooltipLine))
            {
                return tooltips.IndexOf(damage);
            }

            TooltipLine noTransfer = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "NoTransfer", default);
            if (noTransfer != default(TooltipLine))
            {
                return tooltips.IndexOf(noTransfer);
            }

            TooltipLine favoriteDesc = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "FavoriteDesc", default);
            if (favoriteDesc != default(TooltipLine))
            {
                return tooltips.IndexOf(favoriteDesc);
            }

            TooltipLine itemName = tooltips.FirstOrDefault(line => line.Mod == "Terraria" && line.Name == "ItemName", default);
            if (itemName != default(TooltipLine))
            {
                return tooltips.IndexOf(itemName);
            }

            return -1;
        }
    }
}
