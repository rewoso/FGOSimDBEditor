using System;
using System.Collections.Generic;
using System.Text;

namespace FGOSDBE.Models.SDBEModel
{
    public static class Consts
    {
        public const string ServantIconFolder = "D:\\work\\FGOSimulator\\Material_edit\\i\\icon_servants";
        public const string MaterialIconFolder = "D:\\work\\FGOSimulator\\Material_edit\\i\\icon";
        public const string SkillIconFolder = "D:\\work\\FGOSimulator\\Material_edit\\i\\icon_skills";

        /// <summary>
        /// レアリティ（value）
        /// ☆１～５
        /// </summary>
        public enum Reality
        {
            Star1,
            Star2,
            Star3,
            Star4,
            Star5,
        }
        public const string RealityTextStar1 = "☆1";
        public const string RealityTextStar2 = "☆2";
        public const string RealityTextStar3 = "☆3";
        public const string RealityTextStar4 = "☆4";
        public const string RealityTextStar5 = "☆5";

        /// <summary>
        /// サーヴァントのクラス
        /// </summary>
        /// <remarks>
        ///  0:セイバー
        ///  1:アーチャー
        ///  2:ランサー
        ///  3:ライダー
        ///  4:キャスター
        ///  5:アサシン
        ///  6:バーサーカー
        ///  7:ルーラー
        ///  8:アヴェンジャー
        ///  9:シールダー
        /// 10:ムーンキャンサー
        /// 11:アルターエゴ
        /// 12:フォーリナー
        /// 13:プリテンダー
        /// </remarks>
        public enum ServantClass
        {
            Saber,
            Archer,
            Lancer,
            Rider,
            Caster,
            Assassin,
            Berserker,
            Ruler,
            Avenger,
            Shielder,
            MoonCancer,
            AlterEgo,
            Foreigner,
            Pretender,
        }
        public static string ServantClassTextSaber = "セイバー";
        public static string ServantClassTextArcher = "アーチャー";
        public static string ServantClassTextLancer = "ランサー";
        public static string ServantClassTextRider = "ライダー";
        public static string ServantClassTextCaster = "キャスター";
        public static string ServantClassTextAssassin = "アサシン";
        public static string ServantClassTextBerserker = "バーサーカー";
        public static string ServantClassTextRuler = "ルーラー";
        public static string ServantClassTextAvenger = "アヴェンジャー";
        public static string ServantClassTextShielder = "シールダー";
        public static string ServantClassTextMoonCancer = "ムーンキャンサー";
        public static string ServantClassTextAlterEgo = "アルターエゴ";
        public static string ServantClassTextForeigner = "フォーリナー";
        public static string ServantClassTextPretender = "プリテンダー";

        public static List<ServantClass> ServantClassBasic = new List<ServantClass> { ServantClass.Saber, ServantClass.Archer, ServantClass.Lancer, ServantClass.Rider, ServantClass.Caster, ServantClass.Assassin, ServantClass.Berserker };
        public static List<ServantClass> ServantClassExtra = new List<ServantClass> { ServantClass.Ruler, ServantClass.Avenger, ServantClass.Shielder, ServantClass.MoonCancer, ServantClass.AlterEgo, ServantClass.Foreigner, ServantClass.Pretender };

