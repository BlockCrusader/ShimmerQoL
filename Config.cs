using System.Collections.Generic;
using System.ComponentModel;
using Terraria.ID;
using Terraria.ModLoader.Config;

namespace ShimmerQoL
{
	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(true)]
        public bool aetherPrefixing;

        public List<PrefixDefinition> prefixBlacklist = new List<PrefixDefinition>
            {
                new PrefixDefinition(PrefixID.Large),
                new PrefixDefinition(PrefixID.Massive),
                new PrefixDefinition(PrefixID.Dangerous),
                new PrefixDefinition(PrefixID.Savage),
                new PrefixDefinition(PrefixID.Sharp),
                new PrefixDefinition(PrefixID.Pointy),
                new PrefixDefinition(PrefixID.Tiny),
                new PrefixDefinition(PrefixID.Terrible),
                new PrefixDefinition(PrefixID.Small),
                new PrefixDefinition(PrefixID.Dull),
                new PrefixDefinition(PrefixID.Unhappy),
                new PrefixDefinition(PrefixID.Bulky),
                new PrefixDefinition(PrefixID.Shameful),
                new PrefixDefinition(PrefixID.Heavy),
                new PrefixDefinition(PrefixID.Sighted),
                new PrefixDefinition(PrefixID.Rapid),
                new PrefixDefinition(PrefixID.Hasty),
                new PrefixDefinition(PrefixID.Intimidating),
                new PrefixDefinition(PrefixID.Deadly),
                new PrefixDefinition(PrefixID.Staunch),
                new PrefixDefinition(PrefixID.Awful),
                new PrefixDefinition(PrefixID.Lethargic),
                new PrefixDefinition(PrefixID.Awkward),
                new PrefixDefinition(PrefixID.Powerful),
                new PrefixDefinition(PrefixID.Mystic),
                new PrefixDefinition(PrefixID.Adept),
                new PrefixDefinition(PrefixID.Masterful),
                new PrefixDefinition(PrefixID.Inept),
                new PrefixDefinition(PrefixID.Ignorant),
                new PrefixDefinition(PrefixID.Deranged),
                new PrefixDefinition(PrefixID.Intense),
                new PrefixDefinition(PrefixID.Taboo),
                new PrefixDefinition(PrefixID.Celestial),
                new PrefixDefinition(PrefixID.Furious),
                new PrefixDefinition(PrefixID.Keen),
                new PrefixDefinition(PrefixID.Superior),
                new PrefixDefinition(PrefixID.Forceful),
                new PrefixDefinition(PrefixID.Broken),
                new PrefixDefinition(PrefixID.Damaged),
                new PrefixDefinition(PrefixID.Shoddy),
                new PrefixDefinition(PrefixID.Quick),
                new PrefixDefinition(PrefixID.Deadly2),
                new PrefixDefinition(PrefixID.Agile),
                new PrefixDefinition(PrefixID.Nimble),
                new PrefixDefinition(PrefixID.Murderous),
                new PrefixDefinition(PrefixID.Slow),
                new PrefixDefinition(PrefixID.Sluggish),
                new PrefixDefinition(PrefixID.Lazy),
                new PrefixDefinition(PrefixID.Annoying),
                new PrefixDefinition(PrefixID.Nasty),
                new PrefixDefinition(PrefixID.Manic),
                new PrefixDefinition(PrefixID.Hurtful),
                new PrefixDefinition(PrefixID.Strong),
                new PrefixDefinition(PrefixID.Unpleasant),
                new PrefixDefinition(PrefixID.Weak),
                new PrefixDefinition(PrefixID.Frenzying),
                new PrefixDefinition(PrefixID.Zealous),
                new PrefixDefinition(PrefixID.Hard),
                new PrefixDefinition(PrefixID.Guarding),
                new PrefixDefinition(PrefixID.Armored),
                new PrefixDefinition(PrefixID.Precise),
                new PrefixDefinition(PrefixID.Jagged),
                new PrefixDefinition(PrefixID.Spiked),
                new PrefixDefinition(PrefixID.Angry),
                new PrefixDefinition(PrefixID.Brisk),
                new PrefixDefinition(PrefixID.Fleeting),
                new PrefixDefinition(PrefixID.Hasty2),
                new PrefixDefinition(PrefixID.Wild),
                new PrefixDefinition(PrefixID.Rash),
                new PrefixDefinition(PrefixID.Intrepid)
            };

        [DefaultValue(false)]
        public bool nerfPrefixing;

        [DefaultValue(true)]
        public bool transmuteTooltip;

        [DefaultValue(false)]
        public bool compoundTooltip;

        [DefaultValue(true)]
        public bool wellCrafting;

        [DefaultValue(true)]
        [ReloadRequired]
        public bool wellAether;

        [DefaultValue(true)]
        public bool sellAetherPylon;

        [DefaultValue(1)]
        public int aetherPylonNPCS;

        [DefaultValue(false)]
        [ReloadRequired]
        public bool easyPylon;
    }
}
