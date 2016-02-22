using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicReview.Models
{
    public class AppEnums
    {
        public enum Color
        {
            White,
            Blue,
            Black,
            Red,
            Green,
            Colorless
        }

        public enum Type
        {
            Creature,
            Land,
            Enchantment,
            Planeswalker,
            Instant,
            Sorcery,
            Artifact
        }

        public enum KeywordAbility
        {
            Deathtouch,
            Defender,
            DoubleStrike,
            Enchant,
            Equip,
            FirstStrike,
            Flash,
            Flying,
            Haste,
            Hexproof,
            Indestructible,
            Intimidate,
            Landwalk,
            Lifelink,
            Protection,
            Reach,
            Shroud,
            Trample,
            Vigilance,
            Kicker,
            Flashback,
            Morph,
            Affinity,
            Convoke,
            SplitSecond,
            Suspend,
            Reinforce,
            Pesist,
            Wither,
            Exalted,
            Infect,
            TotemArmor,
            BattleCry,
            LivingWeapon,
            Undying,
            Miracle,
            Soulbond,
            Overload,
            Scavenge,
            Unleash,
            Cipher,
            Evolve,
            Extort,
            Fuse,
            Bestow,
            Tribute,
            Dethrone,
            HiddenAgenda,
            Outlast,
            Prowess,
            Dash,
            Exploit,
            Menace,
            Renown,
            Awaken,
            Devoid,
            Ingest,
            Myriad,
            Surge

        }

        public enum KeywordAction
        {
            Activate,
            Attach,
            Cast,
            Counter,
            Destroy,
            Discard,
            Exchange,
            Exile,
            Fight,
            Play,
            Regenerate,
            Reveal,
            Sacrifice,
            Search,
            Shuffle,
            TapAndUntap,
            Scry,
            Fateseal,
            Clash,
            Planeswalk,
            SetInMotion,
            Abandon,
            Proliferate,
            Transform,
            Detain,
            Populate,
            Monstrosity,
            Vote,
            Bolster,
            Manifest,
            Support,


        }

        public enum AbilityWord
        {
            Battalion,
            Bloodrush,
            Channel,
            Chroma,
            Cohort,
            Constellation,
            Converge,
            Delerium,
            Domain,
            FatefulHour,
            Ferocuious,
            Formidable,
            Grandeur,
            Hellbent,
            Heroic,
            Imprint,
            Inspired,
            JoinForces,
            Kinship,
            Landfall,
            Lieutenant,
            Metalcraft,
            Morbid,
            Parley,
            Radience,
            Raid,
            Rally,
            SpellMastery,
            Strive,
            Sweep,
            TemptingOffer,
            Threshold,
            WillOfTheCouncil
        }
    }
}