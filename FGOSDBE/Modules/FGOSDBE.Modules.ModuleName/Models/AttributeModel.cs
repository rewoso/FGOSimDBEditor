using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class AttributeModel
    {
        public Consts.Attribute Value { get; }
        public string ValueString { get; }
        public string DisplayText { get; }

        public AttributeModel()
        {

        }

        public AttributeModel(Consts.Attribute Attribute)
        {
            Value = Attribute;
            switch (Value)
            {
                case Consts.Attribute.Sky:
                    ValueString = Consts.AttributeDBValueSky;
                    DisplayText = Consts.AttributeTextSky;
                    break;
                case Consts.Attribute.Earth:
                    ValueString = Consts.AttributeDBValueEarth;
                    DisplayText = Consts.AttributeTextEarth;
                    break;
                case Consts.Attribute.Man:
                    ValueString = Consts.AttributeDBValueMan;
                    DisplayText = Consts.AttributeTextMan;
                    break;
                case Consts.Attribute.Star:
                    ValueString = Consts.AttributeDBValueStar;
                    DisplayText = Consts.AttributeTextStar;
                    break;
                case Consts.Attribute.Beast:
                    ValueString = Consts.AttributeDBValueBeast;
                    DisplayText = Consts.AttributeTextBeast;
                    break;
                default:
                    ValueString = string.Empty;
                    DisplayText = string.Empty;
                    break;
            }
        }
    }
}
