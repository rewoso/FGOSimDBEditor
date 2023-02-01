using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;
using Reactive.Bindings;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class TraitModel
    {
        public Consts.Trait Value { get; }
        public string ValueString { get; }
        public string DisplayText { get; }
        public ReactiveProperty<bool> IsSelected { get; }

        public TraitModel()
        {
            
        }

        public TraitModel(Consts.Trait Trait)
        {
            IsSelected = new ReactiveProperty<bool>(false);
            Value = Trait;
            switch (Value)
            {
                case Consts.Trait.Male:
                    ValueString = Consts.TraitDBValueMale;
                    DisplayText = Consts.TraitTextMale;
                    break;
                case Consts.Trait.Female:
                    ValueString = Consts.TraitDBValueFemale;
                    DisplayText = Consts.TraitTextFemale;
                    break;
                case Consts.Trait.Genderless:
                    ValueString = Consts.TraitDBValueGenderless;
                    DisplayText = Consts.TraitTextGenderless;
                    break;
                case Consts.Trait.altriaface:
                    ValueString = Consts.TraitDBValuealtriaface;
                    DisplayText = Consts.TraitTextaltriaface;
                    break;
                case Consts.Trait.animallike:
                    ValueString = Consts.TraitDBValueanimallike;
                    DisplayText = Consts.TraitTextanimallike;
                    break;
                case Consts.Trait.arthur:
                    ValueString = Consts.TraitDBValuearthur;
                    DisplayText = Consts.TraitTextarthur;
                    break;
                case Consts.Trait.AssociatedtotheArgo:
                    ValueString = Consts.TraitDBValueAssociatedtotheArgo;
                    DisplayText = Consts.TraitTextAssociatedtotheArgo;
                    break;
                case Consts.Trait.Child:
                    ValueString = Consts.TraitDBValueChild;
                    DisplayText = Consts.TraitTextChild;
                    break;
                case Consts.Trait.Chinese:
                    ValueString = Consts.TraitDBValueChinese;
                    DisplayText = Consts.TraitTextChinese;
                    break;
                case Consts.Trait.Demonic:
                    ValueString = Consts.TraitDBValueDemonic;
                    DisplayText = Consts.TraitTextDemonic;
                    break;
                case Consts.Trait.DemonicBeast:
                    ValueString = Consts.TraitDBValueDemonicBeast;
                    DisplayText = Consts.TraitTextDemonicBeast;
                    break;
                case Consts.Trait.Divine:
                    ValueString = Consts.TraitDBValueDivine;
                    DisplayText = Consts.TraitTextDivine;
                    break;
                case Consts.Trait.Dragon:
                    ValueString = Consts.TraitDBValueDragon;
                    DisplayText = Consts.TraitTextDragon;
                    break;
                case Consts.Trait.Giant:
                    ValueString = Consts.TraitDBValueGiant;
                    DisplayText = Consts.TraitTextGiant;
                    break;
                case Consts.Trait.GreekMythologyMales:
                    ValueString = Consts.TraitDBValueGreekMythologyMales;
                    DisplayText = Consts.TraitTextGreekMythologyMales;
                    break;
                case Consts.Trait.Hominidae:
                    ValueString = Consts.TraitDBValueHominidae;
                    DisplayText = Consts.TraitTextHominidae;
                    break;
                case Consts.Trait.Humanoid:
                    ValueString = Consts.TraitDBValueHumanoid;
                    DisplayText = Consts.TraitTextHumanoid;
                    break;
                case Consts.Trait.Illya:
                    ValueString = Consts.TraitDBValueIllya;
                    DisplayText = Consts.TraitTextIllya;
                    break;
                case Consts.Trait.Japanese:
                    ValueString = Consts.TraitDBValueJapanese;
                    DisplayText = Consts.TraitTextJapanese;
                    break;
                case Consts.Trait.King:
                    ValueString = Consts.TraitDBValueKing;
                    DisplayText = Consts.TraitTextKing;
                    break;
                case Consts.Trait.LivingHuman:
                    ValueString = Consts.TraitDBValueLivingHuman;
                    DisplayText = Consts.TraitTextLivingHuman;
                    break;
                case Consts.Trait.LovedOne:
                    ValueString = Consts.TraitDBValueLovedOne;
                    DisplayText = Consts.TraitTextLovedOne;
                    break;
                case Consts.Trait.Riding:
                    ValueString = Consts.TraitDBValueRiding;
                    DisplayText = Consts.TraitTextRiding;
                    break;
                case Consts.Trait.Roman:
                    ValueString = Consts.TraitDBValueRoman;
                    DisplayText = Consts.TraitTextRoman;
                    break;
                case Consts.Trait.SuperGiant:
                    ValueString = Consts.TraitDBValueSuperGiant;
                    DisplayText = Consts.TraitTextSuperGiant;
                    break;
                case Consts.Trait.Shuten:
                    ValueString = Consts.TraitDBValueShuten;
                    DisplayText = Consts.TraitTextShuten;
                    break;
                case Consts.Trait.ThreattoHumanity:
                    ValueString = Consts.TraitDBValueThreattoHumanity;
                    DisplayText = Consts.TraitTextThreattoHumanity;
                    break;
                case Consts.Trait.WeaktoEnumaElish:
                    ValueString = Consts.TraitDBValueWeaktoEnumaElish;
                    DisplayText = Consts.TraitTextWeaktoEnumaElish;
                    break;
                case Consts.Trait.WildBeast:
                    ValueString = Consts.TraitDBValueWildBeast;
                    DisplayText = Consts.TraitTextWildBeast;
                    break;
                case Consts.Trait.Davinci:
                    ValueString = Consts.TraitDBValueDavinci;
                    DisplayText = Consts.TraitTextDavinci;
                    break;
                case Consts.Trait.KnightsoftheRoundTable:
                    ValueString = Consts.TraitDBValueKnightsoftheRoundTable;
                    DisplayText = Consts.TraitTextKnightsoftheRoundTable;
                    break;
                case Consts.Trait.SummerMode:
                    ValueString = Consts.TraitDBValueSummerMode;
                    DisplayText = Consts.TraitTextSummerMode;
                    break;
                case Consts.Trait.npEXmale:
                    ValueString = Consts.TraitDBValuenpEXmale;
                    DisplayText = Consts.TraitTextnpEXmale;
                    break;
                case Consts.Trait.npEXfemale:
                    ValueString = Consts.TraitDBValuenpEXfemale;
                    DisplayText = Consts.TraitTextnpEXfemale;
                    break;
                case Consts.Trait.npEXdivine:
                    ValueString = Consts.TraitDBValuenpEXdivine;
                    DisplayText = Consts.TraitTextnpEXdivine;
                    break;
                case Consts.Trait.npEXdragon:
                    ValueString = Consts.TraitDBValuenpEXdragon;
                    DisplayText = Consts.TraitTextnpEXdragon;
                    break;
                case Consts.Trait.npEXpoison:
                    ValueString = Consts.TraitDBValuenpEXpoison;
                    DisplayText = Consts.TraitTextnpEXpoison;
                    break;
                case Consts.Trait.npEXriding:
                    ValueString = Consts.TraitDBValuenpEXriding;
                    DisplayText = Consts.TraitTextnpEXriding;
                    break;
                case Consts.Trait.npEXlove:
                    ValueString = Consts.TraitDBValuenpEXlove;
                    DisplayText = Consts.TraitTextnpEXlove;
                    break;
                case Consts.Trait.npEXevil:
                    ValueString = Consts.TraitDBValuenpEXevil;
                    DisplayText = Consts.TraitTextnpEXevil;
                    break;
                case Consts.Trait.npEXdemonic:
                    ValueString = Consts.TraitDBValuenpEXdemonic;
                    DisplayText = Consts.TraitTextnpEXdemonic;
                    break;
                case Consts.Trait.npEXskyearth:
                    ValueString = Consts.TraitDBValuenpEXskyearth;
                    DisplayText = Consts.TraitTextnpEXskyearth;
                    break;
                case Consts.Trait.npEXservant:
                    ValueString = Consts.TraitDBValuenpEXservant;
                    DisplayText = Consts.TraitTextnpEXservant;
                    break;
                case Consts.Trait.npEXface:
                    ValueString = Consts.TraitDBValuenpEXface;
                    DisplayText = Consts.TraitTextnpEXface;
                    break;
                case Consts.Trait.npEXarthur:
                    ValueString = Consts.TraitDBValuenpEXarthur;
                    DisplayText = Consts.TraitTextnpEXarthur;
                    break;
                case Consts.Trait.npEXsaber:
                    ValueString = Consts.TraitDBValuenpEXsaber;
                    DisplayText = Consts.TraitTextnpEXsaber;
                    break;
                case Consts.Trait.sEXmale:
                    ValueString = Consts.TraitDBValuesEXmale;
                    DisplayText = Consts.TraitTextsEXmale;
                    break;
                case Consts.Trait.sEXdivine:
                    ValueString = Consts.TraitDBValuesEXdivine;
                    DisplayText = Consts.TraitTextsEXdivine;
                    break;
                case Consts.Trait.sEXdragon:
                    ValueString = Consts.TraitDBValuesEXdragon;
                    DisplayText = Consts.TraitTextsEXdragon;
                    break;
                case Consts.Trait.sEXroma:
                    ValueString = Consts.TraitDBValuesEXroma;
                    DisplayText = Consts.TraitTextsEXroma;
                    break;
                case Consts.Trait.sEXsavagebeast:
                    ValueString = Consts.TraitDBValuesEXsavagebeast;
                    DisplayText = Consts.TraitTextsEXsavagebeast;
                    break;
                case Consts.Trait.sEXevil:
                    ValueString = Consts.TraitDBValuesEXevil;
                    DisplayText = Consts.TraitTextsEXevil;
                    break;
                case Consts.Trait.sEXdemonic:
                    ValueString = Consts.TraitDBValuesEXdemonic;
                    DisplayText = Consts.TraitTextsEXdemonic;
                    break;
                case Consts.Trait.sEXskyearth:
                    ValueString = Consts.TraitDBValuesEXskyearth;
                    DisplayText = Consts.TraitTextsEXskyearth;
                    break;
                case Consts.Trait.sEXhuman:
                    ValueString = Consts.TraitDBValuesEXhuman;
                    DisplayText = Consts.TraitTextsEXhuman;
                    break;
                case Consts.Trait.sEXhumanoid:
                    ValueString = Consts.TraitDBValuesEXhumanoid;
                    DisplayText = Consts.TraitTextsEXhumanoid;
                    break;
                case Consts.Trait.sEXundead:
                    ValueString = Consts.TraitDBValuesEXundead;
                    DisplayText = Consts.TraitTextsEXundead;
                    break;
                case Consts.Trait.sEXdemon:
                    ValueString = Consts.TraitDBValuesEXdemon;
                    DisplayText = Consts.TraitTextsEXdemon;
                    break;
                case Consts.Trait.sEXlarge:
                    ValueString = Consts.TraitDBValuesEXlarge;
                    DisplayText = Consts.TraitTextsEXlarge;
                    break;
                case Consts.Trait.sEXsaber:
                    ValueString = Consts.TraitDBValuesEXsaber;
                    DisplayText = Consts.TraitTextsEXsaber;
                    break;
                default:
                    ValueString = string.Empty;
                    DisplayText = string.Empty;
                    break;
            }
        }
    }
}