        public const string MaterialByClassSaberPiece = "100";
        public const string MaterialByClassSaberMonument = "110";
        public const string MaterialByClassSaberShining = "200";
        public const string MaterialByClassSaberMagic = "210";
        public const string MaterialByClassSaberSecret = "220";
        public const string MaterialByClassArcherPiece = "101";
        public const string MaterialByClassArcherMonument = "111";
        public const string MaterialByClassArcherShining = "201";
        public const string MaterialByClassArcherMagic = "211";
        public const string MaterialByClassArcherSecret = "221";
        public const string MaterialByClassLancerPiece = "102";
        public const string MaterialByClassLancerMonument = "112";
        public const string MaterialByClassLancerShining = "202";
        public const string MaterialByClassLancerMagic = "212";
        public const string MaterialByClassLancerSecret = "222";
        public const string MaterialByClassRiderPiece = "103";
        public const string MaterialByClassRiderMonument = "113";
        public const string MaterialByClassRiderShining = "203";
        public const string MaterialByClassRiderMagic = "213";
        public const string MaterialByClassRiderSecret = "223";
        public const string MaterialByClassCasterPiece = "104";
        public const string MaterialByClassCasterMonument = "114";
        public const string MaterialByClassCasterShining = "204";
        public const string MaterialByClassCasterMagic = "214";
        public const string MaterialByClassCasterSecret = "224";
        public const string MaterialByClassAssassinPiece = "105";
        public const string MaterialByClassAssassinMonument = "115";
        public const string MaterialByClassAssassinShining = "205";
        public const string MaterialByClassAssassinMagic = "215";
        public const string MaterialByClassAssassinSecret = "225";
        public const string MaterialByClassBerserkerPiece = "106";
        public const string MaterialByClassBerserkerMonument = "116";
        public const string MaterialByClassBerserkerShining = "206";
        public const string MaterialByClassBerserkerMagic = "216";
        public const string MaterialByClassBerserkerSecret = "226";

        public static List<string> MaterialByClassSaber = new List<string> { MaterialByClassSaberPiece, MaterialByClassSaberMonument, MaterialByClassSaberShining, MaterialByClassSaberMagic, MaterialByClassSaberSecret };
        public static List<string> MaterialByClassArcher = new List<string> { MaterialByClassArcherPiece, MaterialByClassArcherMonument, MaterialByClassArcherShining, MaterialByClassArcherMagic, MaterialByClassArcherSecret };
        public static List<string> MaterialByClassLancer = new List<string> { MaterialByClassLancerPiece, MaterialByClassLancerMonument, MaterialByClassLancerShining, MaterialByClassLancerMagic, MaterialByClassLancerSecret };
        public static List<string> MaterialByClassRider = new List<string> { MaterialByClassRiderPiece, MaterialByClassRiderMonument, MaterialByClassRiderShining, MaterialByClassRiderMagic, MaterialByClassRiderSecret };
        public static List<string> MaterialByClassCaster = new List<string> { MaterialByClassCasterPiece, MaterialByClassCasterMonument, MaterialByClassCasterShining, MaterialByClassCasterMagic, MaterialByClassCasterSecret };
        public static List<string> MaterialByClassAssassin = new List<string> { MaterialByClassAssassinPiece, MaterialByClassAssassinMonument, MaterialByClassAssassinShining, MaterialByClassAssassinMagic, MaterialByClassAssassinSecret };
        public static List<string> MaterialByClassBerserker = new List<string> { MaterialByClassBerserkerPiece, MaterialByClassBerserkerMonument, MaterialByClassBerserkerShining, MaterialByClassBerserkerMagic, MaterialByClassBerserkerSecret };

        public static List<List<string>> MaterialByClass = new List<List<string>> { MaterialByClassSaber, MaterialByClassArcher, MaterialByClassLancer, MaterialByClassRider, MaterialByClassCaster, MaterialByClassAssassin, MaterialByClassBerserker };

        /// <summary>
        /// 宝具タイプ
        /// </summary>
        public enum NPType
        {
            Baster,
            Arts,
            Quick,
        }
        public static string NPTypeTextBaster = "バスター";
        public static string NPTypeTextArts = "アーツ";
        public static string NPTypeTextQuick = "クイック";
        public static string NPTypeDBValueBaster = "nptypeB:1";
        public static string NPTypeDBValueArts = "nptypeA:1";
        public static string NPTypeDBValueQuick = "nptypeQ:1";


