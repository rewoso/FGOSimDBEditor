using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class NPTypeModel
    {
        public Consts.NPType Value { get; }
        public string ValueString { get; }
        public string DisplayText { get; }

        public NPTypeModel()
        {

        }

        public NPTypeModel(Consts.NPType nptype)
        {
            Value = nptype;
            switch (Value)
            {
                case Consts.NPType.Baster:
                    ValueString = Consts.NPTypeDBValueBaster;
                    DisplayText = Consts.NPTypeTextBaster;
                    break;
                case Consts.NPType.Arts:
                    ValueString = Consts.NPTypeDBValueArts;
                    DisplayText = Consts.NPTypeTextArts;
                    break;
                case Consts.NPType.Quick:
                    ValueString = Consts.NPTypeDBValueQuick;
                    DisplayText = Consts.NPTypeTextQuick;
                    break;
                default:
                    ValueString = string.Empty;
                    DisplayText = string.Empty;
                    break;
            }
        }
    }
}
