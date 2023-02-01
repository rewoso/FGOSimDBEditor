using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class PersonalityModel
    {
        public Consts.Personality Value { get; }
        public string ValueString { get; }
        public string DisplayText { get; }

        public PersonalityModel()
        {

        }

        public PersonalityModel(Consts.Personality Personal)
        {
            Value = Personal;
            switch (Value)
            {
                case Consts.Personality.Good:
                    ValueString = Consts.PersonalityDBValueGood;
                    DisplayText = Consts.PersonalityTextGood;
                    break;
                case Consts.Personality.Neutral:
                    ValueString = Consts.PersonalityDBValueNeutral;
                    DisplayText = Consts.PersonalityTextNeutral;
                    break;
                case Consts.Personality.Evil:
                    ValueString = Consts.PersonalityDBValueEvil;
                    DisplayText = Consts.PersonalityTextEvil;
                    break;
                case Consts.Personality.Mad:
                    ValueString = Consts.PersonalityDBValueMad;
                    DisplayText = Consts.PersonalityTextMad;
                    break;
                case Consts.Personality.Bride:
                    ValueString = Consts.PersonalityDBValueBride;
                    DisplayText = Consts.PersonalityTextBride;
                    break;
                case Consts.Personality.Summer:
                    ValueString = Consts.PersonalityDBValueSummer;
                    DisplayText = Consts.PersonalityTextSummer;
                    break;
                default:
                    ValueString = string.Empty;
                    DisplayText = string.Empty;
                    break;
            }
        }
    }
}