        /// <summary>
        /// 宝具対象
        /// </summary>
        public enum NPTarget
        {
            All,
            One,
            Support,
        }
        public static string NPTargetTextAll = "全体攻撃";
        public static string NPTargetTextOne = "単体攻撃";
        public static string NPTargetTextSupport = "補助";
        public static string NPTargetDBValueAll = "npeffectA:1";
        public static string NPTargetDBValueOne = "npeffectO:1";
        public static string NPTargetDBValueSupport = "npeffectS:1";


        /// <summary>
        /// 方針
        /// </summary>
        public enum Policy
        {
            Law,
            Neutral,
            Chaos,
        }
        public static string PolicyTextLaw = "秩序";
        public static string PolicyTextNeutral = "中立";
        public static string PolicyTextChaos = "混沌";
        public static string PolicyDBValueLaw = "policyLaw:1";
        public static string PolicyDBValueNeutral = "policyNeutral:1";
        public static string PolicyDBValueChaos = "policyChaos:1";

        /// <summary>
        /// 性格
        /// </summary>
        public enum Personality
        {
            Good,
            Neutral,
            Evil,
            Mad,
            Bride,
            Summer,
        }
        public static string PersonalityTextGood = "善";
        public static string PersonalityTextNeutral = "中庸";
        public static string PersonalityTextEvil = "悪";
        public static string PersonalityTextMad = "狂";
        public static string PersonalityTextBride = "花嫁";
        public static string PersonalityTextSummer = "夏";
        public static string PersonalityDBValueGood = "personalGood:1";
        public static string PersonalityDBValueNeutral = "personalNeutral:1";
        public static string PersonalityDBValueEvil = "personalEvil:1";
        public static string PersonalityDBValueMad = "personalMad:1";
        public static string PersonalityDBValueBride = "personalBride:1";
        public static string PersonalityDBValueSummer = "personalSummer:1";

        /// <summary>
        /// 属性
        /// </summary>
        public enum Attribute
        {
            Sky,
            Earth,
            Man,
            Star,
            Beast,
        }
        public static string AttributeTextSky = "天";
        public static string AttributeTextEarth = "地";
        public static string AttributeTextMan = "人";
        public static string AttributeTextStar = "星";
        public static string AttributeTextBeast = "獣";
        public static string AttributeDBValueSky = "attrbuteSky:1";
        public static string AttributeDBValueEarth = "attrbuteEarth:1";
        public static string AttributeDBValueMan = "attrbuteMan:1";
        public static string AttributeDBValueStar = "attrbuteStar:1";
        public static string AttributeDBValueBeast = "attrbuteBeast:1";

