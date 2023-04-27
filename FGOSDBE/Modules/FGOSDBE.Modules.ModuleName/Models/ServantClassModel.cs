using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class ServantClassModel
    {
        public Consts.ServantClass Value { get; }
        public string ValueString { get; }
        public string DisplayText { get; }

        public ServantClassModel()
        {

        }

        public ServantClassModel(Consts.ServantClass servantclass)
        {
            Value = servantclass;
            ValueString = ((int)servantclass).ToString();
            switch (Value)
            {
                case Consts.ServantClass.Saber:
                    DisplayText = Consts.ServantClassTextSaber;
                    break;
                case Consts.ServantClass.Archer:
                    DisplayText = Consts.ServantClassTextArcher;
                    break;
                case Consts.ServantClass.Lancer:
                    DisplayText = Consts.ServantClassTextLancer;
                    break;
                case Consts.ServantClass.Rider:
                    DisplayText = Consts.ServantClassTextRider;
                    break;
                case Consts.ServantClass.Caster:
                    DisplayText = Consts.ServantClassTextCaster;
                    break;
                case Consts.ServantClass.Assassin:
                    DisplayText = Consts.ServantClassTextAssassin;
                    break;
                case Consts.ServantClass.Berserker:
                    DisplayText = Consts.ServantClassTextBerserker;
                    break;
                case Consts.ServantClass.Ruler:
                    DisplayText = Consts.ServantClassTextRuler;
                    break;
                case Consts.ServantClass.Avenger:
                    DisplayText = Consts.ServantClassTextAvenger;
                    break;
                case Consts.ServantClass.Shielder:
                    DisplayText = Consts.ServantClassTextShielder;
                    break;
                case Consts.ServantClass.MoonCancer:
                    DisplayText = Consts.ServantClassTextMoonCancer;
                    break;
                case Consts.ServantClass.AlterEgo:
                    DisplayText = Consts.ServantClassTextAlterEgo;
                    break;
                case Consts.ServantClass.Foreigner:
                    DisplayText = Consts.ServantClassTextForeigner;
                    break;
                case Consts.ServantClass.Pretender:
                    DisplayText = Consts.ServantClassTextPretender;
                    break;
                case Consts.ServantClass.Beast:
                    DisplayText = Consts.ServantClassTextBeast;
                    break;
                default:
                    DisplayText = string.Empty;
                    break;
            }
        }
    }
}