        /// <summary>
        /// 特性
        /// </summary>
        /// <remarks>
        /// https://grandorder.wiki/Traits
        /// ここに合わせてる
        /// </remarks>
        public enum Trait
        {
            Male,
            Female,
            Genderless,
            altriaface,
            animallike,
            arthur,
            AssociatedtotheArgo,
            Child,
            Chinese,
            Demonic,
            DemonicBeast,
            Divine,
            Dragon,
            Giant,
            GreekMythologyMales,
            Hominidae,
            Humanoid,
            Illya,
            Japanese,
            King,
            LivingHuman,
            LovedOne,
            Riding,
            Roman,
            SuperGiant,
            Shuten,
            ThreattoHumanity,
            WeaktoEnumaElish,
            WildBeast,
            Davinci,
            KnightsoftheRoundTable,
            SummerMode,
            npEXmale,
            npEXfemale,
            npEXdivine,
            npEXdragon,
            npEXpoison,
            npEXriding,
            npEXlove,
            npEXevil,
            npEXdemonic,
            npEXskyearth,
            npEXservant,
            npEXface,
            npEXarthur,
            npEXsaber,
            sEXmale,
            sEXdivine,
            sEXdragon,
            sEXroma,
            sEXsavagebeast,
            sEXevil,
            sEXdemonic,
            sEXskyearth,
            sEXhuman,
            sEXhumanoid,
            sEXundead,
            sEXdemon,
            sEXlarge,
            sEXsaber,
        }
        public static string TraitTextMale = "男性";
        public static string TraitTextFemale = "女性";
        public static string TraitTextGenderless = "性別不明";
        public static string TraitTextaltriaface = "アルトリア顔";
        public static string TraitTextanimallike = "ケモノ科";
        public static string TraitTextarthur = "アーサー";
        public static string TraitTextAssociatedtotheArgo = "アルゴノーツ";
        public static string TraitTextChild = "子供";
        public static string TraitTextChinese = "中国";
        public static string TraitTextDemonic = "魔性";
        public static string TraitTextDemonicBeast = "魔獣";
        public static string TraitTextDivine = "神性";
        public static string TraitTextDragon = "竜";
        public static string TraitTextGiant = "巨大";
        public static string TraitTextGreekMythologyMales = "ギリシャ男";
        public static string TraitTextHominidae = "人間";
        public static string TraitTextHumanoid = "人型";
        public static string TraitTextIllya = "イリヤ";
        public static string TraitTextJapanese = "日本人";
        public static string TraitTextKing = "王";
        public static string TraitTextLivingHuman = "今を生きる";
        public static string TraitTextLovedOne = "愛する";
        public static string TraitTextRiding = "騎乗";
        public static string TraitTextRoman = "ローマ";
        public static string TraitTextSuperGiant = "超巨大";
        public static string TraitTextShuten = "酒吞";
        public static string TraitTextThreattoHumanity = "人類への脅威";
        public static string TraitTextWeaktoEnumaElish = "エヌマエリシュ特攻無効";
        public static string TraitTextWildBeast = "猛獣";
        public static string TraitTextDavinci = "ダヴィンチセレクト"; //ハロウィン２０１６イベントで使用
        public static string TraitTextKnightsoftheRoundTable = "円卓の騎士";
        public static string TraitTextSummerMode = "夏モード";
        public static string TraitTextnpEXmale = "宝具 男性特攻";
        public static string TraitTextnpEXfemale = "宝具 女性特攻";
        public static string TraitTextnpEXdivine = "宝具 神性特攻";
        public static string TraitTextnpEXdragon = "宝具 竜特攻";
        public static string TraitTextnpEXpoison = "宝具 毒特攻";
        public static string TraitTextnpEXriding = "宝具 騎乗特攻";
        public static string TraitTextnpEXlove = "宝具 愛する者特攻";
        public static string TraitTextnpEXevil = "宝具 悪特攻";
        public static string TraitTextnpEXdemonic = "宝具 魔性特攻";
        public static string TraitTextnpEXskyearth = "宝具 天地特攻";
        public static string TraitTextnpEXservant = "宝具 サーヴァント特攻";
        public static string TraitTextnpEXface = "宝具 アルトリア顔特攻";
        public static string TraitTextnpEXarthur = "宝具 アーサー特攻";
        public static string TraitTextnpEXsaber = "宝具 セイバー特攻";
        public static string TraitTextsEXmale = "スキル 男性特攻";
        public static string TraitTextsEXdivine = "スキル 神性特攻";
        public static string TraitTextsEXdragon = "スキル 竜特攻";
        public static string TraitTextsEXroma = "スキル ローマ特攻";
        public static string TraitTextsEXsavagebeast = "スキル 猛獣特攻";
        public static string TraitTextsEXevil = "スキル 悪特攻";
        public static string TraitTextsEXdemonic = "スキル 魔性特攻";
        public static string TraitTextsEXskyearth = "スキル 天地特攻";
        public static string TraitTextsEXhuman = "スキル 人間特攻";
        public static string TraitTextsEXhumanoid = "スキル 人型特攻";
        public static string TraitTextsEXundead = "スキル 死霊特攻";
        public static string TraitTextsEXdemon = "スキル 悪魔特攻";
        public static string TraitTextsEXlarge = "スキル 超巨大特攻";
        public static string TraitTextsEXsaber = "スキル セイバー特攻";

        public static string TraitDBValueMale = "male:1";
        public static string TraitDBValueFemale = "female:1";
        public static string TraitDBValueGenderless = "genderless:1";
        public static string TraitDBValuealtriaface = "saberface:1";
        public static string TraitDBValueanimallike = "animallike:1";
        public static string TraitDBValuearthur = "arthur:1";
        public static string TraitDBValueAssociatedtotheArgo = "associatedtotheargo:1";
        public static string TraitDBValueChild = "child:1";
        public static string TraitDBValueChinese = "chinese:1";
        public static string TraitDBValueDemonic = "devilish:1";
        public static string TraitDBValueDemonicBeast = "demonicbeast:1";
        public static string TraitDBValueDivine = "divinity:1";
        public static string TraitDBValueDragon = "dragon:1";
        public static string TraitDBValueGiant = "giant:1";
        public static string TraitDBValueGreekMythologyMales = "greekmythologymales:1";
        public static string TraitDBValueHominidae = "hominidae:1";
        public static string TraitDBValueHumanoid = "humanoid:1";
        public static string TraitDBValueIllya = "illya:1";
        public static string TraitDBValueJapanese = "japanese:1";
        public static string TraitDBValueKing = "king:1";
        public static string TraitDBValueLivingHuman = "livinghuman:1";
        public static string TraitDBValueLovedOne = "love:1";
        public static string TraitDBValueRiding = "riding:1";
        public static string TraitDBValueRoman = "roma:1";
        public static string TraitDBValueSuperGiant = "supergiant:1";
        public static string TraitDBValueShuten = "shuten:1";
        public static string TraitDBValueThreattoHumanity = "threattohumanity:1";
        public static string TraitDBValueWeaktoEnumaElish = "weaktoenumaelish:1";
        public static string TraitDBValueWildBeast = "savagebeast:1";
        public static string TraitDBValueDavinci = "davinci:1";
        public static string TraitDBValueKnightsoftheRoundTable = "knightsoftheroundtable:1";
        public static string TraitDBValueSummerMode = "summermode:1";
        public static string TraitDBValuenpEXmale = "npEXmale:1";
        public static string TraitDBValuenpEXfemale = "npEXfemale:1";
        public static string TraitDBValuenpEXdivine = "npEXdivine:1";
        public static string TraitDBValuenpEXdragon = "npEXdragon:1";
        public static string TraitDBValuenpEXpoison = "npEXpoison:1";
        public static string TraitDBValuenpEXriding = "npEXriding:1";
        public static string TraitDBValuenpEXlove = "npEXlove:1";
        public static string TraitDBValuenpEXevil = "npEXevil:1";
        public static string TraitDBValuenpEXdemonic = "npEXdemonic:1";
        public static string TraitDBValuenpEXskyearth = "npEXskyearth:1";
        public static string TraitDBValuenpEXservant = "npEXservant:1";
        public static string TraitDBValuenpEXface = "npEXface:1";
        public static string TraitDBValuenpEXarthur = "npEXarthur:1";
        public static string TraitDBValuenpEXsaber = "npEXsaber:1";
        public static string TraitDBValuesEXmale = "sEXmale:1";
        public static string TraitDBValuesEXdivine = "sEXdivine:1";
        public static string TraitDBValuesEXdragon = "sEXdragon:1";
        public static string TraitDBValuesEXroma = "sEXroma:1";
        public static string TraitDBValuesEXsavagebeast = "sEXsavagebeast:1";
        public static string TraitDBValuesEXevil = "sEXevil:1";
        public static string TraitDBValuesEXdemonic = "sEXdemonic:1";
        public static string TraitDBValuesEXskyearth = "sEXskyearth:1";
        public static string TraitDBValuesEXhuman = "sEXhuman:1";
        public static string TraitDBValuesEXhumanoid = "sEXhumanoid:1";
        public static string TraitDBValuesEXundead = "sEXundead:1";
        public static string TraitDBValuesEXdemon = "sEXdemon:1";
        public static string TraitDBValuesEXlarge = "sEXlarge:1";
        public static string TraitDBValuesEXsaber = "sEXsaber:1";


    }
}
